// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentInfrastructureOptimizationFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.InfrastructureOptimization> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.InfrastructureOptimization>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.InfrastructureOptimization Create()
    {
        var infrastructureOptimizationResult = CreateInfrastructureOptimization();
        factoryAction?.Invoke(infrastructureOptimizationResult);

        return infrastructureOptimizationResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.InfrastructureOptimization CreateInfrastructureOptimization()
    {
        var infrastructureOptimizationResult = new Humidifier.Batch.ComputeEnvironmentTypes.InfrastructureOptimization();

        return infrastructureOptimizationResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentInfrastructureOptimizationFactoryExtensions
{
}
