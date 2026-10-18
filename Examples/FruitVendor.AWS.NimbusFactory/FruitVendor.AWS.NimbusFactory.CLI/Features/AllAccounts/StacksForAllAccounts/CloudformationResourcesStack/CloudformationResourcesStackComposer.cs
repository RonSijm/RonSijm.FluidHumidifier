using FruitVendor.AWS.NimbusFactory.CLI.Core.Config;

namespace FruitVendor.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.CloudformationResourcesStack;

public class CloudformationResourcesStackComposer : BaseStackComposer<CloudformationResourcesConfig>
{
    public override StackCreateResult Create(CloudformationResourcesConfig config)
    {
        var exportModel = new ExportModel();
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory.AddStack("Cloudformation Resources");
        var snsTopic = CreateSNSTopic(stack);
        var s3Bucket = CreateS3Bucket(config, stack, exportModel);

        var name = $"{Environment.EnvironmentName}-SlackLogger";
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
            role.ManagedPolicyArns = new List<Union<string, BaseFunction>> { policy.FFnREF() };
        });

        role.WithAssumeRolePolicy().WithStatement("sts:AssumeRole", principle: new PolicyPrincipal { Service = "lambda.amazonaws.com" });
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

        var condition = new Dictionary<string, Dictionary<string, object>>
        {
            ["StringEquals"] = new() { ["AWS:SourceOwner"] = Fn.Sub("${AWS::AccountId}") },
        };

        document.WithStatement(statementActions, principle: new PolicyPrincipal { AWS = "*" }, topic.FFnREF(), "Allow", condition, sid: "AllowSNS");

        var statementActions2 = new List<string>
        {
            "SNS:Publish"
        };

        document.WithStatement(statementActions2, principle: new PolicyPrincipal { Service = "cloudtrail.amazonaws.com" }, topic.FFnREF(), sid: "AllowCloudtrail");

        return topic;
    }
}