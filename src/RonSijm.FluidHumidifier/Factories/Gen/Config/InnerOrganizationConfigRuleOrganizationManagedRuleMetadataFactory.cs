// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerOrganizationConfigRuleOrganizationManagedRuleMetadataFactory(Action<Humidifier.Config.OrganizationConfigRuleTypes.OrganizationManagedRuleMetadata> factoryAction = null) : SubResourceFactory<Humidifier.Config.OrganizationConfigRuleTypes.OrganizationManagedRuleMetadata>
{

    protected override Humidifier.Config.OrganizationConfigRuleTypes.OrganizationManagedRuleMetadata Create()
    {
        var organizationManagedRuleMetadataResult = CreateOrganizationManagedRuleMetadata();
        factoryAction?.Invoke(organizationManagedRuleMetadataResult);

        return organizationManagedRuleMetadataResult;
    }

    private Humidifier.Config.OrganizationConfigRuleTypes.OrganizationManagedRuleMetadata CreateOrganizationManagedRuleMetadata()
    {
        var organizationManagedRuleMetadataResult = new Humidifier.Config.OrganizationConfigRuleTypes.OrganizationManagedRuleMetadata();

        return organizationManagedRuleMetadataResult;
    }

} // End Of Class

public static class InnerOrganizationConfigRuleOrganizationManagedRuleMetadataFactoryExtensions
{
}
