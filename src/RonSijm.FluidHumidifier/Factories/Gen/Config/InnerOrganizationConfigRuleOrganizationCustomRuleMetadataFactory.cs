// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerOrganizationConfigRuleOrganizationCustomRuleMetadataFactory(Action<Humidifier.Config.OrganizationConfigRuleTypes.OrganizationCustomRuleMetadata> factoryAction = null) : SubResourceFactory<Humidifier.Config.OrganizationConfigRuleTypes.OrganizationCustomRuleMetadata>
{

    protected override Humidifier.Config.OrganizationConfigRuleTypes.OrganizationCustomRuleMetadata Create()
    {
        var organizationCustomRuleMetadataResult = CreateOrganizationCustomRuleMetadata();
        factoryAction?.Invoke(organizationCustomRuleMetadataResult);

        return organizationCustomRuleMetadataResult;
    }

    private Humidifier.Config.OrganizationConfigRuleTypes.OrganizationCustomRuleMetadata CreateOrganizationCustomRuleMetadata()
    {
        var organizationCustomRuleMetadataResult = new Humidifier.Config.OrganizationConfigRuleTypes.OrganizationCustomRuleMetadata();

        return organizationCustomRuleMetadataResult;
    }

} // End Of Class

public static class InnerOrganizationConfigRuleOrganizationCustomRuleMetadataFactoryExtensions
{
}
