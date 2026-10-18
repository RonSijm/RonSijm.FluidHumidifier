// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeCodeFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.Code>
{

    internal InnerRuntimeS3LocationFactory S3Factory { get; set; }

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.Code Create()
    {
        var codeResult = CreateCode();
        factoryAction?.Invoke(codeResult);

        return codeResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.Code CreateCode()
    {
        var codeResult = new Humidifier.BedrockAgentCore.RuntimeTypes.Code();

        return codeResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.RuntimeTypes.Code result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerRuntimeCodeFactoryExtensions
{
    public static CombinedResult<InnerRuntimeCodeFactory, InnerRuntimeS3LocationFactory> WithS3(this InnerRuntimeCodeFactory parentFactory, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerRuntimeS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerRuntimeCodeFactory, T1, InnerRuntimeS3LocationFactory> WithS3<T1>(this CombinedResult<InnerRuntimeCodeFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeCodeFactory, InnerRuntimeS3LocationFactory> WithS3<T1>(this CombinedResult<T1, InnerRuntimeCodeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeCodeFactory, T1, T2, InnerRuntimeS3LocationFactory> WithS3<T1, T2>(this CombinedResult<InnerRuntimeCodeFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeCodeFactory, T2, InnerRuntimeS3LocationFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerRuntimeCodeFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeCodeFactory, InnerRuntimeS3LocationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerRuntimeCodeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeCodeFactory, T1, T2, T3, InnerRuntimeS3LocationFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerRuntimeCodeFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeCodeFactory, T2, T3, InnerRuntimeS3LocationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerRuntimeCodeFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeCodeFactory, T3, InnerRuntimeS3LocationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuntimeCodeFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuntimeCodeFactory, InnerRuntimeS3LocationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuntimeCodeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeCodeFactory, T1, T2, T3, T4, InnerRuntimeS3LocationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerRuntimeCodeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeCodeFactory, T2, T3, T4, InnerRuntimeS3LocationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuntimeCodeFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeCodeFactory, T3, T4, InnerRuntimeS3LocationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuntimeCodeFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuntimeCodeFactory, T4, InnerRuntimeS3LocationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuntimeCodeFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRuntimeCodeFactory, InnerRuntimeS3LocationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuntimeCodeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
}
