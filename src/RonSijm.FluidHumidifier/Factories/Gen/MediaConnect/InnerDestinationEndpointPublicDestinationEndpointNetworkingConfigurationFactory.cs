// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerDestinationEndpointPublicDestinationEndpointNetworkingConfigurationFactory(Action<Humidifier.MediaConnect.DestinationEndpointTypes.PublicDestinationEndpointNetworkingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.DestinationEndpointTypes.PublicDestinationEndpointNetworkingConfiguration>
{

    protected override Humidifier.MediaConnect.DestinationEndpointTypes.PublicDestinationEndpointNetworkingConfiguration Create()
    {
        var publicDestinationEndpointNetworkingConfigurationResult = CreatePublicDestinationEndpointNetworkingConfiguration();
        factoryAction?.Invoke(publicDestinationEndpointNetworkingConfigurationResult);

        return publicDestinationEndpointNetworkingConfigurationResult;
    }

    private Humidifier.MediaConnect.DestinationEndpointTypes.PublicDestinationEndpointNetworkingConfiguration CreatePublicDestinationEndpointNetworkingConfiguration()
    {
        var publicDestinationEndpointNetworkingConfigurationResult = new Humidifier.MediaConnect.DestinationEndpointTypes.PublicDestinationEndpointNetworkingConfiguration();

        return publicDestinationEndpointNetworkingConfigurationResult;
    }

} // End Of Class

public static class InnerDestinationEndpointPublicDestinationEndpointNetworkingConfigurationFactoryExtensions
{
}
