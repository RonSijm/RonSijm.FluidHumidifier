// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class GlobalClusterFactory(string resourceName = null, Action<Humidifier.RDS.GlobalCluster> factoryAction = null) : ResourceFactory<Humidifier.RDS.GlobalCluster>(resourceName)
{

    internal InnerGlobalClusterGlobalEndpointFactory GlobalEndpointFactory { get; set; }

    protected override Humidifier.RDS.GlobalCluster Create()
    {
        var globalClusterResult = CreateGlobalCluster();
        factoryAction?.Invoke(globalClusterResult);

        return globalClusterResult;
    }

    private Humidifier.RDS.GlobalCluster CreateGlobalCluster()
    {
        var globalClusterResult = new Humidifier.RDS.GlobalCluster
        {
            GivenName = InputResourceName,
        };

        return globalClusterResult;
    }
    public override void CreateChildren(Humidifier.RDS.GlobalCluster result)
    {
        base.CreateChildren(result);

        result.GlobalEndpoint ??= GlobalEndpointFactory?.Build();
    }

} // End Of Class

public static class GlobalClusterFactoryExtensions
{
    public static CombinedResult<GlobalClusterFactory, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint(this GlobalClusterFactory parentFactory, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null)
    {
        parentFactory.GlobalEndpointFactory = new InnerGlobalClusterGlobalEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GlobalEndpointFactory);
    }

    public static CombinedResult<GlobalClusterFactory, T1, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1>(this CombinedResult<GlobalClusterFactory, T1> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalClusterFactory, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1>(this CombinedResult<T1, GlobalClusterFactory> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GlobalClusterFactory, T1, T2, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2>(this CombinedResult<GlobalClusterFactory, T1, T2> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalClusterFactory, T2, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2>(this CombinedResult<T1, GlobalClusterFactory, T2> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GlobalClusterFactory, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2>(this CombinedResult<T1, T2, GlobalClusterFactory> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GlobalClusterFactory, T1, T2, T3, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2, T3>(this CombinedResult<GlobalClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalClusterFactory, T2, T3, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2, T3>(this CombinedResult<T1, GlobalClusterFactory, T2, T3> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GlobalClusterFactory, T3, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, GlobalClusterFactory, T3> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GlobalClusterFactory, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, GlobalClusterFactory> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GlobalClusterFactory, T1, T2, T3, T4, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2, T3, T4>(this CombinedResult<GlobalClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalClusterFactory, T2, T3, T4, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, GlobalClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GlobalClusterFactory, T3, T4, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, GlobalClusterFactory, T3, T4> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GlobalClusterFactory, T4, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GlobalClusterFactory, T4> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GlobalClusterFactory, InnerGlobalClusterGlobalEndpointFactory> WithGlobalEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GlobalClusterFactory> combinedResult, Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalEndpoint(combinedResult.T5, subFactoryAction));
}
