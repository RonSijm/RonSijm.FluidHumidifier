// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterNetworkInterfaceVpcRouterNetworkInterfaceConfigurationFactory(Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.VpcRouterNetworkInterfaceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.VpcRouterNetworkInterfaceConfiguration>
{

    protected override Humidifier.MediaConnect.RouterNetworkInterfaceTypes.VpcRouterNetworkInterfaceConfiguration Create()
    {
        var vpcRouterNetworkInterfaceConfigurationResult = CreateVpcRouterNetworkInterfaceConfiguration();
        factoryAction?.Invoke(vpcRouterNetworkInterfaceConfigurationResult);

        return vpcRouterNetworkInterfaceConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterNetworkInterfaceTypes.VpcRouterNetworkInterfaceConfiguration CreateVpcRouterNetworkInterfaceConfiguration()
    {
        var vpcRouterNetworkInterfaceConfigurationResult = new Humidifier.MediaConnect.RouterNetworkInterfaceTypes.VpcRouterNetworkInterfaceConfiguration();

        return vpcRouterNetworkInterfaceConfigurationResult;
    }

} // End Of Class

public static class InnerRouterNetworkInterfaceVpcRouterNetworkInterfaceConfigurationFactoryExtensions
{
}
