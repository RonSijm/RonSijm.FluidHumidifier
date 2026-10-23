// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceGatewayConnectorFiltersFactory(Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters>
{

    protected override Humidifier.ECS.ServiceTypes.GatewayConnectorFilters Create()
    {
        var gatewayConnectorFiltersResult = CreateGatewayConnectorFilters();
        factoryAction?.Invoke(gatewayConnectorFiltersResult);

        return gatewayConnectorFiltersResult;
    }

    private Humidifier.ECS.ServiceTypes.GatewayConnectorFilters CreateGatewayConnectorFilters()
    {
        var gatewayConnectorFiltersResult = new Humidifier.ECS.ServiceTypes.GatewayConnectorFilters();

        return gatewayConnectorFiltersResult;
    }

} // End Of Class

public static class InnerServiceGatewayConnectorFiltersFactoryExtensions
{
}
