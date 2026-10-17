namespace AppleStore.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.SlackLoggingStack;

public class SlackLoggerStackComposer : BaseStackComposer<SlackLoggerStackConfig>
{
    public override StackCreateResult Create(SlackLoggerStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stackFactory = environmentFactory
            .AddStack("Slack Logger");

        var loggingName = $"{ResourceConfigSettings.ConceptNameLower}-sysops-{Environment.EnvironmentName}";

        var importedRole = config.Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.IAM.Role).Result as Role;

        FunctionFactory lambdaFunction = stackFactory
            .WithLambdaFunction("AWS-SlackNotificationLoggingFunction", function =>
            {
                function.Runtime = "nodejs20.x";
                function.FunctionName = "AWS-SlackNotificationLoggingFunction";
                function.Handler = "index.handler";
                function.Architectures = new List<string> { "x86_64" };
                function.MemorySize = 128;
                function.Timeout = 3;
                function.EphemeralStorage = new EphemeralStorage
                {
                    Size = 512
                };
                function.Role = importedRole.AsArn();
            })
              .WithCode(x =>
              {
                  x.S3Bucket = config.Import.Single(import => import.Result.AWSTypeName == Humidifier.AWS.S3.Bucket && import.Result.ResourceName.Contains("cloudformation")).ImportValue();
                  x.S3Key = "LambdaLoggerCode.zip";
              }).WithEnvironment(env =>
                {
                    env.Variables = new Dictionary<string, dynamic>
                        {
                            { "channel", loggingName }
                        };
                })
                .WithTracingConfig(x =>
                {
                    x.Mode = "PassThrough";
                });

        var topic = config.Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.SNS.Topic) as TopicFactory;

        stackFactory.WithLambdaPermission("LambdaInvokePermission", x =>
        {
            x.Action = "lambda:InvokeFunction";
            x.FunctionName = lambdaFunction.FFnREF();
            x.Principal = "sns.amazonaws.com";
            x.SourceArn = topic.ImportValue();
        });

        var subscription = stackFactory.WithSNSSubscription(loggingName, x =>
        {
            x.Protocol = "lambda";
            x.Endpoint = lambdaFunction.FFnGetARN();
            x.TopicArn = topic.ImportValue();
        });

        var stackResult = environmentFactory.Build().First();

        var result = new StackCreateResult
        {
            Stack = stackResult
        };

        return result;
    }
}
