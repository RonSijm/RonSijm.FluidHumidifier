// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerClusterCapacityProviderStrategyItemFactory(Action<Humidifier.ECS.ClusterTypes.CapacityProviderStrategyItem> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ClusterTypes.CapacityProviderStrategyItem>
{

    protected override Humidifier.ECS.ClusterTypes.CapacityProviderStrategyItem Create()
    {
        var capacityProviderStrategyItemResult = CreateCapacityProviderStrategyItem();
        factoryAction?.Invoke(capacityProviderStrategyItemResult);

        return capacityProviderStrategyItemResult;
    }

    private Humidifier.ECS.ClusterTypes.CapacityProviderStrategyItem CreateCapacityProviderStrategyItem()
    {
        var capacityProviderStrategyItemResult = new Humidifier.ECS.ClusterTypes.CapacityProviderStrategyItem();

        return capacityProviderStrategyItemResult;
    }

} // End Of Class

public static class InnerClusterCapacityProviderStrategyItemFactoryExtensions
{
}
