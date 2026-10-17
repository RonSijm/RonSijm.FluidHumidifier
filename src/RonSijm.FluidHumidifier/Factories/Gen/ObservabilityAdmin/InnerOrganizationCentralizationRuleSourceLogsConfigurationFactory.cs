// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationCentralizationRuleSourceLogsConfigurationFactory(Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceLogsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceLogsConfiguration>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceLogsConfiguration Create()
    {
        var sourceLogsConfigurationResult = CreateSourceLogsConfiguration();
        factoryAction?.Invoke(sourceLogsConfigurationResult);

        return sourceLogsConfigurationResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceLogsConfiguration CreateSourceLogsConfiguration()
    {
        var sourceLogsConfigurationResult = new Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceLogsConfiguration();

        return sourceLogsConfigurationResult;
    }

} // End Of Class

public static class InnerOrganizationCentralizationRuleSourceLogsConfigurationFactoryExtensions
{
}
