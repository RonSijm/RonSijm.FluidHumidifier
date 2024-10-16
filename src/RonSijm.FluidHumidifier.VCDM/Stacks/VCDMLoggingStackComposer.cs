using Humidifier;
using Humidifier.Interfaces;
using Humidifier.S3.BucketTypes;
using RonSijm.FluidHumidifier.Factories;
using RonSijm.FluidHumidifier.Factories.CloudTrail;
using RonSijm.FluidHumidifier.Factories.Config;
using RonSijm.FluidHumidifier.Factories.IAM;
using RonSijm.FluidHumidifier.Factories.S3;
using RonSijm.FluidHumidifier.Features.Consumer;
using RonSijm.FluidHumidifier.Factories.SQS;
using RonSijm.FluidHumidifier.VCDM.Config;
using RonSijm.FluidHumidifier.VCDM.Helpers;
using RonSijm.FluidHumidifier.VCDM.Models;

namespace RonSijm.FluidHumidifier.VCDM.Stacks
{
    /// <summary>
    /// CloudTrail: https://confluence.visma.com/display/SECURITY/Configure+Cloud+Log+Management+for+AWS+CloudTrail
    /// ELB: https://confluence.visma.com/display/SECURITY/Configure+Cloud+Log+Management+for+AWS+ELB
    /// GuardDuty: https://confluence.visma.com/display/SECURITY/Configure+Cloud+Log+Management+for+AWS+GuardDuty
    /// </summary>
    public class VCDMLoggingStackComposer : BaseStackComposer<VCDMLoggingStackConfig>
    {
        public override StackCreateResult Create(VCDMLoggingStackConfig config)
        {
            var exportModel = new ExportModel();
            var environmentFactory = CreateEnvironmentFactory();

            var stack = environmentFactory.AddStack($"VCDM {LoggingBucketNameFactory.ConceptName} Logging");

            var cloudTrailQueue = CreateCloudTrailQueue(stack);
            var loadBalancerQueue = CreateLoadBalancerQueue(stack);
            var guardDutyQueue = GuardDutyQueue(stack);

            var queues = new List<QueueWithPrefixModel>()
            {
                new(cloudTrailQueue, LoggingPrefixConfig.CloudTrailPrefix),
                new(loadBalancerQueue, LoggingPrefixConfig.LoadBalancerPrefix),
                new(guardDutyQueue, LoggingPrefixConfig.GuardDutyPrefix)
            };

            var s3Bucket = CreateBucket(stack, queues);
            var bucketPolicy = CreateBucketPolicy(stack, s3Bucket);

            var trail = stack.WithTrail($"{LoggingBucketNameFactory.ConceptName}-CloudTrail-Logging", trailOptions =>
            {
                trailOptions.IsLogging = true;
                trailOptions.S3BucketName = s3Bucket.FFnREF();
                trailOptions.IsMultiRegionTrail = true;
                trailOptions.IncludeGlobalServiceEvents = true;
                trailOptions.DependsOn = bucketPolicy.FFNamedList();
                trailOptions.S3KeyPrefix = LoggingPrefixConfig.CloudTrailPrefix;
            }).WithEventSelectors(eventSelectors =>
            {
                eventSelectors.ReadWriteType = "All";
                eventSelectors.IncludeManagementEvents = true;
                eventSelectors.ExcludeManagementEventSources = new List<string>() { "kms.amazonaws.com" };
            });

            CreateRoleForVisma(stack, s3Bucket, queues);

            var awsConfigRule = CreateRoleAWSConfig(stack, s3Bucket);

            var recorder = stack.WithConfigurationRecorder($"{LoggingBucketNameFactory.ConceptName}-AWS-Configuration-Recorder", configurationRecorder =>
            {
                configurationRecorder.RoleARN = awsConfigRule.FFnGetARN();
            }).WithRecordingGroup(x =>
            {
                x.AllSupported = true;
                x.IncludeGlobalResourceTypes = true;
            });

            var deliveryChannel = stack.WithDeliveryChannel($"{LoggingBucketNameFactory.ConceptName}-AWS-Configuration-DeliveryChannel", channel =>
            {
                channel.S3BucketName = s3Bucket.FFnREF();
                channel.S3KeyPrefix = LoggingPrefixConfig.AWSConfig;
            }).WithConfigSnapshotDeliveryProperties(x =>
            {
                x.DeliveryFrequency = "TwentyFour_Hours";
            });

            var result = new StackCreateResult
            {
                Stack = environmentFactory.Build().First(),
                Export = exportModel
            };

            return result;
        }

