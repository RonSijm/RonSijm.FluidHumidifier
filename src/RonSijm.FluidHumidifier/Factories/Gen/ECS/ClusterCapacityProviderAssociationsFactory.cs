// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class ClusterCapacityProviderAssociationsFactory(string resourceName = null, Action<Humidifier.ECS.ClusterCapacityProviderAssociations> factoryAction = null) : ResourceFactory<Humidifier.ECS.ClusterCapacityProviderAssociations>(resourceName)
{

    internal List<InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> DefaultCapacityProviderStrategyFactories { get; set; } = [];

    protected override Humidifier.ECS.ClusterCapacityProviderAssociations Create()
    {
        var clusterCapacityProviderAssociationsResult = CreateClusterCapacityProviderAssociations();
        factoryAction?.Invoke(clusterCapacityProviderAssociationsResult);

        return clusterCapacityProviderAssociationsResult;
    }

    private Humidifier.ECS.ClusterCapacityProviderAssociations CreateClusterCapacityProviderAssociations()
    {
        var clusterCapacityProviderAssociationsResult = new Humidifier.ECS.ClusterCapacityProviderAssociations
        {
            GivenName = InputResourceName,
        };

        return clusterCapacityProviderAssociationsResult;
    }
    public override void CreateChildren(Humidifier.ECS.ClusterCapacityProviderAssociations result)
    {
        base.CreateChildren(result);

        result.DefaultCapacityProviderStrategy = DefaultCapacityProviderStrategyFactories.Any() ? DefaultCapacityProviderStrategyFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ClusterCapacityProviderAssociationsFactoryExtensions
{
    public static CombinedResult<ClusterCapacityProviderAssociationsFactory, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy(this ClusterCapacityProviderAssociationsFactory parentFactory, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null)
    {
        var factory = new InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory(subFactoryAction);
        parentFactory.DefaultCapacityProviderStrategyFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ClusterCapacityProviderAssociationsFactory, T1, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1>(this CombinedResult<ClusterCapacityProviderAssociationsFactory, T1> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterCapacityProviderAssociationsFactory, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1>(this CombinedResult<T1, ClusterCapacityProviderAssociationsFactory> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterCapacityProviderAssociationsFactory, T1, T2, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2>(this CombinedResult<ClusterCapacityProviderAssociationsFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterCapacityProviderAssociationsFactory, T2, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2>(this CombinedResult<T1, ClusterCapacityProviderAssociationsFactory, T2> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterCapacityProviderAssociationsFactory, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2>(this CombinedResult<T1, T2, ClusterCapacityProviderAssociationsFactory> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterCapacityProviderAssociationsFactory, T1, T2, T3, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2, T3>(this CombinedResult<ClusterCapacityProviderAssociationsFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterCapacityProviderAssociationsFactory, T2, T3, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2, T3>(this CombinedResult<T1, ClusterCapacityProviderAssociationsFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterCapacityProviderAssociationsFactory, T3, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2, T3>(this CombinedResult<T1, T2, ClusterCapacityProviderAssociationsFactory, T3> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterCapacityProviderAssociationsFactory, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterCapacityProviderAssociationsFactory> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterCapacityProviderAssociationsFactory, T1, T2, T3, T4, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2, T3, T4>(this CombinedResult<ClusterCapacityProviderAssociationsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterCapacityProviderAssociationsFactory, T2, T3, T4, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2, T3, T4>(this CombinedResult<T1, ClusterCapacityProviderAssociationsFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterCapacityProviderAssociationsFactory, T3, T4, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterCapacityProviderAssociationsFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterCapacityProviderAssociationsFactory, T4, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterCapacityProviderAssociationsFactory, T4> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterCapacityProviderAssociationsFactory, InnerClusterCapacityProviderAssociationsCapacityProviderStrategyFactory> WithDefaultCapacityProviderStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterCapacityProviderAssociationsFactory> combinedResult, Action<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultCapacityProviderStrategy(combinedResult.T5, subFactoryAction));
}
