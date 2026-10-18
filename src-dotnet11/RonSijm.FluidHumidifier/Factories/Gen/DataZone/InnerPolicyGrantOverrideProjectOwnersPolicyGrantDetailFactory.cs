// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantOverrideProjectOwnersPolicyGrantDetailFactory(Action<Humidifier.DataZone.PolicyGrantTypes.OverrideProjectOwnersPolicyGrantDetail> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.OverrideProjectOwnersPolicyGrantDetail>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.OverrideProjectOwnersPolicyGrantDetail Create()
    {
        var overrideProjectOwnersPolicyGrantDetailResult = CreateOverrideProjectOwnersPolicyGrantDetail();
        factoryAction?.Invoke(overrideProjectOwnersPolicyGrantDetailResult);

        return overrideProjectOwnersPolicyGrantDetailResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.OverrideProjectOwnersPolicyGrantDetail CreateOverrideProjectOwnersPolicyGrantDetail()
    {
        var overrideProjectOwnersPolicyGrantDetailResult = new Humidifier.DataZone.PolicyGrantTypes.OverrideProjectOwnersPolicyGrantDetail();

        return overrideProjectOwnersPolicyGrantDetailResult;
    }

} // End Of Class

public static class InnerPolicyGrantOverrideProjectOwnersPolicyGrantDetailFactoryExtensions
{
}
