// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class AliasFactory(string resourceName = null, Action<Humidifier.GameLift.Alias> factoryAction = null) : ResourceFactory<Humidifier.GameLift.Alias>(resourceName)
{

    internal InnerAliasRoutingStrategyFactory RoutingStrategyFactory { get; set; }

    protected override Humidifier.GameLift.Alias Create()
    {
        var aliasResult = CreateAlias();
        factoryAction?.Invoke(aliasResult);

        return aliasResult;
    }

    private Humidifier.GameLift.Alias CreateAlias()
    {
        var aliasResult = new Humidifier.GameLift.Alias
        {
            GivenName = InputResourceName,
        };

        return aliasResult;
    }
    public override void CreateChildren(Humidifier.GameLift.Alias result)
    {
        base.CreateChildren(result);

        result.RoutingStrategy ??= RoutingStrategyFactory?.Build();
    }

} // End Of Class

public static class AliasFactoryExtensions
{
    public static CombinedResult<AliasFactory, InnerAliasRoutingStrategyFactory> WithRoutingStrategy(this AliasFactory parentFactory, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null)
    {
        parentFactory.RoutingStrategyFactory = new InnerAliasRoutingStrategyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RoutingStrategyFactory);
    }

    public static CombinedResult<AliasFactory, T1, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1>(this CombinedResult<AliasFactory, T1> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1>(this CombinedResult<T1, AliasFactory> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AliasFactory, T1, T2, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2>(this CombinedResult<AliasFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, T2, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2>(this CombinedResult<T1, AliasFactory, T2> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AliasFactory, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2>(this CombinedResult<T1, T2, AliasFactory> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AliasFactory, T1, T2, T3, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2, T3>(this CombinedResult<AliasFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, T2, T3, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2, T3>(this CombinedResult<T1, AliasFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AliasFactory, T3, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2, T3>(this CombinedResult<T1, T2, AliasFactory, T3> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AliasFactory, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2, T3>(this CombinedResult<T1, T2, T3, AliasFactory> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AliasFactory, T1, T2, T3, T4, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2, T3, T4>(this CombinedResult<AliasFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, T2, T3, T4, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2, T3, T4>(this CombinedResult<T1, AliasFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AliasFactory, T3, T4, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, AliasFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AliasFactory, T4, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AliasFactory, T4> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AliasFactory, InnerAliasRoutingStrategyFactory> WithRoutingStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AliasFactory> combinedResult, Action<Humidifier.GameLift.AliasTypes.RoutingStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingStrategy(combinedResult.T5, subFactoryAction));
}
