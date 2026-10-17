using AppleStore.AWS.NimbusFactory.CLI.Features.AssetsAccount.StacksForAssets.ERCServiceStack;
using Humidifier.ApplicationAutoScaling.ScalingPolicyTypes;
using Humidifier.ECS.TaskDefinitionTypes;
using RonSijm.FluidHumidifier.Factories.ApplicationAutoScaling;
using RonSijm.FluidHumidifier.Factories.ECS;
using RonSijm.FluidHumidifier.Factories.IAM;
using RonSijm.FluidHumidifier.Features;
using RonSijm.FluidHumidifier.Features.Helpers.ECS.TaskDefinitionTypes;
using KeyValuePair = Humidifier.ECS.TaskDefinitionTypes.KeyValuePair;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ECSServicesStack;

public class ECSServiceStackComposer : BaseStackComposer<ECSServiceStackConfig>
{
    public override StackCreateResult Create(ECSServiceStackConfig config)
    {
        var environmentFactory = this.CreateEnvironmentFactory();

        var stack = environmentFactory
            .AddStack("ECS Services");

        // Create the ECS Cluster first, so we don't have to roll that back.
        var ecsCluster = stack.WithECSCluster("ECSCluster", x =>
        {
            x.ClusterName = $"{ResourceConfigSettings.ConceptName}-{Environment.EnvironmentName}-Cluster";
            x.CapacityProviders = new[] { "FARGATE", "FARGATE_SPOT" };
        });

        CreatePumaService(config, stack, ecsCluster);
        CreateSidekiqService(config, stack, ecsCluster);
        CreateRpushService(config, stack, ecsCluster);
        CreateJobsService(config, stack, ecsCluster);
        CreateIdleService(config, stack, ecsCluster);

        var stackResult = environmentFactory.Build().First();

        var result = new StackCreateResult
        {
            Stack = stackResult
        };

        return result;
    }

    private void CreatePumaService(ECSServiceStackConfig config, StackFactory stack, ClusterFactory ecsCluster)
    {
        var pumaServiceName = $"{Environment.EnvironmentName}-{ResourceConfigSettings.ServiceName.ToLower()}";
        stack.WithLogGroup($"/ecs/{pumaServiceName}");

        var pumaContainerDefinition = new Action<ContainerDefinition>(containerDefinition =>
        {
            var portMapping = new List<PortMapping>
            {
                new()
                {
                    Protocol = "tcp",
                    HostPort = PortConfig.PumaPort.ToString(),
                    ContainerPort = PortConfig.PumaPort.ToString(),
                    AppProtocol = "http"
                }
            };

            CreateContainerDefinition(config, containerDefinition, pumaServiceName, portMapping: portMapping);
        });

        var pumaTaskDefinition = CreateTaskDefinition(stack, pumaServiceName, config.TaskRole, "2048", "8192", null, pumaContainerDefinition);

        if (!config.CreateServices)
        {
            return;
        }

        var pumaMinCapacity = 3;
        var service = CreateService(config, stack, pumaServiceName, ecsCluster, pumaTaskDefinition, pumaMinCapacity);

        if (config.LoadBalancer != null)
        {
            service.WithLoadBalancers(x =>
            {
                x.ContainerName = $"{pumaServiceName}-ContainerDefinition";
                x.ContainerPort = PortConfig.PumaPort;
                x.TargetGroupArn = config.LoadBalancer;
            });
        }

        var autoScaleRole = stack.WithRole("AutoScaleRole", role =>
        {
            role.RoleName = "ECS-AutoScale-Role";
        });

        autoScaleRole.WithAssumeRolePolicy()
            .WithStatement("sts:AssumeRole", principle: new { Service = "application-autoscaling.amazonaws.com" });

        InnerRolePolicyFactory policy = autoScaleRole.WithPolicies();

        policy.WithDocument()
            .WithStatement([
                "ecs:UpdateService",
                "ecs:DescribeServices",
                "cloudwatch:DescribeAlarms",
                "cloudwatch:GetMetricStatistics",
                "cloudwatch:ListMetrics",
                "cloudwatch:PutMetricAlarm"
            ], resource: "*");


        var scalingTarget = stack.WithScalableTarget("PumaServiceScalableTarget", scalableTarget =>
        {
            scalableTarget.MaxCapacity = pumaMinCapacity * 5;
            scalableTarget.MinCapacity = pumaMinCapacity;
            scalableTarget.ResourceId = Fn.Join("", "service/", ecsCluster.FFnREF(), "/", service.FFnGetAtt("Name"));
            scalableTarget.RoleARN = autoScaleRole.FFnGetARN();
            scalableTarget.ScalableDimension = "ecs:service:DesiredCount";
            scalableTarget.ServiceNamespace = "ecs";
        });

        stack.WithApplicationAutoScalingScalingPolicy("PumaServiceCPUScalingPolicy", scalingPolicy =>
        {
            scalingPolicy.PolicyName = "PumaCpuScalingPolicy";
            scalingPolicy.PolicyType = "TargetTrackingScaling";
            scalingPolicy.ScalingTargetId = scalingTarget.FFnREF();
        }).WithTargetTrackingScalingPolicyConfiguration(targetTrackingScalingPolicyConfiguration =>
        {
            targetTrackingScalingPolicyConfiguration.PredefinedMetricSpecification = new PredefinedMetricSpecification()
            {
                PredefinedMetricType = "ECSServiceAverageCPUUtilization"
            };
            targetTrackingScalingPolicyConfiguration.TargetValue = 80;
            targetTrackingScalingPolicyConfiguration.ScaleInCooldown = 600;
            targetTrackingScalingPolicyConfiguration.ScaleOutCooldown = 60;
        });

        stack.WithApplicationAutoScalingScalingPolicy("PumaServiceMemoryScalingPolicy", scalingPolicy =>
        {
            scalingPolicy.PolicyName = "PumaMemoryScalingPolicy";
            scalingPolicy.PolicyType = "TargetTrackingScaling";
            scalingPolicy.ScalingTargetId = scalingTarget.FFnREF();
        }).WithTargetTrackingScalingPolicyConfiguration(targetTrackingScalingPolicyConfiguration =>
        {
            targetTrackingScalingPolicyConfiguration.PredefinedMetricSpecification = new PredefinedMetricSpecification()
            {
                PredefinedMetricType = "ECSServiceAverageMemoryUtilization"
            };
            targetTrackingScalingPolicyConfiguration.TargetValue = 80;
            targetTrackingScalingPolicyConfiguration.ScaleInCooldown = 600;
            targetTrackingScalingPolicyConfiguration.ScaleOutCooldown = 60;
        });
    }

