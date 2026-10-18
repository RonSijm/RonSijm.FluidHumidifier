// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationCentralizationRuleLogsBackupConfigurationFactory(Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsBackupConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsBackupConfiguration>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsBackupConfiguration Create()
    {
        var logsBackupConfigurationResult = CreateLogsBackupConfiguration();
        factoryAction?.Invoke(logsBackupConfigurationResult);

        return logsBackupConfigurationResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsBackupConfiguration CreateLogsBackupConfiguration()
    {
        var logsBackupConfigurationResult = new Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsBackupConfiguration();

        return logsBackupConfigurationResult;
    }

} // End Of Class

public static class InnerOrganizationCentralizationRuleLogsBackupConfigurationFactoryExtensions
{
}
