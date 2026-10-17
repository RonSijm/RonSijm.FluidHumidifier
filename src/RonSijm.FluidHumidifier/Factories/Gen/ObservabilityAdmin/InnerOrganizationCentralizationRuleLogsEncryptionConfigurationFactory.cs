// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationCentralizationRuleLogsEncryptionConfigurationFactory(Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsEncryptionConfiguration>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsEncryptionConfiguration Create()
    {
        var logsEncryptionConfigurationResult = CreateLogsEncryptionConfiguration();
        factoryAction?.Invoke(logsEncryptionConfigurationResult);

        return logsEncryptionConfigurationResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsEncryptionConfiguration CreateLogsEncryptionConfiguration()
    {
        var logsEncryptionConfigurationResult = new Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsEncryptionConfiguration();

        return logsEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerOrganizationCentralizationRuleLogsEncryptionConfigurationFactoryExtensions
{
}
