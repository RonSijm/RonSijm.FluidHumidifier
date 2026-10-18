// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerObservabilityConfigurationTraceConfigurationFactory(Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration>
{

    protected override Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration Create()
    {
        var traceConfigurationResult = CreateTraceConfiguration();
        factoryAction?.Invoke(traceConfigurationResult);

        return traceConfigurationResult;
    }

    private Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration CreateTraceConfiguration()
    {
        var traceConfigurationResult = new Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration();

        return traceConfigurationResult;
    }

} // End Of Class

public static class InnerObservabilityConfigurationTraceConfigurationFactoryExtensions
{
}
