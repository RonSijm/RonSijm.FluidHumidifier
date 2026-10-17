// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantCreateDomainUnitPolicyGrantDetailFactory(Action<Humidifier.DataZone.PolicyGrantTypes.CreateDomainUnitPolicyGrantDetail> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.CreateDomainUnitPolicyGrantDetail>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.CreateDomainUnitPolicyGrantDetail Create()
    {
        var createDomainUnitPolicyGrantDetailResult = CreateCreateDomainUnitPolicyGrantDetail();
        factoryAction?.Invoke(createDomainUnitPolicyGrantDetailResult);

        return createDomainUnitPolicyGrantDetailResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.CreateDomainUnitPolicyGrantDetail CreateCreateDomainUnitPolicyGrantDetail()
    {
        var createDomainUnitPolicyGrantDetailResult = new Humidifier.DataZone.PolicyGrantTypes.CreateDomainUnitPolicyGrantDetail();

        return createDomainUnitPolicyGrantDetailResult;
    }

} // End Of Class

public static class InnerPolicyGrantCreateDomainUnitPolicyGrantDetailFactoryExtensions
{
}
