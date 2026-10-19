// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerTenantReputationPolicyFactory(Action<Humidifier.SES.TenantTypes.ReputationPolicy> factoryAction = null) : SubResourceFactory<Humidifier.SES.TenantTypes.ReputationPolicy>
{

    protected override Humidifier.SES.TenantTypes.ReputationPolicy Create()
    {
        var reputationPolicyResult = CreateReputationPolicy();
        factoryAction?.Invoke(reputationPolicyResult);

        return reputationPolicyResult;
    }

    private Humidifier.SES.TenantTypes.ReputationPolicy CreateReputationPolicy()
    {
        var reputationPolicyResult = new Humidifier.SES.TenantTypes.ReputationPolicy();

        return reputationPolicyResult;
    }

} // End Of Class

public static class InnerTenantReputationPolicyFactoryExtensions
{
}
