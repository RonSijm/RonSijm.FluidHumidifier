// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCodeInterpreterCustomCertificateFactory(Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate>
{

    internal InnerCodeInterpreterCustomCertificateLocationFactory CertificateLocationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate();

        return certificateResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate result)
    {
        base.CreateChildren(result);

        result.CertificateLocation ??= CertificateLocationFactory?.Build();
    }

} // End Of Class

public static class InnerCodeInterpreterCustomCertificateFactoryExtensions
{
    public static CombinedResult<InnerCodeInterpreterCustomCertificateFactory, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation(this InnerCodeInterpreterCustomCertificateFactory parentFactory, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null)
    {
        parentFactory.CertificateLocationFactory = new InnerCodeInterpreterCustomCertificateLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CertificateLocationFactory);
    }

    public static CombinedResult<InnerCodeInterpreterCustomCertificateFactory, T1, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1>(this CombinedResult<InnerCodeInterpreterCustomCertificateFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeInterpreterCustomCertificateFactory, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1>(this CombinedResult<T1, InnerCodeInterpreterCustomCertificateFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCodeInterpreterCustomCertificateFactory, T1, T2, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2>(this CombinedResult<InnerCodeInterpreterCustomCertificateFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeInterpreterCustomCertificateFactory, T2, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2>(this CombinedResult<T1, InnerCodeInterpreterCustomCertificateFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodeInterpreterCustomCertificateFactory, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2>(this CombinedResult<T1, T2, InnerCodeInterpreterCustomCertificateFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCodeInterpreterCustomCertificateFactory, T1, T2, T3, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3>(this CombinedResult<InnerCodeInterpreterCustomCertificateFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeInterpreterCustomCertificateFactory, T2, T3, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3>(this CombinedResult<T1, InnerCodeInterpreterCustomCertificateFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodeInterpreterCustomCertificateFactory, T3, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerCodeInterpreterCustomCertificateFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodeInterpreterCustomCertificateFactory, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCodeInterpreterCustomCertificateFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCodeInterpreterCustomCertificateFactory, T1, T2, T3, T4, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3, T4>(this CombinedResult<InnerCodeInterpreterCustomCertificateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeInterpreterCustomCertificateFactory, T2, T3, T4, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerCodeInterpreterCustomCertificateFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodeInterpreterCustomCertificateFactory, T3, T4, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCodeInterpreterCustomCertificateFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodeInterpreterCustomCertificateFactory, T4, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCodeInterpreterCustomCertificateFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCodeInterpreterCustomCertificateFactory, InnerCodeInterpreterCustomCertificateLocationFactory> WithCertificateLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCodeInterpreterCustomCertificateFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateLocation(combinedResult.T5, subFactoryAction).T2);
}
