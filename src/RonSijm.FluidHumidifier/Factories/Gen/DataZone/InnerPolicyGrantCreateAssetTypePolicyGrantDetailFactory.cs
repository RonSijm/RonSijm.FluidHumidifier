// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantCreateAssetTypePolicyGrantDetailFactory(Action<Humidifier.DataZone.PolicyGrantTypes.CreateAssetTypePolicyGrantDetail> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.CreateAssetTypePolicyGrantDetail>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.CreateAssetTypePolicyGrantDetail Create()
    {
        var createAssetTypePolicyGrantDetailResult = CreateCreateAssetTypePolicyGrantDetail();
        factoryAction?.Invoke(createAssetTypePolicyGrantDetailResult);

        return createAssetTypePolicyGrantDetailResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.CreateAssetTypePolicyGrantDetail CreateCreateAssetTypePolicyGrantDetail()
    {
        var createAssetTypePolicyGrantDetailResult = new Humidifier.DataZone.PolicyGrantTypes.CreateAssetTypePolicyGrantDetail();

        return createAssetTypePolicyGrantDetailResult;
    }

} // End Of Class

public static class InnerPolicyGrantCreateAssetTypePolicyGrantDetailFactoryExtensions
{
}
