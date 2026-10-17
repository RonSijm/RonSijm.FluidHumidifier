namespace FruitVendor.AWS.NimbusFactory.CLI.Core.Config;

public static class ResourceConfigSettings
{
    public const string DatabaseName = "PostgreSQL";
    public const string DatabaseGroupName = "RDS";

    public const string BackendName = "fruitvendorbe";
    public const string ServiceName = "fruitvendorai";
    public const string LoadBalancerName = $"{ServiceName}-LB";

    public const string EnvVarBucketName = "environmentvariables";

    public const string ConceptName = "FruitVendor";
    public const string ConceptNameLower = "fruitvendor";
}