// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionTrustStoreConfigFactory(Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig>
{

    protected override Humidifier.CloudFront.DistributionTypes.TrustStoreConfig Create()
    {
        var trustStoreConfigResult = CreateTrustStoreConfig();
        factoryAction?.Invoke(trustStoreConfigResult);

        return trustStoreConfigResult;
    }

    private Humidifier.CloudFront.DistributionTypes.TrustStoreConfig CreateTrustStoreConfig()
    {
        var trustStoreConfigResult = new Humidifier.CloudFront.DistributionTypes.TrustStoreConfig();

        return trustStoreConfigResult;
    }

} // End Of Class

public static class InnerDistributionTrustStoreConfigFactoryExtensions
{
}
