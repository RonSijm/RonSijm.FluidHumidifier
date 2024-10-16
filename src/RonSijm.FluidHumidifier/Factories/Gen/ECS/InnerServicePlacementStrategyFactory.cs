// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServicePlacementStrategyFactory(Action<Humidifier.ECS.ServiceTypes.PlacementStrategy> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.PlacementStrategy>
{

    protected override Humidifier.ECS.ServiceTypes.PlacementStrategy Create()
    {
        var placementStrategyResult = CreatePlacementStrategy();
        factoryAction?.Invoke(placementStrategyResult);

        return placementStrategyResult;
    }

    private Humidifier.ECS.ServiceTypes.PlacementStrategy CreatePlacementStrategy()
    {
        var placementStrategyResult = new Humidifier.ECS.ServiceTypes.PlacementStrategy();

        return placementStrategyResult;
    }

} // End Of Class

public static class InnerServicePlacementStrategyFactoryExtensions
{
}
