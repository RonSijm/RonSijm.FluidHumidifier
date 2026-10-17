// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantOverrideDomainUnitOwnersPolicyGrantDetailFactory(Action<Humidifier.DataZone.PolicyGrantTypes.OverrideDomainUnitOwnersPolicyGrantDetail> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.OverrideDomainUnitOwnersPolicyGrantDetail>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.OverrideDomainUnitOwnersPolicyGrantDetail Create()
    {
        var overrideDomainUnitOwnersPolicyGrantDetailResult = CreateOverrideDomainUnitOwnersPolicyGrantDetail();
        factoryAction?.Invoke(overrideDomainUnitOwnersPolicyGrantDetailResult);

        return overrideDomainUnitOwnersPolicyGrantDetailResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.OverrideDomainUnitOwnersPolicyGrantDetail CreateOverrideDomainUnitOwnersPolicyGrantDetail()
    {
        var overrideDomainUnitOwnersPolicyGrantDetailResult = new Humidifier.DataZone.PolicyGrantTypes.OverrideDomainUnitOwnersPolicyGrantDetail();

        return overrideDomainUnitOwnersPolicyGrantDetailResult;
    }

} // End Of Class

public static class InnerPolicyGrantOverrideDomainUnitOwnersPolicyGrantDetailFactoryExtensions
{
}
