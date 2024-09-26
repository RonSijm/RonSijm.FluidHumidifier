// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class NodeFactory(string resourceName = null, Action<Humidifier.ManagedBlockchain.Node> factoryAction = null) : ResourceFactory<Humidifier.ManagedBlockchain.Node>(resourceName)
{

    internal InnerNodeNodeConfigurationFactory NodeConfigurationFactory { get; set; }

    protected override Humidifier.ManagedBlockchain.Node Create()
    {
        var nodeResult = CreateNode();
        factoryAction?.Invoke(nodeResult);

        return nodeResult;
    }

    private Humidifier.ManagedBlockchain.Node CreateNode()
    {
        var nodeResult = new Humidifier.ManagedBlockchain.Node
        {
            GivenName = InputResourceName,
        };

        return nodeResult;
    }
    public override void CreateChildren(Humidifier.ManagedBlockchain.Node result)
    {
        base.CreateChildren(result);

        result.NodeConfiguration ??= NodeConfigurationFactory?.Build();
    }

} // End Of Class

public static class NodeFactoryExtensions
{
    public static CombinedResult<NodeFactory, InnerNodeNodeConfigurationFactory> WithNodeConfiguration(this NodeFactory parentFactory, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null)
    {
        parentFactory.NodeConfigurationFactory = new InnerNodeNodeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NodeConfigurationFactory);
    }

    public static CombinedResult<NodeFactory, T1, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1>(this CombinedResult<NodeFactory, T1> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NodeFactory, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1>(this CombinedResult<T1, NodeFactory> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NodeFactory, T1, T2, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2>(this CombinedResult<NodeFactory, T1, T2> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NodeFactory, T2, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2>(this CombinedResult<T1, NodeFactory, T2> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NodeFactory, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2>(this CombinedResult<T1, T2, NodeFactory> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NodeFactory, T1, T2, T3, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2, T3>(this CombinedResult<NodeFactory, T1, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NodeFactory, T2, T3, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2, T3>(this CombinedResult<T1, NodeFactory, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NodeFactory, T3, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, NodeFactory, T3> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NodeFactory, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, NodeFactory> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NodeFactory, T1, T2, T3, T4, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2, T3, T4>(this CombinedResult<NodeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NodeFactory, T2, T3, T4, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, NodeFactory, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NodeFactory, T3, T4, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, NodeFactory, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NodeFactory, T4, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NodeFactory, T4> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NodeFactory, InnerNodeNodeConfigurationFactory> WithNodeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NodeFactory> combinedResult, Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeConfiguration(combinedResult.T5, subFactoryAction));
}
