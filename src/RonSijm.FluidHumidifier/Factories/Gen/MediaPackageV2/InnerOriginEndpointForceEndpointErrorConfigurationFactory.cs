// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointForceEndpointErrorConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.ForceEndpointErrorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.ForceEndpointErrorConfiguration>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.ForceEndpointErrorConfiguration Create()
    {
        var forceEndpointErrorConfigurationResult = CreateForceEndpointErrorConfiguration();
        factoryAction?.Invoke(forceEndpointErrorConfigurationResult);

        return forceEndpointErrorConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.ForceEndpointErrorConfiguration CreateForceEndpointErrorConfiguration()
    {
        var forceEndpointErrorConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.ForceEndpointErrorConfiguration();

        return forceEndpointErrorConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointForceEndpointErrorConfigurationFactoryExtensions
{
}
