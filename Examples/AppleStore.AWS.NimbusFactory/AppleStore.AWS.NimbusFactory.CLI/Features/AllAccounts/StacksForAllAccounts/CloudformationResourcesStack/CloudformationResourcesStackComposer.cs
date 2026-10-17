using Humidifier.S3.BucketTypes;
using Humidifier.CloudFront.DistributionTypes;
using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.LoadBalancerStack;
using RonSijm.FluidHumidifier.Factories.Events;
using Newtonsoft.Json;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.CloudformationResourcesStack;

public class CloudformationResourcesStackComposer : BaseStackComposer<CloudformationResourcesConfig>
{
    public override StackCreateResult Create(CloudformationResourcesConfig config)
    {
        var exportModel = new ExportModel();
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory.AddStack("Cloudformation Resources");
        var snsTopic = CreateSNSTopic(stack);

        //if (Environment.IsOTAPEnvironment)
        //{
        //    var ecsEventPattern = new EventPattern
        //    {
        //        Source = ["aws.ecs"],
        //        DetailType =
        //        [
        //            "ECS Task State Change",
        //            "ECS Container Instance State Change",
        //            "ECS Deployment State Change"
        //        ]
        //    };

        //    stack.WithEventsRule("Task-State-Change-Notification", rule =>
        //    {
        //        rule.EventBusName = "default";
        //        rule.State = "ENABLED";
        //        rule.Description = "Task State Change Notification";
        //        rule.EventPattern = JsonConvert.SerializeObject(ecsEventPattern);
        //    }).WithTargets(x =>
        //    {
        //        x.Arn = snsTopic.FFnREF();
        //        x.Id = "Idbeb109b8-06f8-4eef-b8d8-65daa26bb4c4";
        //    });
        //}
        //else
        //{
        //    var ecrEventPattern = new EventPattern
        //    {
        //        Source = ["aws.ecr"],
        //        DetailType = ["ECR Image Action"]
        //    };

        //    stack.WithEventsRule("ECR-Image-Push-Notification", rule =>
        //    {
        //        rule.EventBusName = "default";
        //        rule.State = "ENABLED";
        //        rule.EventPattern = JsonConvert.SerializeObject(ecrEventPattern);
        //        rule.Description = "ECR Image Push Notification";
        //    }).WithTargets(x =>
        //    {
        //        x.Arn = snsTopic.FFnREF();
        //        x.Id = "ECR-Image-Push-Notification-Target";
        //    });
        //}

        var name = $"{Environment.EnvironmentName}-SlackLogger";

        var s3Bucket = CreateS3Bucket(config, stack, exportModel);

        if (Environment.EnvironmentName != AccountConfigSettings.AssetAccountName)
        {
            var managerToolkitBucketName = $"{ResourceConfigSettings.ConceptName}-{Environment.EnvironmentName}-managertoolkit".ToLower();
            var managerToolkitBucket = stack.WithS3Bucket(managerToolkitBucketName);
            WithPublicCloudFrontPolicy(stack, managerToolkitBucketName, managerToolkitBucket);
            WithPublicCloudFront(stack, managerToolkitBucketName, "manager-toolkit");

            CreateOTAPBuckets(stack);
        }
        else
        {
            var dockerCacheBucketName = $"{ResourceConfigSettings.ConceptName}-{Environment.EnvironmentName}-webapp-dockercache".ToLower();
            var dockerCacheBucket = WithPublicAccess(stack, dockerCacheBucketName);
            WithPublicCloudFrontPolicy(stack, dockerCacheBucketName, dockerCacheBucket);
            WithPublicCloudFront(stack, dockerCacheBucketName, "dockercache");
        }

        var precompiledAssetsBucketName = $"{ResourceConfigSettings.ConceptName}-{Environment.EnvironmentName}-webapp-precompiledassets".ToLower();
        var precompiledAssetsBucket = WithPublicAccess(stack, precompiledAssetsBucketName);
        WithPublicCloudFrontPolicy(stack, precompiledAssetsBucketName, precompiledAssetsBucket);
        WithPublicCloudFront(stack, precompiledAssetsBucketName, "assets");

        var role = CreateRole(stack, name);

        exportModel.Add(role);
        exportModel.Add(s3Bucket);
        exportModel.Add(snsTopic);

        var result = new StackCreateResult
        {
            Stack = environmentFactory.Build().First(),
            Export = exportModel
        };

        return result;
    }

