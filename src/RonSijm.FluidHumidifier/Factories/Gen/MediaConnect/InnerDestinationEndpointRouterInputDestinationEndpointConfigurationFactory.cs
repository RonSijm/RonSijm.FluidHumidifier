// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerDestinationEndpointRouterInputDestinationEndpointConfigurationFactory(Action<Humidifier.MediaConnect.DestinationEndpointTypes.RouterInputDestinationEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.DestinationEndpointTypes.RouterInputDestinationEndpointConfiguration>
{

    protected override Humidifier.MediaConnect.DestinationEndpointTypes.RouterInputDestinationEndpointConfiguration Create()
    {
        var routerInputDestinationEndpointConfigurationResult = CreateRouterInputDestinationEndpointConfiguration();
        factoryAction?.Invoke(routerInputDestinationEndpointConfigurationResult);

        return routerInputDestinationEndpointConfigurationResult;
    }

    private Humidifier.MediaConnect.DestinationEndpointTypes.RouterInputDestinationEndpointConfiguration CreateRouterInputDestinationEndpointConfiguration()
    {
        var routerInputDestinationEndpointConfigurationResult = new Humidifier.MediaConnect.DestinationEndpointTypes.RouterInputDestinationEndpointConfiguration();

        return routerInputDestinationEndpointConfigurationResult;
    }

} // End Of Class

public static class InnerDestinationEndpointRouterInputDestinationEndpointConfigurationFactoryExtensions
{
}
