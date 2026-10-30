// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerSourceEndpointVpcSourceEndpointNetworkingConfigurationFactory(Action<Humidifier.MediaConnect.SourceEndpointTypes.VpcSourceEndpointNetworkingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.SourceEndpointTypes.VpcSourceEndpointNetworkingConfiguration>
{

    protected override Humidifier.MediaConnect.SourceEndpointTypes.VpcSourceEndpointNetworkingConfiguration Create()
    {
        var vpcSourceEndpointNetworkingConfigurationResult = CreateVpcSourceEndpointNetworkingConfiguration();
        factoryAction?.Invoke(vpcSourceEndpointNetworkingConfigurationResult);

        return vpcSourceEndpointNetworkingConfigurationResult;
    }

    private Humidifier.MediaConnect.SourceEndpointTypes.VpcSourceEndpointNetworkingConfiguration CreateVpcSourceEndpointNetworkingConfiguration()
    {
        var vpcSourceEndpointNetworkingConfigurationResult = new Humidifier.MediaConnect.SourceEndpointTypes.VpcSourceEndpointNetworkingConfiguration();

        return vpcSourceEndpointNetworkingConfigurationResult;
    }

} // End Of Class

public static class InnerSourceEndpointVpcSourceEndpointNetworkingConfigurationFactoryExtensions
{
}