    private void CreateOTAPBuckets(StackFactory stack)
    {
        var envVarsBucket = stack.WithS3Bucket($"{ResourceConfigSettings.ConceptName}-{Environment.EnvironmentName}-webapp-{ResourceConfigSettings.EnvVarBucketName}");
        var webplayerBucket = stack.WithS3Bucket($"{ResourceConfigSettings.ConceptName}-{Environment.EnvironmentName}-webplayer");
    }

    private void WithPublicCloudFront(StackFactory stack, string bucketName, string subDomainName)
    {
        var distribution = stack.WithCloudFrontDistribution($"{bucketName}-CF", config =>
        {
            config.DistributionConfig = new DistributionConfig()
            {

                Aliases = new[] { $"{subDomainName}.{Environment.EnvironmentName}-applestore.example" },
                Origins = new List<Origin>()
                {
                    new()
                    {
                        DomainName = $"{bucketName}.s3.{Environment.Region}.amazonaws.com",
                        Id = bucketName,
                        S3OriginConfig = new S3OriginConfig()
                        {
                            OriginAccessIdentity = ""
                        }
                    }
                },
                DefaultCacheBehavior = new DefaultCacheBehavior()
                {
                    TargetOriginId = bucketName,
                    ViewerProtocolPolicy = "https-only",
                    AllowedMethods = new[] { "GET", "HEAD", "OPTIONS" },
                    CachedMethods = new[] { "GET", "HEAD", "OPTIONS" },
                    CachePolicyId = "658327ea-f89d-4fab-a63d-7e88639e58f6",
                    Compress = true,
                    SmoothStreaming = false,
                },
                PriceClass = "PriceClass_All",
                ViewerCertificate = new ViewerCertificate()
                {
                    AcmCertificateArn = CertificateRetriever.GetCertificateArnFromGlobal(Environment.EnvironmentName),
                    MinimumProtocolVersion = "TLSv1.2_2021",
                    SslSupportMethod = "sni-only"
                },
                Enabled = true,
            };
        });

        stack.WithRecordSet(record =>
        {
            record.HostedZoneName = $"{Environment.EnvironmentName}-applestore.example.";
            record.Type = "CNAME";
            record.Name = $"{subDomainName}.{Environment.EnvironmentName}-applestore.example";
            record.TTL = 300;
            record.ResourceRecords = new List<dynamic>() { FFn.FFnGetAtt(distribution, "DomainName") };
        });
    }

    private BucketFactory WithPublicAccess(StackFactory stack, string name)
    {
        var bucket = stack.WithS3Bucket(name).WithPublicAccessBlockConfiguration(acl =>
        {
            acl.BlockPublicAcls = false;
            acl.BlockPublicPolicy = false;
            acl.IgnorePublicAcls = false;
            acl.RestrictPublicBuckets = false;
        });

        bucket.WithOwnershipControls(owner =>
        {
            var rule = new OwnershipControlsRule
            {
                ObjectOwnership = "BucketOwnerEnforced"
            };

            owner.Rules =
            [
                rule
            ];
        });

        return bucket.T1;
    }

