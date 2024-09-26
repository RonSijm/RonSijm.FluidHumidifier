// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayVirtualGatewayClientPolicyFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy>
{

    internal InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory TLSFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy Create()
    {
        var virtualGatewayClientPolicyResult = CreateVirtualGatewayClientPolicy();
        factoryAction?.Invoke(virtualGatewayClientPolicyResult);

        return virtualGatewayClientPolicyResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy CreateVirtualGatewayClientPolicy()
    {
        var virtualGatewayClientPolicyResult = new Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy();

        return virtualGatewayClientPolicyResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy result)
    {
        base.CreateChildren(result);

        result.TLS ??= TLSFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualGatewayVirtualGatewayClientPolicyFactoryExtensions
{
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayClientPolicyFactory, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS(this InnerVirtualGatewayVirtualGatewayClientPolicyFactory parentFactory, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null)
    {
        parentFactory.TLSFactory = new InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TLSFactory);
    }

    public static CombinedResult<InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T1, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1>(this CombinedResult<InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, WithTLS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, WithTLS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T1, T2, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2>(this CombinedResult<InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T2, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T1, T2, T3, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2, T3>(this CombinedResult<InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T2, T3, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2, T3>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T3, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2, T3, T4>(this CombinedResult<InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T2, T3, T4, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T3, T4, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T4, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayClientPolicyFactory, InnerVirtualGatewayVirtualGatewayClientPolicyTlsFactory> WithTLS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayClientPolicyFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLS(combinedResult.T5, subFactoryAction));
}
