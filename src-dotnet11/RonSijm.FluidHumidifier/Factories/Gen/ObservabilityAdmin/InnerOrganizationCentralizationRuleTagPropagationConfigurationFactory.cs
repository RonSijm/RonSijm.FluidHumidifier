// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationCentralizationRuleTagPropagationConfigurationFactory(Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.TagPropagationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.TagPropagationConfiguration>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.TagPropagationConfiguration Create()
    {
        var tagPropagationConfigurationResult = CreateTagPropagationConfiguration();
        factoryAction?.Invoke(tagPropagationConfigurationResult);

        return tagPropagationConfigurationResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.TagPropagationConfiguration CreateTagPropagationConfiguration()
    {
        var tagPropagationConfigurationResult = new Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.TagPropagationConfiguration();

        return tagPropagationConfigurationResult;
    }

} // End Of Class

public static class InnerOrganizationCentralizationRuleTagPropagationConfigurationFactoryExtensions
{
}
