// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterNetworkInterfacePublicRouterNetworkInterfaceConfigurationFactory(Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.PublicRouterNetworkInterfaceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.PublicRouterNetworkInterfaceConfiguration>
{

    protected override Humidifier.MediaConnect.RouterNetworkInterfaceTypes.PublicRouterNetworkInterfaceConfiguration Create()
    {
        var publicRouterNetworkInterfaceConfigurationResult = CreatePublicRouterNetworkInterfaceConfiguration();
        factoryAction?.Invoke(publicRouterNetworkInterfaceConfigurationResult);

        return publicRouterNetworkInterfaceConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterNetworkInterfaceTypes.PublicRouterNetworkInterfaceConfiguration CreatePublicRouterNetworkInterfaceConfiguration()
    {
        var publicRouterNetworkInterfaceConfigurationResult = new Humidifier.MediaConnect.RouterNetworkInterfaceTypes.PublicRouterNetworkInterfaceConfiguration();

        return publicRouterNetworkInterfaceConfigurationResult;
    }

} // End Of Class

public static class InnerRouterNetworkInterfacePublicRouterNetworkInterfaceConfigurationFactoryExtensions
{
}
