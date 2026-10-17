// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskSetCapacityProviderStrategyItemFactory(Action<Humidifier.ECS.TaskSetTypes.CapacityProviderStrategyItem> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskSetTypes.CapacityProviderStrategyItem>
{

    protected override Humidifier.ECS.TaskSetTypes.CapacityProviderStrategyItem Create()
    {
        var capacityProviderStrategyItemResult = CreateCapacityProviderStrategyItem();
        factoryAction?.Invoke(capacityProviderStrategyItemResult);

        return capacityProviderStrategyItemResult;
    }

    private Humidifier.ECS.TaskSetTypes.CapacityProviderStrategyItem CreateCapacityProviderStrategyItem()
    {
        var capacityProviderStrategyItemResult = new Humidifier.ECS.TaskSetTypes.CapacityProviderStrategyItem();

        return capacityProviderStrategyItemResult;
    }

} // End Of Class

public static class InnerTaskSetCapacityProviderStrategyItemFactoryExtensions
{
}
