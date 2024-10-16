// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class SignalCatalogFactory(string resourceName = null, Action<Humidifier.IoTFleetWise.SignalCatalog> factoryAction = null) : ResourceFactory<Humidifier.IoTFleetWise.SignalCatalog>(resourceName)
{

    internal List<InnerSignalCatalogNodeFactory> NodesFactories { get; set; } = [];

    internal InnerSignalCatalogNodeCountsFactory NodeCountsFactory { get; set; }

    protected override Humidifier.IoTFleetWise.SignalCatalog Create()
    {
        var signalCatalogResult = CreateSignalCatalog();
        factoryAction?.Invoke(signalCatalogResult);

        return signalCatalogResult;
    }

    private Humidifier.IoTFleetWise.SignalCatalog CreateSignalCatalog()
    {
        var signalCatalogResult = new Humidifier.IoTFleetWise.SignalCatalog
        {
            GivenName = InputResourceName,
        };

        return signalCatalogResult;
    }
    public override void CreateChildren(Humidifier.IoTFleetWise.SignalCatalog result)
    {
        base.CreateChildren(result);

        result.Nodes = NodesFactories.Any() ? NodesFactories.Select(x => x.Build()).ToList() : null;
        result.NodeCounts ??= NodeCountsFactory?.Build();
    }

} // End Of Class

public static class SignalCatalogFactoryExtensions
{
    public static CombinedResult<SignalCatalogFactory, InnerSignalCatalogNodeFactory> WithNodes(this SignalCatalogFactory parentFactory, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null)
    {
        var factory = new InnerSignalCatalogNodeFactory(subFactoryAction);
        parentFactory.NodesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SignalCatalogFactory, InnerSignalCatalogNodeCountsFactory> WithNodeCounts(this SignalCatalogFactory parentFactory, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null)
    {
        parentFactory.NodeCountsFactory = new InnerSignalCatalogNodeCountsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NodeCountsFactory);
    }

    public static CombinedResult<SignalCatalogFactory, T1, InnerSignalCatalogNodeFactory> WithNodes<T1>(this CombinedResult<SignalCatalogFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SignalCatalogFactory, InnerSignalCatalogNodeFactory> WithNodes<T1>(this CombinedResult<T1, SignalCatalogFactory> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SignalCatalogFactory, T1, T2, InnerSignalCatalogNodeFactory> WithNodes<T1, T2>(this CombinedResult<SignalCatalogFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SignalCatalogFactory, T2, InnerSignalCatalogNodeFactory> WithNodes<T1, T2>(this CombinedResult<T1, SignalCatalogFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SignalCatalogFactory, InnerSignalCatalogNodeFactory> WithNodes<T1, T2>(this CombinedResult<T1, T2, SignalCatalogFactory> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SignalCatalogFactory, T1, T2, T3, InnerSignalCatalogNodeFactory> WithNodes<T1, T2, T3>(this CombinedResult<SignalCatalogFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SignalCatalogFactory, T2, T3, InnerSignalCatalogNodeFactory> WithNodes<T1, T2, T3>(this CombinedResult<T1, SignalCatalogFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SignalCatalogFactory, T3, InnerSignalCatalogNodeFactory> WithNodes<T1, T2, T3>(this CombinedResult<T1, T2, SignalCatalogFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SignalCatalogFactory, InnerSignalCatalogNodeFactory> WithNodes<T1, T2, T3>(this CombinedResult<T1, T2, T3, SignalCatalogFactory> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SignalCatalogFactory, T1, T2, T3, T4, InnerSignalCatalogNodeFactory> WithNodes<T1, T2, T3, T4>(this CombinedResult<SignalCatalogFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SignalCatalogFactory, T2, T3, T4, InnerSignalCatalogNodeFactory> WithNodes<T1, T2, T3, T4>(this CombinedResult<T1, SignalCatalogFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SignalCatalogFactory, T3, T4, InnerSignalCatalogNodeFactory> WithNodes<T1, T2, T3, T4>(this CombinedResult<T1, T2, SignalCatalogFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SignalCatalogFactory, T4, InnerSignalCatalogNodeFactory> WithNodes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SignalCatalogFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SignalCatalogFactory, InnerSignalCatalogNodeFactory> WithNodes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SignalCatalogFactory> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Node> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodes(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SignalCatalogFactory, T1, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1>(this CombinedResult<SignalCatalogFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeCounts(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SignalCatalogFactory, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1>(this CombinedResult<T1, SignalCatalogFactory> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeCounts(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SignalCatalogFactory, T1, T2, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2>(this CombinedResult<SignalCatalogFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SignalCatalogFactory, T2, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2>(this CombinedResult<T1, SignalCatalogFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SignalCatalogFactory, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2>(this CombinedResult<T1, T2, SignalCatalogFactory> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SignalCatalogFactory, T1, T2, T3, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2, T3>(this CombinedResult<SignalCatalogFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SignalCatalogFactory, T2, T3, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2, T3>(this CombinedResult<T1, SignalCatalogFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SignalCatalogFactory, T3, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2, T3>(this CombinedResult<T1, T2, SignalCatalogFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SignalCatalogFactory, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2, T3>(this CombinedResult<T1, T2, T3, SignalCatalogFactory> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SignalCatalogFactory, T1, T2, T3, T4, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2, T3, T4>(this CombinedResult<SignalCatalogFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SignalCatalogFactory, T2, T3, T4, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2, T3, T4>(this CombinedResult<T1, SignalCatalogFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SignalCatalogFactory, T3, T4, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2, T3, T4>(this CombinedResult<T1, T2, SignalCatalogFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SignalCatalogFactory, T4, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SignalCatalogFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SignalCatalogFactory, InnerSignalCatalogNodeCountsFactory> WithNodeCounts<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SignalCatalogFactory> combinedResult, Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeCounts(combinedResult.T5, subFactoryAction));
}
