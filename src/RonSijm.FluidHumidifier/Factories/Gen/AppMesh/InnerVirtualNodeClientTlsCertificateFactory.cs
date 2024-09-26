// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeClientTlsCertificateFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate>
{

    internal InnerVirtualNodeListenerTlsSdsCertificateFactory SDSFactory { get; set; }

    internal InnerVirtualNodeListenerTlsFileCertificateFactory FileFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate Create()
    {
        var clientTlsCertificateResult = CreateClientTlsCertificate();
        factoryAction?.Invoke(clientTlsCertificateResult);

        return clientTlsCertificateResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate CreateClientTlsCertificate()
    {
        var clientTlsCertificateResult = new Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate();

        return clientTlsCertificateResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate result)
    {
        base.CreateChildren(result);

        result.SDS ??= SDSFactory?.Build();
        result.File ??= FileFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualNodeClientTlsCertificateFactoryExtensions
{
    public static CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS(this InnerVirtualNodeClientTlsCertificateFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null)
    {
        parentFactory.SDSFactory = new InnerVirtualNodeListenerTlsSdsCertificateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SDSFactory);
    }

    public static CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile(this InnerVirtualNodeClientTlsCertificateFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null)
    {
        parentFactory.FileFactory = new InnerVirtualNodeListenerTlsFileCertificateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileFactory);
    }

    public static CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1>(this CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, WithSDS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1>(this CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, WithSDS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2>(this CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2>(this CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2, T3, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2, T3>(this CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2, T3, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory, T3, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeClientTlsCertificateFactory, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeClientTlsCertificateFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2, T3, T4, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2, T3, T4, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory, T3, T4, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeClientTlsCertificateFactory, T4, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeClientTlsCertificateFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeClientTlsCertificateFactory, InnerVirtualNodeListenerTlsSdsCertificateFactory> WithSDS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeClientTlsCertificateFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1>(this CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1>(this CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2>(this CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2>(this CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2, T3, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2, T3>(this CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2, T3, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory, T3, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeClientTlsCertificateFactory, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeClientTlsCertificateFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2, T3, T4, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeClientTlsCertificateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2, T3, T4, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeClientTlsCertificateFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory, T3, T4, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeClientTlsCertificateFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeClientTlsCertificateFactory, T4, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeClientTlsCertificateFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeClientTlsCertificateFactory, InnerVirtualNodeListenerTlsFileCertificateFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeClientTlsCertificateFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T5, subFactoryAction));
}
