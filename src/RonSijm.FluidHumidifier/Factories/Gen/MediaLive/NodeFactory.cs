// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class NodeFactory(string resourceName = null, Action<Humidifier.MediaLive.Node> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.Node>(resourceName)
{

    internal List<InnerNodeNodeInterfaceMappingFactory> NodeInterfaceMappingsFactories { get; set; } = [];

    internal List<InnerNodeSdiSourceMappingFactory> SdiSourceMappingsFactories { get; set; } = [];

    protected override Humidifier.MediaLive.Node Create()
    {
        var nodeResult = CreateNode();
        factoryAction?.Invoke(nodeResult);

        return nodeResult;
    }

    private Humidifier.MediaLive.Node CreateNode()
    {
        var nodeResult = new Humidifier.MediaLive.Node
        {
            GivenName = InputResourceName,
        };

        return nodeResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.Node result)
    {
        base.CreateChildren(result);

        result.NodeInterfaceMappings = NodeInterfaceMappingsFactories.Any() ? NodeInterfaceMappingsFactories.Select(x => x.Build()).ToList() : null;
        result.SdiSourceMappings = SdiSourceMappingsFactories.Any() ? SdiSourceMappingsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class NodeFactoryExtensions
{
    public static CombinedResult<NodeFactory, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings(this NodeFactory parentFactory, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null)
    {
        var factory = new InnerNodeNodeInterfaceMappingFactory(subFactoryAction);
        parentFactory.NodeInterfaceMappingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<NodeFactory, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings(this NodeFactory parentFactory, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null)
    {
        var factory = new InnerNodeSdiSourceMappingFactory(subFactoryAction);
        parentFactory.SdiSourceMappingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<NodeFactory, T1, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1>(this CombinedResult<NodeFactory, T1> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NodeFactory, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1>(this CombinedResult<T1, NodeFactory> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<NodeFactory, T1, T2, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2>(this CombinedResult<NodeFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NodeFactory, T2, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2>(this CombinedResult<T1, NodeFactory, T2> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NodeFactory, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2>(this CombinedResult<T1, T2, NodeFactory> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<NodeFactory, T1, T2, T3, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2, T3>(this CombinedResult<NodeFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NodeFactory, T2, T3, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2, T3>(this CombinedResult<T1, NodeFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NodeFactory, T3, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2, T3>(this CombinedResult<T1, T2, NodeFactory, T3> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NodeFactory, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, NodeFactory> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<NodeFactory, T1, T2, T3, T4, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2, T3, T4>(this CombinedResult<NodeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NodeFactory, T2, T3, T4, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2, T3, T4>(this CombinedResult<T1, NodeFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NodeFactory, T3, T4, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, NodeFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NodeFactory, T4, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NodeFactory, T4> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, NodeFactory, InnerNodeNodeInterfaceMappingFactory> WithNodeInterfaceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NodeFactory> combinedResult, Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeInterfaceMappings(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<NodeFactory, T1, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1>(this CombinedResult<NodeFactory, T1> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NodeFactory, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1>(this CombinedResult<T1, NodeFactory> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<NodeFactory, T1, T2, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2>(this CombinedResult<NodeFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NodeFactory, T2, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2>(this CombinedResult<T1, NodeFactory, T2> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NodeFactory, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2>(this CombinedResult<T1, T2, NodeFactory> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<NodeFactory, T1, T2, T3, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2, T3>(this CombinedResult<NodeFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NodeFactory, T2, T3, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2, T3>(this CombinedResult<T1, NodeFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NodeFactory, T3, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2, T3>(this CombinedResult<T1, T2, NodeFactory, T3> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NodeFactory, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, NodeFactory> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<NodeFactory, T1, T2, T3, T4, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2, T3, T4>(this CombinedResult<NodeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NodeFactory, T2, T3, T4, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2, T3, T4>(this CombinedResult<T1, NodeFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NodeFactory, T3, T4, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, NodeFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NodeFactory, T4, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NodeFactory, T4> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, NodeFactory, InnerNodeSdiSourceMappingFactory> WithSdiSourceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NodeFactory> combinedResult, Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSdiSourceMappings(combinedResult.T5, subFactoryAction).T2);
}
