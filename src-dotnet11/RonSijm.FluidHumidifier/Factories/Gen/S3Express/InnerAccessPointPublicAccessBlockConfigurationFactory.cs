// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class InnerAccessPointPublicAccessBlockConfigurationFactory(Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration>
{

    protected override Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration Create()
    {
        var publicAccessBlockConfigurationResult = CreatePublicAccessBlockConfiguration();
        factoryAction?.Invoke(publicAccessBlockConfigurationResult);

        return publicAccessBlockConfigurationResult;
    }

    private Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration CreatePublicAccessBlockConfiguration()
    {
        var publicAccessBlockConfigurationResult = new Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration();

        return publicAccessBlockConfigurationResult;
    }

} // End Of Class

public static class InnerAccessPointPublicAccessBlockConfigurationFactoryExtensions
{
}
