// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationCentralizationRuleLogGroupNameConfigurationFactory(Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogGroupNameConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogGroupNameConfiguration>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogGroupNameConfiguration Create()
    {
        var logGroupNameConfigurationResult = CreateLogGroupNameConfiguration();
        factoryAction?.Invoke(logGroupNameConfigurationResult);

        return logGroupNameConfigurationResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogGroupNameConfiguration CreateLogGroupNameConfiguration()
    {
        var logGroupNameConfigurationResult = new Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogGroupNameConfiguration();

        return logGroupNameConfigurationResult;
    }

} // End Of Class

public static class InnerOrganizationCentralizationRuleLogGroupNameConfigurationFactoryExtensions
{
}
