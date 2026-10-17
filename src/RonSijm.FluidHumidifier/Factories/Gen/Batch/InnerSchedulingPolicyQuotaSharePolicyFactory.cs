// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerSchedulingPolicyQuotaSharePolicyFactory(Action<Humidifier.Batch.SchedulingPolicyTypes.QuotaSharePolicy> factoryAction = null) : SubResourceFactory<Humidifier.Batch.SchedulingPolicyTypes.QuotaSharePolicy>
{

    protected override Humidifier.Batch.SchedulingPolicyTypes.QuotaSharePolicy Create()
    {
        var quotaSharePolicyResult = CreateQuotaSharePolicy();
        factoryAction?.Invoke(quotaSharePolicyResult);

        return quotaSharePolicyResult;
    }

    private Humidifier.Batch.SchedulingPolicyTypes.QuotaSharePolicy CreateQuotaSharePolicy()
    {
        var quotaSharePolicyResult = new Humidifier.Batch.SchedulingPolicyTypes.QuotaSharePolicy();

        return quotaSharePolicyResult;
    }

} // End Of Class

public static class InnerSchedulingPolicyQuotaSharePolicyFactoryExtensions
{
}
