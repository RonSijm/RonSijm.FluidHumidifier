// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeClientPolicyTlsFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls>
{

    internal InnerVirtualNodeTlsValidationContextFactory ValidationFactory { get; set; }

    internal InnerVirtualNodeClientTlsCertificateFactory CertificateFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls Create()
    {
        var clientPolicyTlsResult = CreateClientPolicyTls();
        factoryAction?.Invoke(clientPolicyTlsResult);

        return clientPolicyTlsResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls CreateClientPolicyTls()
    {
        var clientPolicyTlsResult = new Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls();

        return clientPolicyTlsResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls result)
    {
        base.CreateChildren(result);

        result.Validation ??= ValidationFactory?.Build();
        result.Certificate ??= CertificateFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualNodeClientPolicyTlsFactoryExtensions
{
    public static CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, InnerVirtualNodeTlsValidationContextFactory> WithValidation(this InnerVirtualNodeClientPolicyTlsFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null)
    {
        parentFactory.ValidationFactory = new InnerVirtualNodeTlsValidationContextFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValidationFactory);
    }

    public static CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate(this InnerVirtualNodeClientPolicyTlsFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null)
    {
        parentFactory.CertificateFactory = new InnerVirtualNodeClientTlsCertificateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CertificateFactory);
    }

    public static CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1>(this CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1>(this CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2>(this CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2>(this CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2, T3, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2, T3>(this CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2, T3, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory, T3, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyTlsFactory, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyTlsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2, T3, T4, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2, T3, T4, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory, T3, T4, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyTlsFactory, T4, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyTlsFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeClientPolicyTlsFactory, InnerVirtualNodeTlsValidationContextFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeClientPolicyTlsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1>(this CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1>(this CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2>(this CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2>(this CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2, T3, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2, T3>(this CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2, T3, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory, T3, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyTlsFactory, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyTlsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2, T3, T4, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeClientPolicyTlsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2, T3, T4, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeClientPolicyTlsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory, T3, T4, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeClientPolicyTlsFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyTlsFactory, T4, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeClientPolicyTlsFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeClientPolicyTlsFactory, InnerVirtualNodeClientTlsCertificateFactory> WithCertificate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeClientPolicyTlsFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificate(combinedResult.T5, subFactoryAction));
}
