// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class VirtualNodeFactory(string resourceName = null, Action<Humidifier.AppMesh.VirtualNode> factoryAction = null) : ResourceFactory<Humidifier.AppMesh.VirtualNode>(resourceName)
{

    internal InnerVirtualNodeVirtualNodeSpecFactory SpecFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNode Create()
    {
        var virtualNodeResult = CreateVirtualNode();
        factoryAction?.Invoke(virtualNodeResult);

        return virtualNodeResult;
    }

    private Humidifier.AppMesh.VirtualNode CreateVirtualNode()
    {
        var virtualNodeResult = new Humidifier.AppMesh.VirtualNode
        {
            GivenName = InputResourceName,
        };

        return virtualNodeResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNode result)
    {
        base.CreateChildren(result);

        result.Spec ??= SpecFactory?.Build();
    }

} // End Of Class

public static class VirtualNodeFactoryExtensions
{
    public static CombinedResult<VirtualNodeFactory, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec(this VirtualNodeFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null)
    {
        parentFactory.SpecFactory = new InnerVirtualNodeVirtualNodeSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpecFactory);
    }

    public static CombinedResult<VirtualNodeFactory, T1, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1>(this CombinedResult<VirtualNodeFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualNodeFactory, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1>(this CombinedResult<T1, VirtualNodeFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VirtualNodeFactory, T1, T2, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2>(this CombinedResult<VirtualNodeFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualNodeFactory, T2, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, VirtualNodeFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualNodeFactory, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, T2, VirtualNodeFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VirtualNodeFactory, T1, T2, T3, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<VirtualNodeFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualNodeFactory, T2, T3, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, VirtualNodeFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualNodeFactory, T3, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, VirtualNodeFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VirtualNodeFactory, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, VirtualNodeFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VirtualNodeFactory, T1, T2, T3, T4, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<VirtualNodeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualNodeFactory, T2, T3, T4, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, VirtualNodeFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualNodeFactory, T3, T4, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, VirtualNodeFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VirtualNodeFactory, T4, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VirtualNodeFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VirtualNodeFactory, InnerVirtualNodeVirtualNodeSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VirtualNodeFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T5, subFactoryAction));
}
