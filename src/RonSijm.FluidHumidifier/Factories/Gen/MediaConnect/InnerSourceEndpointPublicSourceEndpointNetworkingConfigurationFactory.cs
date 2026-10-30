// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerSourceEndpointPublicSourceEndpointNetworkingConfigurationFactory(Action<Humidifier.MediaConnect.SourceEndpointTypes.PublicSourceEndpointNetworkingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.SourceEndpointTypes.PublicSourceEndpointNetworkingConfiguration>
{

    protected override Humidifier.MediaConnect.SourceEndpointTypes.PublicSourceEndpointNetworkingConfiguration Create()
    {
        var publicSourceEndpointNetworkingConfigurationResult = CreatePublicSourceEndpointNetworkingConfiguration();
        factoryAction?.Invoke(publicSourceEndpointNetworkingConfigurationResult);

        return publicSourceEndpointNetworkingConfigurationResult;
    }

    private Humidifier.MediaConnect.SourceEndpointTypes.PublicSourceEndpointNetworkingConfiguration CreatePublicSourceEndpointNetworkingConfiguration()
    {
        var publicSourceEndpointNetworkingConfigurationResult = new Humidifier.MediaConnect.SourceEndpointTypes.PublicSourceEndpointNetworkingConfiguration();

        return publicSourceEndpointNetworkingConfigurationResult;
    }

} // End Of Class

public static class InnerSourceEndpointPublicSourceEndpointNetworkingConfigurationFactoryExtensions
{
}
