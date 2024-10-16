// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketCorsConfigurationFactory(Action<Humidifier.S3.BucketTypes.CorsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.CorsConfiguration>
{

    protected override Humidifier.S3.BucketTypes.CorsConfiguration Create()
    {
        var corsConfigurationResult = CreateCorsConfiguration();
        factoryAction?.Invoke(corsConfigurationResult);

        return corsConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.CorsConfiguration CreateCorsConfiguration()
    {
        var corsConfigurationResult = new Humidifier.S3.BucketTypes.CorsConfiguration();

        return corsConfigurationResult;
    }

} // End Of Class

public static class InnerBucketCorsConfigurationFactoryExtensions
{
}
