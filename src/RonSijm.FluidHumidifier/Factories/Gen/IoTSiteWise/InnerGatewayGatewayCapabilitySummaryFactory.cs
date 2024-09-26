// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerGatewayGatewayCapabilitySummaryFactory(Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary>
{

    protected override Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary Create()
    {
        var gatewayCapabilitySummaryResult = CreateGatewayCapabilitySummary();
        factoryAction?.Invoke(gatewayCapabilitySummaryResult);

        return gatewayCapabilitySummaryResult;
    }

    private Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary CreateGatewayCapabilitySummary()
    {
        var gatewayCapabilitySummaryResult = new Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary();

        return gatewayCapabilitySummaryResult;
    }

} // End Of Class

public static class InnerGatewayGatewayCapabilitySummaryFactoryExtensions
{
}
