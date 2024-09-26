// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerAliasRoutingStrategyFactory(Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.AliasTypes.RoutingStrategy>
{

    protected override Humidifier.GameLift.AliasTypes.RoutingStrategy Create()
    {
        var routingStrategyResult = CreateRoutingStrategy();
        factoryAction?.Invoke(routingStrategyResult);

        return routingStrategyResult;
    }

    private Humidifier.GameLift.AliasTypes.RoutingStrategy CreateRoutingStrategy()
    {
        var routingStrategyResult = new Humidifier.GameLift.AliasTypes.RoutingStrategy();

        return routingStrategyResult;
    }

} // End Of Class

public static class InnerAliasRoutingStrategyFactoryExtensions
{
}
