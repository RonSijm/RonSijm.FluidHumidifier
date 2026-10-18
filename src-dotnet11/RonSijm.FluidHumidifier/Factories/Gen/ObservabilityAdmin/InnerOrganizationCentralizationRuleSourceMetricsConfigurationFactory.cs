// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationCentralizationRuleSourceMetricsConfigurationFactory(Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceMetricsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceMetricsConfiguration>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceMetricsConfiguration Create()
    {
        var sourceMetricsConfigurationResult = CreateSourceMetricsConfiguration();
        factoryAction?.Invoke(sourceMetricsConfigurationResult);

        return sourceMetricsConfigurationResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceMetricsConfiguration CreateSourceMetricsConfiguration()
    {
        var sourceMetricsConfigurationResult = new Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceMetricsConfiguration();

        return sourceMetricsConfigurationResult;
    }

} // End Of Class

public static class InnerOrganizationCentralizationRuleSourceMetricsConfigurationFactoryExtensions
{
}
