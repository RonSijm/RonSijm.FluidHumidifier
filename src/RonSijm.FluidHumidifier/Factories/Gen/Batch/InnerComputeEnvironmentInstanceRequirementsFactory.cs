// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentInstanceRequirementsFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.InstanceRequirements> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.InstanceRequirements>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.InstanceRequirements Create()
    {
        var instanceRequirementsResult = CreateInstanceRequirements();
        factoryAction?.Invoke(instanceRequirementsResult);

        return instanceRequirementsResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.InstanceRequirements CreateInstanceRequirements()
    {
        var instanceRequirementsResult = new Humidifier.Batch.ComputeEnvironmentTypes.InstanceRequirements();

        return instanceRequirementsResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentInstanceRequirementsFactoryExtensions
{
}
