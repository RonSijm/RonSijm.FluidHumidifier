// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceCapacityProviderStrategyItemFactory(Action<Humidifier.ECS.ServiceTypes.CapacityProviderStrategyItem> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.CapacityProviderStrategyItem>
{

    protected override Humidifier.ECS.ServiceTypes.CapacityProviderStrategyItem Create()
    {
        var capacityProviderStrategyItemResult = CreateCapacityProviderStrategyItem();
        factoryAction?.Invoke(capacityProviderStrategyItemResult);

        return capacityProviderStrategyItemResult;
    }

    private Humidifier.ECS.ServiceTypes.CapacityProviderStrategyItem CreateCapacityProviderStrategyItem()
    {
        var capacityProviderStrategyItemResult = new Humidifier.ECS.ServiceTypes.CapacityProviderStrategyItem();

        return capacityProviderStrategyItemResult;
    }

} // End Of Class

public static class InnerServiceCapacityProviderStrategyItemFactoryExtensions
{
}
