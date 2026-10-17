namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ECSServicesStack;

public static class DockerImageSelector
{
    public static string GetDockerImageTag(this EnvironmentConfig environment)
    {
        return GetDockerImageTag(environment.EnvironmentName);
    }

    public static string GetDockerImageTag(string environment)
    {
        return $"latest-{environment}";
    }
}