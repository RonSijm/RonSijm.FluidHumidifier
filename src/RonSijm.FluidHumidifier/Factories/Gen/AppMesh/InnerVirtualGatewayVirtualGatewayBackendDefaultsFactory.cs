// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayBackendDefaults> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayBackendDefaults>
{

    internal InnerVirtualGatewayVirtualGatewayClientPolicyFactory ClientPolicyFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayBackendDefaults Create()
    {
        var virtualGatewayBackendDefaultsResult = CreateVirtualGatewayBackendDefaults();
        factoryAction?.Invoke(virtualGatewayBackendDefaultsResult);

        return virtualGatewayBackendDefaultsResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayBackendDefaults CreateVirtualGatewayBackendDefaults()
    {
        var virtualGatewayBackendDefaultsResult = new Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayBackendDefaults();

        return virtualGatewayBackendDefaultsResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayBackendDefaults result)
    {
        base.CreateChildren(result);

        result.ClientPolicy ??= ClientPolicyFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualGatewayVirtualGatewayBackendDefaultsFactoryExtensions
{
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy(this InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory parentFactory, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null)
    {
        parentFactory.ClientPolicyFactory = new InnerVirtualGatewayVirtualGatewayClientPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClientPolicyFactory);
    }

    public static CombinedResult<InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T1, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1>(this CombinedResult<InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T1, T2, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2>(this CombinedResult<InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T2, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T1, T2, T3, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2, T3>(this CombinedResult<InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T2, T3, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2, T3>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T3, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2, T3, T4>(this CombinedResult<InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T2, T3, T4, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T3, T4, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T4, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> WithClientPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayBackendDefaultsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientPolicy(combinedResult.T5, subFactoryAction));
}
