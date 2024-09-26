// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHub;

public class InnerResiliencyPolicyFailurePolicyFactory(Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.FailurePolicy> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHub.ResiliencyPolicyTypes.FailurePolicy>
{

    protected override Humidifier.ResilienceHub.ResiliencyPolicyTypes.FailurePolicy Create()
    {
        var failurePolicyResult = CreateFailurePolicy();
        factoryAction?.Invoke(failurePolicyResult);

        return failurePolicyResult;
    }

    private Humidifier.ResilienceHub.ResiliencyPolicyTypes.FailurePolicy CreateFailurePolicy()
    {
        var failurePolicyResult = new Humidifier.ResilienceHub.ResiliencyPolicyTypes.FailurePolicy();

        return failurePolicyResult;
    }

} // End Of Class

public static class InnerResiliencyPolicyFailurePolicyFactoryExtensions
{
}
