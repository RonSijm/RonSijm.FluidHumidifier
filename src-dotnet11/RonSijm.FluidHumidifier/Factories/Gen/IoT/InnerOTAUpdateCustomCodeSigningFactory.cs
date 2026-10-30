// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateCustomCodeSigningFactory(Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning>
{

    internal InnerOTAUpdateCodeSigningSignatureFactory SignatureFactory { get; set; }

    internal InnerOTAUpdateCodeSigningCertificateChainFactory CertificateChainFactory { get; set; }

    protected override Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning Create()
    {
        var customCodeSigningResult = CreateCustomCodeSigning();
        factoryAction?.Invoke(customCodeSigningResult);

        return customCodeSigningResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning CreateCustomCodeSigning()
    {
        var customCodeSigningResult = new Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning();

        return customCodeSigningResult;
    }
    public override void CreateChildren(Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning result)
    {
        base.CreateChildren(result);

        result.Signature ??= SignatureFactory?.Build();
        result.CertificateChain ??= CertificateChainFactory?.Build();
    }

} // End Of Class

public static class InnerOTAUpdateCustomCodeSigningFactoryExtensions
{
    public static CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature(this InnerOTAUpdateCustomCodeSigningFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null)
    {
        parentFactory.SignatureFactory = new InnerOTAUpdateCodeSigningSignatureFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SignatureFactory);
    }

    public static CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain(this InnerOTAUpdateCustomCodeSigningFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null)
    {
        parentFactory.CertificateChainFactory = new InnerOTAUpdateCodeSigningCertificateChainFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CertificateChainFactory);
    }

    public static CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1>(this CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignature(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1>(this CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignature(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2>(this CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2>(this CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2, T3, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2, T3>(this CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2, T3, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory, T3, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateCustomCodeSigningFactory, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateCustomCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2, T3, T4, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2, T3, T4, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory, T3, T4, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateCustomCodeSigningFactory, T4, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateCustomCodeSigningFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateCustomCodeSigningFactory, InnerOTAUpdateCodeSigningSignatureFactory> WithSignature<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateCustomCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignature(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1>(this CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateChain(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1>(this CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateChain(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2>(this CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2>(this CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2, T3, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2, T3>(this CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2, T3, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory, T3, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateCustomCodeSigningFactory, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateCustomCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2, T3, T4, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateCustomCodeSigningFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2, T3, T4, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateCustomCodeSigningFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory, T3, T4, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateCustomCodeSigningFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateCustomCodeSigningFactory, T4, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateCustomCodeSigningFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateCustomCodeSigningFactory, InnerOTAUpdateCodeSigningCertificateChainFactory> WithCertificateChain<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateCustomCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateChain(combinedResult.T5, subFactoryAction).T2);
}
