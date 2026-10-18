// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentUpdatePolicyFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.UpdatePolicy> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.UpdatePolicy>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.UpdatePolicy Create()
    {
        var updatePolicyResult = CreateUpdatePolicy();
        factoryAction?.Invoke(updatePolicyResult);

        return updatePolicyResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.UpdatePolicy CreateUpdatePolicy()
    {
        var updatePolicyResult = new Humidifier.Batch.ComputeEnvironmentTypes.UpdatePolicy();

        return updatePolicyResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentUpdatePolicyFactoryExtensions
{
}
