using RonSijm.FluidHumidifier.Features.Consumer;

namespace RonSijm.FluidHumidifier.VCDM.Helpers
{
    public static class LoggingBucketNameFactory
    {
        public static string ConceptName { get; set; }

        public static string GetBucketName(EnvironmentConfig environment)
        {
            return GetBucketName(environment.EnvironmentName);
        }

        public static string GetBucketName(string environmentName)
        {
            return $"aws-{ConceptName}-{environmentName}-logging";
        }
    }
}
