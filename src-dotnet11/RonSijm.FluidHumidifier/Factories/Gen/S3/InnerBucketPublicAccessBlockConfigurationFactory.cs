// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketPublicAccessBlockConfigurationFactory(Action<Humidifier.S3.BucketTypes.PublicAccessBlockConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.PublicAccessBlockConfiguration>
{

    protected override Humidifier.S3.BucketTypes.PublicAccessBlockConfiguration Create()
    {
        var publicAccessBlockConfigurationResult = CreatePublicAccessBlockConfiguration();
        factoryAction?.Invoke(publicAccessBlockConfigurationResult);

        return publicAccessBlockConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.PublicAccessBlockConfiguration CreatePublicAccessBlockConfiguration()
    {
        var publicAccessBlockConfigurationResult = new Humidifier.S3.BucketTypes.PublicAccessBlockConfiguration();

        return publicAccessBlockConfigurationResult;
    }

} // End Of Class

public static class InnerBucketPublicAccessBlockConfigurationFactoryExtensions
{
}
