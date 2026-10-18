// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerSchedulingPolicyFairsharePolicyFactory(Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> factoryAction = null) : SubResourceFactory<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy>
{

    protected override Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy Create()
    {
        var fairsharePolicyResult = CreateFairsharePolicy();
        factoryAction?.Invoke(fairsharePolicyResult);

        return fairsharePolicyResult;
    }

    private Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy CreateFairsharePolicy()
    {
        var fairsharePolicyResult = new Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy();

        return fairsharePolicyResult;
    }

} // End Of Class

public static class InnerSchedulingPolicyFairsharePolicyFactoryExtensions
{
}
