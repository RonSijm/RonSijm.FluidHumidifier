// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationTelemetryRuleMskMonitoringParametersFactory(Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.MskMonitoringParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.MskMonitoringParameters>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.MskMonitoringParameters Create()
    {
        var mskMonitoringParametersResult = CreateMskMonitoringParameters();
        factoryAction?.Invoke(mskMonitoringParametersResult);

        return mskMonitoringParametersResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.MskMonitoringParameters CreateMskMonitoringParameters()
    {
        var mskMonitoringParametersResult = new Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.MskMonitoringParameters();

        return mskMonitoringParametersResult;
    }

} // End Of Class

public static class InnerOrganizationTelemetryRuleMskMonitoringParametersFactoryExtensions
{
}
