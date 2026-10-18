// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantCreateFormTypePolicyGrantDetailFactory(Action<Humidifier.DataZone.PolicyGrantTypes.CreateFormTypePolicyGrantDetail> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.CreateFormTypePolicyGrantDetail>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.CreateFormTypePolicyGrantDetail Create()
    {
        var createFormTypePolicyGrantDetailResult = CreateCreateFormTypePolicyGrantDetail();
        factoryAction?.Invoke(createFormTypePolicyGrantDetailResult);

        return createFormTypePolicyGrantDetailResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.CreateFormTypePolicyGrantDetail CreateCreateFormTypePolicyGrantDetail()
    {
        var createFormTypePolicyGrantDetailResult = new Humidifier.DataZone.PolicyGrantTypes.CreateFormTypePolicyGrantDetail();

        return createFormTypePolicyGrantDetailResult;
    }

} // End Of Class

public static class InnerPolicyGrantCreateFormTypePolicyGrantDetailFactoryExtensions
{
}
