// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerDestinationEndpointVpcDestinationEndpointNetworkingConfigurationFactory(Action<Humidifier.MediaConnect.DestinationEndpointTypes.VpcDestinationEndpointNetworkingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.DestinationEndpointTypes.VpcDestinationEndpointNetworkingConfiguration>
{

    protected override Humidifier.MediaConnect.DestinationEndpointTypes.VpcDestinationEndpointNetworkingConfiguration Create()
    {
        var vpcDestinationEndpointNetworkingConfigurationResult = CreateVpcDestinationEndpointNetworkingConfiguration();
        factoryAction?.Invoke(vpcDestinationEndpointNetworkingConfigurationResult);

        return vpcDestinationEndpointNetworkingConfigurationResult;
    }

    private Humidifier.MediaConnect.DestinationEndpointTypes.VpcDestinationEndpointNetworkingConfiguration CreateVpcDestinationEndpointNetworkingConfiguration()
    {
        var vpcDestinationEndpointNetworkingConfigurationResult = new Humidifier.MediaConnect.DestinationEndpointTypes.VpcDestinationEndpointNetworkingConfiguration();

        return vpcDestinationEndpointNetworkingConfigurationResult;
    }

} // End Of Class

public static class InnerDestinationEndpointVpcDestinationEndpointNetworkingConfigurationFactoryExtensions
{
}
