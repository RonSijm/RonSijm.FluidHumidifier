// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ComputeOptimizer;

public class InnerAutomationRuleOrganizationConfigurationFactory(Action<Humidifier.ComputeOptimizer.AutomationRuleTypes.OrganizationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ComputeOptimizer.AutomationRuleTypes.OrganizationConfiguration>
{

    protected override Humidifier.ComputeOptimizer.AutomationRuleTypes.OrganizationConfiguration Create()
    {
        var organizationConfigurationResult = CreateOrganizationConfiguration();
        factoryAction?.Invoke(organizationConfigurationResult);

        return organizationConfigurationResult;
    }

    private Humidifier.ComputeOptimizer.AutomationRuleTypes.OrganizationConfiguration CreateOrganizationConfiguration()
    {
        var organizationConfigurationResult = new Humidifier.ComputeOptimizer.AutomationRuleTypes.OrganizationConfiguration();

        return organizationConfigurationResult;
    }

} // End Of Class

public static class InnerAutomationRuleOrganizationConfigurationFactoryExtensions
{
}
