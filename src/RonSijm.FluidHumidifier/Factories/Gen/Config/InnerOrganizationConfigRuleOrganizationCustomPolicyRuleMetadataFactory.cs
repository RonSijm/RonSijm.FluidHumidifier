// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerOrganizationConfigRuleOrganizationCustomPolicyRuleMetadataFactory(Action<Humidifier.Config.OrganizationConfigRuleTypes.OrganizationCustomPolicyRuleMetadata> factoryAction = null) : SubResourceFactory<Humidifier.Config.OrganizationConfigRuleTypes.OrganizationCustomPolicyRuleMetadata>
{

    protected override Humidifier.Config.OrganizationConfigRuleTypes.OrganizationCustomPolicyRuleMetadata Create()
    {
        var organizationCustomPolicyRuleMetadataResult = CreateOrganizationCustomPolicyRuleMetadata();
        factoryAction?.Invoke(organizationCustomPolicyRuleMetadataResult);

        return organizationCustomPolicyRuleMetadataResult;
    }

    private Humidifier.Config.OrganizationConfigRuleTypes.OrganizationCustomPolicyRuleMetadata CreateOrganizationCustomPolicyRuleMetadata()
    {
        var organizationCustomPolicyRuleMetadataResult = new Humidifier.Config.OrganizationConfigRuleTypes.OrganizationCustomPolicyRuleMetadata();

        return organizationCustomPolicyRuleMetadataResult;
    }

} // End Of Class

public static class InnerOrganizationConfigRuleOrganizationCustomPolicyRuleMetadataFactoryExtensions
{
}