    private void WithPublicCloudFrontPolicy(StackFactory stack, string name, BucketFactory environmentVarBucket)
    {
        var condition = new Dictionary<string, Dictionary<string, dynamic>>
        {
            ["StringLike"] = new()
            {
                ["AWS:SourceArn"] = $"arn:aws:cloudfront::{Environment.AWSAccountId}:distribution/*"
            },
        };

        stack.WithS3BucketPolicy($"{name}-Policy", x =>
        {
            x.Bucket = environmentVarBucket.FFnREF();
            x.PolicyDocument = new
            {
                Version = "2012-10-17",
                Statement = new[]
                {
                    new
                    {
                        Effect = "Allow",
                        Principal = new { Service = "cloudfront.amazonaws.com"},
                        Action = new[] { "s3:GetObject" },
                        Resource = new[] { $"arn:aws:s3:::{name}/*" },
                        Condition = condition
                    }
                }
            };
        });
    }

    private BucketFactory CreateS3Bucket(CloudformationResourcesConfig config, StackFactory stack, ExportModel exportModel)
    {
        var s3Bucket = stack.WithS3Bucket($"aws-{Environment.EnvironmentName}-cloudformation-{ResourceConfigSettings.ConceptNameLower}");

        foreach (var extraBucket in config.S3BucketsForEnvironment)
        {
            var bucketName = extraBucket(Environment.EnvironmentName);
            var bucket = stack.WithS3Bucket(bucketName);
            exportModel.Add(bucket);
        }

        return s3Bucket;
    }

    private static RoleFactory CreateRole(StackFactory stack, string name)
    {
        var allowedActions = new List<string>
        {
            "logs:CreateLogGroup",
            "logs:CreateLogStream",
            "logs:PutLogEvents",
        };

        var policy = stack.WithManagedPolicy(name);

        var policyDocument = policy.WithDocument();

        policyDocument.WithStatement("logs:CreateLogGroup", resource: Fn.Sub("arn:aws:logs:${AWS::Region}:${AWS::AccountId}:*"), sid: "AllowCreateLogGroup");
        policyDocument.WithStatement(allowedActions, resource: Fn.Sub("arn:aws:logs:${AWS::Region}:${AWS::AccountId}:log-group:/aws/lambda/*"));

        var role = stack.WithRole(name, role =>
        {
            role.MaxSessionDuration = 3600;
            role.ManagedPolicyArns = new List<dynamic> { policy.FFnREF() };
        });

        role.WithAssumeRolePolicy().WithStatement("sts:AssumeRole", principle: new { Service = "lambda.amazonaws.com" });
        return role;
    }

    private TopicFactory CreateSNSTopic(StackFactory stackFactory)
    {
        var loggingName = $"{ResourceConfigSettings.ConceptNameLower}-sysops-{Environment.EnvironmentName}";

        var topic = stackFactory.WithSNSTopic(loggingName + "-Topic", x =>
        {
            x.DisplayName = loggingName;
        });

        var document = stackFactory.WithTopicPolicy(loggingName + "-TopicPolicy", x =>
        {
            x.Topics = topic.FFnREFList();
        }).WithDocument();

        var statementActions = new List<string>
        {
            "SNS:Publish",
            "SNS:SetTopicAttributes",
            "SNS:AddPermission",
            "SNS:RemovePermission",
            "SNS:DeleteTopic",
            "SNS:Subscribe",
            "SNS:ListSubscriptionsByTopic",
            "SNS:Publish",
            "SNS:Receive"
        };

        var condition = new Dictionary<string, Dictionary<string, dynamic>>
        {
            ["StringEquals"] = new() { ["AWS:SourceOwner"] = Fn.Sub("${AWS::AccountId}") },
        };

        document.WithStatement(statementActions, principle: new { AWS = "*" }, topic.FFnREF(), "Allow", condition, sid: "AllowSNS");

        var statementActions2 = new List<string>
        {
            "SNS:Publish"
        };

        document.WithStatement(statementActions2, principle: new { Service = "cloudtrail.amazonaws.com" }, topic.FFnREF(), sid: "AllowCloudtrail");

        return topic;
    }
}
