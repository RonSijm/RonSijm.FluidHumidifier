// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerTelemetryRuleMskMonitoringParametersFactory(Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.MskMonitoringParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.MskMonitoringParameters>
{

    protected override Humidifier.ObservabilityAdmin.TelemetryRuleTypes.MskMonitoringParameters Create()
    {
        var mskMonitoringParametersResult = CreateMskMonitoringParameters();
        factoryAction?.Invoke(mskMonitoringParametersResult);

        return mskMonitoringParametersResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryRuleTypes.MskMonitoringParameters CreateMskMonitoringParameters()
    {
        var mskMonitoringParametersResult = new Humidifier.ObservabilityAdmin.TelemetryRuleTypes.MskMonitoringParameters();

        return mskMonitoringParametersResult;
    }

} // End Of Class

public static class InnerTelemetryRuleMskMonitoringParametersFactoryExtensions
{
}
