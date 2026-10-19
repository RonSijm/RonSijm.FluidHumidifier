// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointContentKeyPeriodConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.ContentKeyPeriodConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.ContentKeyPeriodConfiguration>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.ContentKeyPeriodConfiguration Create()
    {
        var contentKeyPeriodConfigurationResult = CreateContentKeyPeriodConfiguration();
        factoryAction?.Invoke(contentKeyPeriodConfigurationResult);

        return contentKeyPeriodConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.ContentKeyPeriodConfiguration CreateContentKeyPeriodConfiguration()
    {
        var contentKeyPeriodConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.ContentKeyPeriodConfiguration();

        return contentKeyPeriodConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointContentKeyPeriodConfigurationFactoryExtensions
{
}