        private QueueFactory CreateLoadBalancerQueue(StackFactory stack)
        {
            var loadBalancerQueue = stack.WithSQSQueue($"{LoggingBucketNameFactory.ConceptName}-LoadBalancer-Logging-Queue", options =>
            {
                options.SqsManagedSseEnabled = true;
            });

            var loadBalancerQueuePolicy = stack.WithQueuePolicy($"{LoggingBucketNameFactory.ConceptName}-LoadBalancer-Logging-Queue-Policy", policyOptions =>
                {
                    policyOptions.Queues = loadBalancerQueue.FFnREFList();
                })
                .WithDocument().WithStatement(
                    action: "SQS:SendMessage",
                    principle: new { Service = "s3.amazonaws.com" },
                    resource: new Lazy<string>(() => $"arn:aws:sqs:eu-central-1:{Environment.AWSAccountId}:{loadBalancerQueue.Result.QueueName}")
                );
            return loadBalancerQueue;
        }

        private QueueFactory GuardDutyQueue(StackFactory stack)
        {
            var guardDutyQueue = stack.WithSQSQueue($"{LoggingBucketNameFactory.ConceptName}-GuardDuty-Logging-Queue", options =>
            {
                options.SqsManagedSseEnabled = true;
            });

            var guardDutyQueuePolicy = stack.WithQueuePolicy($"{LoggingBucketNameFactory.ConceptName}-GuardDuty-Logging-Queue-Policy", policyOptions =>
                {
                    policyOptions.Queues = guardDutyQueue.FFnREFList();
                })
                .WithDocument().WithStatement(
                    action: "SQS:SendMessage",
                    principle: new { Service = "s3.amazonaws.com" },
                    resource: new Lazy<string>(() => $"arn:aws:sqs:eu-central-1:{Environment.AWSAccountId}:{guardDutyQueue.Result.QueueName}")
                );

            return guardDutyQueue;
        }

        private QueueFactory CreateCloudTrailQueue(StackFactory stack)
        {
            var cloudTrailQueue = stack.WithSQSQueue($"{LoggingBucketNameFactory.ConceptName}-CloudTrail-Logging-Queue", options =>
            {
                options.SqsManagedSseEnabled = true;
            });

            var cloudTrailQueuePolicy = stack.WithQueuePolicy($"{LoggingBucketNameFactory.ConceptName}-CloudTrail-Logging-Queue-Policy", policyOptions =>
                {
                    policyOptions.Queues = cloudTrailQueue.FFnREFList();
                })
                .WithDocument().WithStatement(
                    action: "SQS:SendMessage",
                    principle: new { Service = "s3.amazonaws.com" },
                    resource: new Lazy<string>(() => $"arn:aws:sqs:eu-central-1:{Environment.AWSAccountId}:{cloudTrailQueue.Result.QueueName}")
                );

            return cloudTrailQueue;
        }

        private BucketPolicyFactory CreateBucketPolicy(StackFactory stack, BucketFactory bucket)
        {
            var bucketPolicy = stack.WithS3BucketPolicy($"aws-{LoggingBucketNameFactory.ConceptName}-{Environment.EnvironmentName}-logging-policy", policy =>
            {
                policy.Bucket = bucket.FFnREF();
            });

            var document = bucketPolicy.WithDocument();

            var condition = new Dictionary<string, Dictionary<string, dynamic>>
            {
                ["StringLike"] = new() { ["AWS:SourceArn"] = $"arn:aws:cloudtrail:{Environment.Region}:{Environment.AWSAccountId}:trail/*" },
            };

            document.WithStatement("s3:GetBucketAcl",
                principle: new { Service = "cloudtrail.amazonaws.com" },
                resource: new List<dynamic>()
                {
                    new Lazy<string>(() => $"arn:aws:s3:::{bucket.Result.BucketName}")
                },
                condition: condition,
                sid: "AWSCloudTrailAclCheck");

            var condition2 = new Dictionary<string, Dictionary<string, dynamic>>
            {
                ["StringEquals"] = new() { ["s3:x-amz-acl"] = "bucket-owner-full-control" },
            };

            document.WithStatement("s3:PutObject",
                principle: new { Service = "cloudtrail.amazonaws.com" },
                resource: new Lazy<string>(() => $"arn:aws:s3:::{bucket.Result.BucketName}/*"),
                condition: condition2,
                sid: "AWSCloudTrailWrite");

            document.WithStatement("s3:PutObject",
                principle: new { Service = "config.amazonaws.com" },
                resource: new Lazy<string>(() => $"arn:aws:s3:::{bucket.Result.BucketName}/*"),
                condition: condition2,
                sid: "AWSConfigWrite");

            return bucketPolicy;
        }

