// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderInfrastructureOptimizationFactory(Action<Humidifier.ECS.CapacityProviderTypes.InfrastructureOptimization> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.InfrastructureOptimization>
{

    protected override Humidifier.ECS.CapacityProviderTypes.InfrastructureOptimization Create()
    {
        var infrastructureOptimizationResult = CreateInfrastructureOptimization();
        factoryAction?.Invoke(infrastructureOptimizationResult);

        return infrastructureOptimizationResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.InfrastructureOptimization CreateInfrastructureOptimization()
    {
        var infrastructureOptimizationResult = new Humidifier.ECS.CapacityProviderTypes.InfrastructureOptimization();

        return infrastructureOptimizationResult;
    }

} // End Of Class

public static class InnerCapacityProviderInfrastructureOptimizationFactoryExtensions
{
}
