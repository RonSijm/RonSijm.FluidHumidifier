namespace AppleStore.AWS.NimbusFactory.CLI.Core.Config;

public static class ResourceConfigSettings
{
    public static Func<string, string> AccessToAssetsRoleName = x =>
    {
        if (x == AccountConfigSettings.AssetAccountName)
        {
            return $"ECR-{AccountConfigSettings.AssetAccountName}-AccessRole";
        }

        return $"ECR-{x}-to-assets-AccessRole";
    };

    public const string DockerName = "Docker";
    public const string RedisName = "Redis";
    public const string DatabaseName = "PostgreSQL";
    public const string DatabaseGroupName = "RDS";
    public const string ServiceName = "Puma";

    public const string LoadBalancerName = $"{ServiceName}-LB";

    public const string EnvVarBucketName = "environmentvariables";

    public const string ConceptName = "AppleStore";
    public const string ConceptNameLower = "applestore";
}