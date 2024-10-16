// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerMeshMeshSpecFactory(Action<Humidifier.AppMesh.MeshTypes.MeshSpec> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.MeshTypes.MeshSpec>
{

    internal InnerMeshEgressFilterFactory EgressFilterFactory { get; set; }

    internal InnerMeshMeshServiceDiscoveryFactory ServiceDiscoveryFactory { get; set; }

    protected override Humidifier.AppMesh.MeshTypes.MeshSpec Create()
    {
        var meshSpecResult = CreateMeshSpec();
        factoryAction?.Invoke(meshSpecResult);

        return meshSpecResult;
    }

    private Humidifier.AppMesh.MeshTypes.MeshSpec CreateMeshSpec()
    {
        var meshSpecResult = new Humidifier.AppMesh.MeshTypes.MeshSpec();

        return meshSpecResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.MeshTypes.MeshSpec result)
    {
        base.CreateChildren(result);

        result.EgressFilter ??= EgressFilterFactory?.Build();
        result.ServiceDiscovery ??= ServiceDiscoveryFactory?.Build();
    }

} // End Of Class

public static class InnerMeshMeshSpecFactoryExtensions
{
    public static CombinedResult<InnerMeshMeshSpecFactory, InnerMeshEgressFilterFactory> WithEgressFilter(this InnerMeshMeshSpecFactory parentFactory, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null)
    {
        parentFactory.EgressFilterFactory = new InnerMeshEgressFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EgressFilterFactory);
    }

    public static CombinedResult<InnerMeshMeshSpecFactory, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery(this InnerMeshMeshSpecFactory parentFactory, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null)
    {
        parentFactory.ServiceDiscoveryFactory = new InnerMeshMeshServiceDiscoveryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServiceDiscoveryFactory);
    }

    public static CombinedResult<InnerMeshMeshSpecFactory, T1, InnerMeshEgressFilterFactory> WithEgressFilter<T1>(this CombinedResult<InnerMeshMeshSpecFactory, T1> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMeshMeshSpecFactory, InnerMeshEgressFilterFactory> WithEgressFilter<T1>(this CombinedResult<T1, InnerMeshMeshSpecFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMeshMeshSpecFactory, T1, T2, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2>(this CombinedResult<InnerMeshMeshSpecFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMeshMeshSpecFactory, T2, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2>(this CombinedResult<T1, InnerMeshMeshSpecFactory, T2> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMeshMeshSpecFactory, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2>(this CombinedResult<T1, T2, InnerMeshMeshSpecFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMeshMeshSpecFactory, T1, T2, T3, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2, T3>(this CombinedResult<InnerMeshMeshSpecFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMeshMeshSpecFactory, T2, T3, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2, T3>(this CombinedResult<T1, InnerMeshMeshSpecFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMeshMeshSpecFactory, T3, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerMeshMeshSpecFactory, T3> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMeshMeshSpecFactory, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMeshMeshSpecFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMeshMeshSpecFactory, T1, T2, T3, T4, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2, T3, T4>(this CombinedResult<InnerMeshMeshSpecFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMeshMeshSpecFactory, T2, T3, T4, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerMeshMeshSpecFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMeshMeshSpecFactory, T3, T4, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMeshMeshSpecFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMeshMeshSpecFactory, T4, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMeshMeshSpecFactory, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMeshMeshSpecFactory, InnerMeshEgressFilterFactory> WithEgressFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMeshMeshSpecFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.EgressFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressFilter(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerMeshMeshSpecFactory, T1, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1>(this CombinedResult<InnerMeshMeshSpecFactory, T1> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMeshMeshSpecFactory, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1>(this CombinedResult<T1, InnerMeshMeshSpecFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMeshMeshSpecFactory, T1, T2, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2>(this CombinedResult<InnerMeshMeshSpecFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMeshMeshSpecFactory, T2, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2>(this CombinedResult<T1, InnerMeshMeshSpecFactory, T2> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMeshMeshSpecFactory, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2>(this CombinedResult<T1, T2, InnerMeshMeshSpecFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMeshMeshSpecFactory, T1, T2, T3, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2, T3>(this CombinedResult<InnerMeshMeshSpecFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMeshMeshSpecFactory, T2, T3, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2, T3>(this CombinedResult<T1, InnerMeshMeshSpecFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMeshMeshSpecFactory, T3, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2, T3>(this CombinedResult<T1, T2, InnerMeshMeshSpecFactory, T3> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMeshMeshSpecFactory, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMeshMeshSpecFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMeshMeshSpecFactory, T1, T2, T3, T4, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2, T3, T4>(this CombinedResult<InnerMeshMeshSpecFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMeshMeshSpecFactory, T2, T3, T4, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2, T3, T4>(this CombinedResult<T1, InnerMeshMeshSpecFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMeshMeshSpecFactory, T3, T4, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMeshMeshSpecFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMeshMeshSpecFactory, T4, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMeshMeshSpecFactory, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMeshMeshSpecFactory, InnerMeshMeshServiceDiscoveryFactory> WithServiceDiscovery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMeshMeshSpecFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDiscovery(combinedResult.T5, subFactoryAction));
}
