// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantCreateGlossaryPolicyGrantDetailFactory(Action<Humidifier.DataZone.PolicyGrantTypes.CreateGlossaryPolicyGrantDetail> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.CreateGlossaryPolicyGrantDetail>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.CreateGlossaryPolicyGrantDetail Create()
    {
        var createGlossaryPolicyGrantDetailResult = CreateCreateGlossaryPolicyGrantDetail();
        factoryAction?.Invoke(createGlossaryPolicyGrantDetailResult);

        return createGlossaryPolicyGrantDetailResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.CreateGlossaryPolicyGrantDetail CreateCreateGlossaryPolicyGrantDetail()
    {
        var createGlossaryPolicyGrantDetailResult = new Humidifier.DataZone.PolicyGrantTypes.CreateGlossaryPolicyGrantDetail();

        return createGlossaryPolicyGrantDetailResult;
    }

} // End Of Class

public static class InnerPolicyGrantCreateGlossaryPolicyGrantDetailFactoryExtensions
{
}
