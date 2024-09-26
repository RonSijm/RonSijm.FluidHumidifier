// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerNetworkAnalyzerConfigurationTraceContentFactory(Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent>
{

    protected override Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent Create()
    {
        var traceContentResult = CreateTraceContent();
        factoryAction?.Invoke(traceContentResult);

        return traceContentResult;
    }

    private Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent CreateTraceContent()
    {
        var traceContentResult = new Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent();

        return traceContentResult;
    }

} // End Of Class

public static class InnerNetworkAnalyzerConfigurationTraceContentFactoryExtensions
{
}
