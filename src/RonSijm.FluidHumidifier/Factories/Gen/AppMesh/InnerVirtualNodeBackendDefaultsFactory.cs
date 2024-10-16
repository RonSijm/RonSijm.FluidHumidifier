// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeBackendDefaultsFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.BackendDefaults> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.BackendDefaults>
{

    internal InnerVirtualNodeClientPolicyFactory ClientPolicyFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNodeTypes.BackendDefaults Create()
    {
        var backendDefaultsResult = CreateBackendDefaults();
        factoryAction?.Invoke(backendDefaultsResult);

        return backendDefaultsResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.BackendDefaults CreateBackendDefaults()
    {
        var backendDefaultsResult = new Humidifier.AppMesh.VirtualNodeTypes.BackendDefaults();

        return backendDefaultsResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNodeTypes.BackendDefaults result)
    {
        base.CreateChildren(result);

        result.ClientPolicy ??= ClientPolicyFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualNodeBackendDefaultsFactoryExtensions
{
    public static CombinedResult<InnerVirtualNodeBackendDefaultsFactory, InnerVirtualNodeClientPolicyFactory> WithClientPolicy(this InnerVirtualNodeBackendDefaultsFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null)
    {
        parentFactory.ClientPolicyFactory = new InnerVirtualNodeClientPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClientPolicyFactory);
    }

    public static CombinedResult<InnerVirtualNodeBackendDefaultsFactory, T1, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1>(this CombinedResult<InnerVirtualNodeBackendDefaultsFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeBackendDefaultsFactory, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1>(this CombinedResult<T1, InnerVirtualNodeBackendDefaultsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeBackendDefaultsFactory, T1, T2, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2>(this CombinedResult<InnerVirtualNodeBackendDefaultsFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeBackendDefaultsFactory, T2, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2>(this CombinedResult<T1, InnerVirtualNodeBackendDefaultsFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeBackendDefaultsFactory, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeBackendDefaultsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeBackendDefaultsFactory, T1, T2, T3, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2, T3>(this CombinedResult<InnerVirtualNodeBackendDefaultsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeBackendDefaultsFactory, T2, T3, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeBackendDefaultsFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeBackendDefaultsFactory, T3, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeBackendDefaultsFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeBackendDefaultsFactory, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeBackendDefaultsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeBackendDefaultsFactory, T1, T2, T3, T4, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeBackendDefaultsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeBackendDefaultsFactory, T2, T3, T4, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeBackendDefaultsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeBackendDefaultsFactory, T3, T4, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeBackendDefaultsFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeBackendDefaultsFactory, T4, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeBackendDefaultsFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeBackendDefaultsFactory, InnerVirtualNodeClientPolicyFactory> WithClientPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeBackendDefaultsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T5, subFactoryAction));
}
