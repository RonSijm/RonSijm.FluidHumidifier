// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory(Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration Create()
    {
        var metricsBackupConfigurationResult = CreateMetricsBackupConfiguration();
        factoryAction?.Invoke(metricsBackupConfigurationResult);

        return metricsBackupConfigurationResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration CreateMetricsBackupConfiguration()
    {
        var metricsBackupConfigurationResult = new Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration();

        return metricsBackupConfigurationResult;
    }

} // End Of Class

public static class InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactoryExtensions
{
}
