namespace AppleStore.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.CloudformationResourcesStack;

public class CloudformationResourcesConfig
{
    public List<Func<string, string>> S3BucketsForEnvironment { get; set; } = [];
}