    private void CreateSidekiqService(ECSServiceStackConfig config, StackFactory stack, ClusterFactory ecsCluster)
    {
        var sideKiqServiceName = $"{Environment.EnvironmentName}-sidekiq";
        stack.WithLogGroup($"/ecs/{sideKiqServiceName}");

        var sidekiqBaseCommand = new List<string>
        {
            "/usr/local/bin/bundle",
            "exec",
            "sidekiq",
            "-C",
        };

        var entryPoint = new List<string> { "/rails/bin/docker-entrypoint" };

        var sidekiqContainerDefinition = new Action<ContainerDefinition>(containerDefinition =>
        {
            var sidekiqCommand = sidekiqBaseCommand.ToList();
            sidekiqCommand.Add("/rails/config/sidekiq.yml");
            CreateContainerDefinition(config, containerDefinition, sideKiqServiceName, sidekiqCommand, entryPoint);
        });

        var exportContainerDefinition = new Action<ContainerDefinition>(containerDefinition =>
        {
            var sidekiqCommand = sidekiqBaseCommand.ToList();
            sidekiqCommand.Add("/rails/config/sidekiq-content-export.yml");
            CreateContainerDefinition(config, containerDefinition, sideKiqServiceName + "-export", sidekiqCommand, entryPoint);
        });

        var duplicationHighPriority = new Action<ContainerDefinition>(containerDefinition =>
        {
            var sidekiqCommand = sidekiqBaseCommand.ToList();
            sidekiqCommand.Add("/rails/config/sidekiq-duplication-high-priority.yml");
            CreateContainerDefinition(config, containerDefinition, sideKiqServiceName + "-duplication-high-priority", sidekiqCommand, entryPoint);
        });

        var duplicationLowPriority = new Action<ContainerDefinition>(containerDefinition =>
        {
            var sidekiqCommand = sidekiqBaseCommand.ToList();
            sidekiqCommand.Add("/rails/config/sidekiq-duplication-low-priority.yml");
            CreateContainerDefinition(config, containerDefinition, sideKiqServiceName + "-duplication-low-priority", sidekiqCommand, entryPoint);
        });

        var sidekiqTaskDefinition = CreateTaskDefinition(stack, sideKiqServiceName, config.TaskRole, "1024", "8192", storageInGb: 40, sidekiqContainerDefinition, exportContainerDefinition, duplicationHighPriority, duplicationLowPriority);

        if (config.CreateServices)
        {
            CreateService(config, stack, sideKiqServiceName, ecsCluster, sidekiqTaskDefinition);
        }
    }