        private BucketFactory CreateBucket(StackFactory stack, List<QueueWithPrefixModel> queues)
        {
            var loggingBucketName = LoggingBucketNameFactory.GetBucketName(Environment);

            var s3Bucket = stack.WithS3Bucket(loggingBucketName, bucket =>
            {
                bucket.DependsOn = queues.Select(x => x.Queue).Cast<IResultFactory>().ToList().FFNamedList();
            });

            s3Bucket.WithLifecycleConfiguration(lifecycle =>
            {
                lifecycle.Rules =
                [
                    new()
                    {
                        Id = "ex_year_trans_mo",
                        Status = "Enabled",
                        ExpirationInDays = 120,
                        Transitions =
                        [
                            new()
                            {
                                TransitionInDays = 30,
                                StorageClass = "STANDARD_IA"
                            }
                        ]
                    }
                ];
            });

            s3Bucket.WithNotificationConfiguration(notification =>
            {
                if (queues == null || !queues.Any())
                {
                    return;
                }

                notification.QueueConfigurations = [];

                foreach (var queueWithPrefixModel in queues)
                {
                    notification.QueueConfigurations.Add(CreateS3Notification(queueWithPrefixModel));
                }
            });

            return s3Bucket;
        }

        private QueueConfiguration CreateS3Notification(QueueWithPrefixModel queue)
        {
            return new()
            {
                Event = "s3:ObjectCreated:*",
                Queue = queue.Queue.FFnGetARN(),
                Filter = new NotificationFilter()
                {
                    S3Key = new S3KeyFilter()
                    {
                        Rules =
                        [
                            new FilterRule()
                            {
                                Name = "prefix",
                                Value = $"{queue.Prefix}/"
                            }
                        ]
                    }
                }
            };
        }

        public RoleFactory CreateRoleForVisma(StackFactory stack, BucketFactory bucket, List<QueueWithPrefixModel> queues)
        {
            var role = stack.WithRole($"GSOC-SLM-Logging-{LoggingBucketNameFactory.ConceptName}-Role");

            InnerRolePolicyFactory rolePolicy = role.WithPolicies();

            var policyDocument = rolePolicy.WithDocument();
            policyDocument.WithStatement(
                action: ["s3:GetObject", "s3:ListBucket"],
                resource: new List<dynamic>()
                {
                    new Lazy<string>(() => $"arn:aws:s3:::{bucket.Result.BucketName}/*"),
                    new Lazy<string>(() => $"arn:aws:s3:::{bucket.Result.BucketName}")
                },
                sid: "AllowGetObjectsFromBucket");

            foreach (var queueWithPrefixModel in queues)
            {
                policyDocument.WithStatement(
                    action: "sqs:*",
                    resource: queueWithPrefixModel.Queue.FFnGetARN(),
                    sid: $"Allow{queueWithPrefixModel.Prefix}QueueToUseSQS");
            }

            policyDocument.WithStatement(
                action: ["kms:Decrypt", "kms:GenerateDataKey"],
                resource: Fn.Sub($"arn:aws:kms:${{AWS::Region}}:${{AWS::AccountId}}:alias/KMS-{Environment.EnvironmentName}-CMK"),
                sid: "AllowUseKMSKey");

            var vismaAccount = VismaAccountConfigSelector.GetVismaAccountConfig(Environment);

            role.WithAssumeRolePolicy()
                .WithStatement(
                    action: "sts:AssumeRole",
                    principle: new { AWS = $"arn:aws:iam::{vismaAccount.AWSAccountId}:user/{vismaAccount.EnvironmentName}" });

            return role;
        }

        public RoleFactory CreateRoleAWSConfig(StackFactory stack, BucketFactory bucket)
        {
            var role = stack.WithRole($"AWSConfig-Logging-{LoggingBucketNameFactory.ConceptName}-Role");

            role.WithAssumeRolePolicy()
                .WithStatement(
                    action: "sts:AssumeRole",
                    principle: new { Service = "config.amazonaws.com" },
                    condition: new Dictionary<string, Dictionary<string, dynamic>>
                    {
                        ["StringEquals"] = new() { ["AWS:SourceAccount"] = Environment.AWSAccountId },
                    });

            InnerRolePolicyFactory rolePolicy = role.WithPolicies();

            var policyDocument = rolePolicy.WithDocument();
            policyDocument.WithStatement(
                action: ["s3:PutObject", "s3:PutObjectAcl", "s3:GetBucketAcl", "s3:GetBucketLocation"],
                resource: new List<dynamic>()
                {
                    new Lazy<string>(() => $"arn:aws:s3:::{bucket.Result.BucketName}/*"),
                    new Lazy<string>(() => $"arn:aws:s3:::{bucket.Result.BucketName}")
                },
                sid: "AllowAWSConfigGetObjectsFromBucket");

            policyDocument.WithStatement(
                action: ["ec2:Describe*",
                         "s3:ListBucket",
                         "rds:Describe*",
                         "rds:ListTagsForResource",
                         "cloudtrail:DescribeTrails",
                         "cloudtrail:GetTrailStatus",
                         "cloudtrail:ListTags",
                         "cloudtrail:ListTrails"],
                resource: "*",
                sid: "AllowAWSConfigOtherThings");

            return role;
        }
    }
}