// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentComputeScalingPolicyFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.ComputeScalingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.ComputeScalingPolicy>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.ComputeScalingPolicy Create()
    {
        var computeScalingPolicyResult = CreateComputeScalingPolicy();
        factoryAction?.Invoke(computeScalingPolicyResult);

        return computeScalingPolicyResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.ComputeScalingPolicy CreateComputeScalingPolicy()
    {
        var computeScalingPolicyResult = new Humidifier.Batch.ComputeEnvironmentTypes.ComputeScalingPolicy();

        return computeScalingPolicyResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentComputeScalingPolicyFactoryExtensions
{
}