    private void CreateRpushService(ECSServiceStackConfig config, StackFactory stack, ClusterFactory ecsCluster)
    {
        var rpushServiceName = $"{Environment.EnvironmentName}-rpush";
        stack.WithLogGroup($"/ecs/{rpushServiceName}");

        var entryPoint = new List<string> { "/rails/bin/docker-entrypoint" };

        var startRPush = new Action<ContainerDefinition>(containerDefinition =>
        {
            var command = new List<string>
            {
                "/usr/local/bin/bundle",
                "exec",
                "rpush",
                "start",
                "-f",
            };

            CreateContainerDefinition(config, containerDefinition, rpushServiceName + "-rpush", command, entryPoint);
        });

        var taskDefinition = CreateTaskDefinition(stack, rpushServiceName, config.TaskRole, "1024", "3072", null, startRPush);

        if (config.CreateServices)
        {
            CreateService(config, stack, rpushServiceName, ecsCluster, taskDefinition);
        }
    }

    private void CreateIdleService(ECSServiceStackConfig config, StackFactory stack, ClusterFactory ecsCluster)
    {
        var idleServiceName = $"{Environment.EnvironmentName}-idle";
        stack.WithLogGroup($"/ecs/{idleServiceName}");

        var entryPoint = new List<string> { "/rails/bin/docker-entrypoint" };

        var startRPush = new Action<ContainerDefinition>(containerDefinition =>
        {
            var command = new List<string>
            {
                "tail",
                "-f",
                "/dev/null",
            };

            CreateContainerDefinition(config, containerDefinition, idleServiceName + "-idle", command, entryPoint);
        });

        var taskDefinition = CreateTaskDefinition(stack, idleServiceName, config.TaskRole, "256", "512", null, startRPush);

        if (config.CreateServices)
        {
            CreateService(config, stack, idleServiceName, ecsCluster, taskDefinition);
        }
    }

    private void CreateJobsService(ECSServiceStackConfig config, StackFactory stack, ClusterFactory ecsCluster)
    {
        var jobsServiceName = $"{Environment.EnvironmentName}-cronjobs";
        stack.WithLogGroup($"/ecs/{jobsServiceName}");

        var entryPoint = new List<string> { "/rails/bin/docker-entrypoint" };

        var jobsCommand = new List<string>
        {
            "cron",
            "-f",
        };

        var jobsContainerDefinition1 = new Action<ContainerDefinition>(containerDefinition =>
        {
            CreateContainerDefinition(config, containerDefinition, jobsServiceName + "-jobs1", jobsCommand, entryPoint, environment: [new KeyValuePair() { Name = "SERVER_ROLE", Value = "jobs_1" }], username: "root");
        });

        var jobsContainerDefinition2 = new Action<ContainerDefinition>(containerDefinition =>
        {
            CreateContainerDefinition(config, containerDefinition, jobsServiceName + "-jobs2", jobsCommand, entryPoint, environment: [new KeyValuePair() { Name = "SERVER_ROLE", Value = "jobs_2" }], username: "root");
        });

        var jobsTaskDefinition = CreateTaskDefinition(stack, jobsServiceName, config.TaskRole, "1024", "3072", null, jobsContainerDefinition1, jobsContainerDefinition2);

        if (config.CreateServices)
        {
            CreateService(config, stack, jobsServiceName, ecsCluster, jobsTaskDefinition);
        }
    }

    private void CreateContainerDefinition(ECSServiceStackConfig config, ContainerDefinition containerDefinition, string sidekiqServiceName, dynamic command = null, dynamic entryPoint = null, List<PortMapping> portMapping = null, List<KeyValuePair> environment = null, string username = null)
    {
        containerDefinition.Name = $"{sidekiqServiceName}-ContainerDefinition";
        containerDefinition.Command = command;
        containerDefinition.EntryPoint = entryPoint;
        containerDefinition.Environment = environment;
        containerDefinition.User = username;

        containerDefinition.EnvironmentFiles =
        [
            new EnvironmentFile
            {
                Type = "s3",
                Value = $"arn:aws:s3:::{ResourceConfigSettings.ConceptNameLower}-{Environment.EnvironmentName}-webapp-{ResourceConfigSettings.EnvVarBucketName}/{ResourceConfigSettings.ConceptNameLower}-webapp.env"
            }
        ];

        containerDefinition.Essential = true;
        containerDefinition.Image = $"{config.AssetsAccountId}.dkr.ecr.{AWSConfigSettings.AssetsRegion}.amazonaws.com/{ECRServiceConfig.RepositoryName}:{Environment.GetDockerImageTag()}";
        containerDefinition.MountPoints =
        [
            new MountPoint
            {
                ContainerPath = "/webapp/log",
                ReadOnly = false,
                SourceVolume = "log"
            }
        ];

        containerDefinition.PortMappings = portMapping;

        // Fake Health check
        containerDefinition.HealthCheck = FakeHealthCheckFactory.FakeHealthCheck;
    }

