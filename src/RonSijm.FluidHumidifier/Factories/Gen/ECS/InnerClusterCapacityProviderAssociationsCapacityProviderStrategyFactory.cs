// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory(Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy>
{

    protected override Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy Create()
    {
        var capacityProviderStrategyResult = CreateCapacityProviderStrategy();
        factoryAction?.Invoke(capacityProviderStrategyResult);

        return capacityProviderStrategyResult;
    }

    private Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy CreateCapacityProviderStrategy()
    {
        var capacityProviderStrategyResult = new Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy();

        return capacityProviderStrategyResult;
    }

} // End Of Class

public static class InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactoryExtensions
{
}
