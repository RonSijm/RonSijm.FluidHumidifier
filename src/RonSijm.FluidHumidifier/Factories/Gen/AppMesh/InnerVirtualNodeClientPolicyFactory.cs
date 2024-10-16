// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeClientPolicyFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy>
{

    internal InnerVirtualNodeClientPolicyTlsFactory TLSFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy Create()
    {
        var clientPolicyResult = CreateClientPolicy();
        factoryAction?.Invoke(clientPolicyResult);

        return clientPolicyResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy CreateClientPolicy()
    {
        var clientPolicyResult = new Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy();

        return clientPolicyResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy result)
    {
        base.CreateChildren(result);

        result.TLS ??= TLSFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualNodeClientPolicyFactoryExtensions
{
    public static CombinedResult<InnerVirtualNodeClientPolicyFactory, InnerVirtualNodeClientPolicyTlsFactory> WithTLS(this InnerVirtualNodeClientPolicyFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null)
    {
        parentFactory.TLSFactory = new InnerVirtualNodeClientPolicyTlsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TLSFactory);
    }

    public static CombinedResult<InnerVirtualNodeClientPolicyFactory, T1, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1>(this CombinedResult<InnerVirtualNodeClientPolicyFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, WithTLS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyFactory, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1>(this CombinedResult<T1, InnerVirtualNodeClientPolicyFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, WithTLS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientPolicyFactory, T1, T2, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2>(this CombinedResult<InnerVirtualNodeClientPolicyFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyFactory, T2, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2>(this CombinedResult<T1, InnerVirtualNodeClientPolicyFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientPolicyFactory, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeClientPolicyFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientPolicyFactory, T1, T2, T3, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2, T3>(this CombinedResult<InnerVirtualNodeClientPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyFactory, T2, T3, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeClientPolicyFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientPolicyFactory, T3, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeClientPolicyFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyFactory, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientPolicyFactory, T1, T2, T3, T4, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeClientPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyFactory, T2, T3, T4, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeClientPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientPolicyFactory, T3, T4, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeClientPolicyFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyFactory, T4, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeClientPolicyFactory, InnerVirtualNodeClientPolicyTlsFactory> WithTLS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeClientPolicyFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T5, subFactoryAction));
}