    private ServiceFactory CreateService(ECSServiceStackConfig config, StackFactory stack, string serviceName, ClusterFactory ecsCluster, TaskDefinitionFactory taskDefinition, int desiredCount = 1)
    {
        var ecsService = stack.WithECSService($"{ResourceConfigSettings.ConceptName}-{serviceName}", x =>
        {
            x.ServiceName = $"{ResourceConfigSettings.ConceptName}-{serviceName}";
            x.Cluster = ecsCluster.FFnREF();
            x.DesiredCount = desiredCount;
            x.PlatformVersion = "1.4.0";
            x.TaskDefinition = taskDefinition.FFnREF();
            x.SchedulingStrategy = "REPLICA";
            x.EnableExecuteCommand = true;
            x.CreationPolicy = new CreationPolicy
            {
                ResourceSignal = new ResourceSignal
                {
                    Count = 0,
                    Timeout = "PT1S"
                }
            };
        });

        ecsService.WithDeploymentConfiguration(x =>
            {
                x.MaximumPercent = 200;
                x.MinimumHealthyPercent = 100;
            })
            .WithDeploymentCircuitBreaker(x =>
            {
                x.Enable = false; // TODO: idk why it's breaking
                x.Rollback = false;
            });

        var deploymentCircuit = ecsService
          .WithNetworkConfiguration()
          .WithAwsvpcConfiguration(vpnConfig =>
          {
              vpnConfig.AssignPublicIp = "ENABLED";
              vpnConfig.SecurityGroups = config.SecurityGroups;
              vpnConfig.Subnets = config.DockerSubnets;
          }).WithDeploymentController(x => x.Type = "ECS")
            .WithCapacityProviderStrategy(x =>
             {
                 x.CapacityProvider = "FARGATE";
                 x.Weight = 1;
             });

        return ecsService;
    }

    private TaskDefinitionFactory CreateTaskDefinition(StackFactory stack, string serviceName, RoleFactory taskRole, string cpu = "1024", string memory = "3072", int? storageInGb = null, params Action<ContainerDefinition>[] subFactoryActions)
    {
        var taskDefinition = stack.WithECSTaskDefinition(serviceName, x =>
        {
            x.Family = serviceName;
            x.NetworkMode = "awsvpc";
            x.RequiresCompatibilities = new[] { "FARGATE" };
            x.Cpu = cpu; // TODO: Maybe in config
            x.Memory = memory; // TODO: Maybe in config

            if (taskRole.Result.Export)
            {
                x.TaskRoleArn = taskRole.ImportValue();
                x.ExecutionRoleArn = taskRole.ImportValue();
            }
            else
            {
                x.TaskRoleArn = taskRole.FFnREF();
                x.ExecutionRoleArn = taskRole.FFnREF();
            }
        });

        taskDefinition.WithRuntimePlatform(x =>
        {
            x.CpuArchitecture = "X86_64";
            x.OperatingSystemFamily = "LINUX";
        });


        taskDefinition.WithVolumes(x =>
        {
            x.Name = "log";
        });

        if (storageInGb.HasValue)
        {
            taskDefinition.WithEphemeralStorage(x =>
            {
                x.SizeInGiB = storageInGb.Value.ToString();
            });
        }

        foreach (var subFactoryAction in subFactoryActions)
        {
            var containerDefinitions = taskDefinition.WithContainerDefinitions(subFactoryAction);

            containerDefinitions.WithLogConfiguration(logging =>
            {
                logging.LogDriver = "awslogs";
                logging.Options = new Dictionary<string, dynamic>
                {
                    { "awslogs-group", $"/ecs/{serviceName}" },
                    { "awslogs-create-group", "true" },
                    { "awslogs-region", AWSConfigSettings.DefaultRegion },
                    { "awslogs-stream-prefix", "ecs" },
                };
            });
        }

        return taskDefinition;
    }
}
