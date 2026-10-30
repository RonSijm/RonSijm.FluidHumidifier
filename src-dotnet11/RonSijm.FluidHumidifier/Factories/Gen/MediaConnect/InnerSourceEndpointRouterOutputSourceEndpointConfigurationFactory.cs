// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerSourceEndpointRouterOutputSourceEndpointConfigurationFactory(Action<Humidifier.MediaConnect.SourceEndpointTypes.RouterOutputSourceEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.SourceEndpointTypes.RouterOutputSourceEndpointConfiguration>
{

    protected override Humidifier.MediaConnect.SourceEndpointTypes.RouterOutputSourceEndpointConfiguration Create()
    {
        var routerOutputSourceEndpointConfigurationResult = CreateRouterOutputSourceEndpointConfiguration();
        factoryAction?.Invoke(routerOutputSourceEndpointConfigurationResult);

        return routerOutputSourceEndpointConfigurationResult;
    }

    private Humidifier.MediaConnect.SourceEndpointTypes.RouterOutputSourceEndpointConfiguration CreateRouterOutputSourceEndpointConfiguration()
    {
        var routerOutputSourceEndpointConfigurationResult = new Humidifier.MediaConnect.SourceEndpointTypes.RouterOutputSourceEndpointConfiguration();

        return routerOutputSourceEndpointConfigurationResult;
    }

} // End Of Class

public static class InnerSourceEndpointRouterOutputSourceEndpointConfigurationFactoryExtensions
{
}
