// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory(Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration>
{

    protected override Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration Create()
    {
        var publicAccessBlockConfigurationResult = CreatePublicAccessBlockConfiguration();
        factoryAction?.Invoke(publicAccessBlockConfigurationResult);

        return publicAccessBlockConfigurationResult;
    }

    private Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration CreatePublicAccessBlockConfiguration()
    {
        var publicAccessBlockConfigurationResult = new Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration();

        return publicAccessBlockConfigurationResult;
    }

} // End Of Class

public static class InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactoryExtensions
{
}
