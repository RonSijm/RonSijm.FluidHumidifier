// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerBrowserCustomCertificateFactory(Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.Certificate> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.BrowserCustomTypes.Certificate>
{

    internal InnerBrowserCustomCertificateLocationFactory CertificateLocationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.BrowserCustomTypes.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.BedrockAgentCore.BrowserCustomTypes.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.BedrockAgentCore.BrowserCustomTypes.Certificate();

        return certificateResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.BrowserCustomTypes.Certificate result)
    {
        base.CreateChildren(result);

        result.CertificateLocation ??= CertificateLocationFactory?.Build();
    }

} // End Of Class

public static class InnerBrowserCustomCertificateFactoryExtensions
{
    public static CombinedResult<InnerBrowserCustomCertificateFactory, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation(this InnerBrowserCustomCertificateFactory parentFactory, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null)
    {
        parentFactory.CertificateLocationFactory = new InnerBrowserCustomCertificateLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CertificateLocationFactory);
    }

    public static CombinedResult<InnerBrowserCustomCertificateFactory, T1, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1>(this CombinedResult<InnerBrowserCustomCertificateFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomCertificateFactory, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1>(this CombinedResult<T1, InnerBrowserCustomCertificateFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomCertificateFactory, T1, T2, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2>(this CombinedResult<InnerBrowserCustomCertificateFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomCertificateFactory, T2, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2>(this CombinedResult<T1, InnerBrowserCustomCertificateFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomCertificateFactory, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2>(this CombinedResult<T1, T2, InnerBrowserCustomCertificateFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomCertificateFactory, T1, T2, T3, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3>(this CombinedResult<InnerBrowserCustomCertificateFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomCertificateFactory, T2, T3, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3>(this CombinedResult<T1, InnerBrowserCustomCertificateFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomCertificateFactory, T3, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerBrowserCustomCertificateFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrowserCustomCertificateFactory, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBrowserCustomCertificateFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomCertificateFactory, T1, T2, T3, T4, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3, T4>(this CombinedResult<InnerBrowserCustomCertificateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomCertificateFactory, T2, T3, T4, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerBrowserCustomCertificateFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomCertificateFactory, T3, T4, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBrowserCustomCertificateFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrowserCustomCertificateFactory, T4, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBrowserCustomCertificateFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBrowserCustomCertificateFactory, InnerBrowserCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBrowserCustomCertificateFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T5, subFactoryAction).T2);
}
