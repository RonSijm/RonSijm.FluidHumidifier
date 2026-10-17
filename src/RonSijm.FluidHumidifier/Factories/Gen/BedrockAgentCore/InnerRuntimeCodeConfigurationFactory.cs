// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeCodeConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.CodeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.CodeConfiguration>
{

    internal InnerRuntimeCodeFactory CodeFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.CodeConfiguration Create()
    {
        var codeConfigurationResult = CreateCodeConfiguration();
        factoryAction?.Invoke(codeConfigurationResult);

        return codeConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.CodeConfiguration CreateCodeConfiguration()
    {
        var codeConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.CodeConfiguration();

        return codeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.RuntimeTypes.CodeConfiguration result)
    {
        base.CreateChildren(result);

        result.Code ??= CodeFactory?.Build();
    }

} // End Of Class

public static class InnerRuntimeCodeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRuntimeCodeConfigurationFactory, InnerRuntimeCodeFactory> WithCode(this InnerRuntimeCodeConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null)
    {
        parentFactory.CodeFactory = new InnerRuntimeCodeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeFactory);
    }

    public static CombinedResult<InnerRuntimeCodeConfigurationFactory, T1, InnerRuntimeCodeFactory> WithCode<T1>(this CombinedResult<InnerRuntimeCodeConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeCodeConfigurationFactory, InnerRuntimeCodeFactory> WithCode<T1>(this CombinedResult<T1, InnerRuntimeCodeConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeCodeConfigurationFactory, T1, T2, InnerRuntimeCodeFactory> WithCode<T1, T2>(this CombinedResult<InnerRuntimeCodeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeCodeConfigurationFactory, T2, InnerRuntimeCodeFactory> WithCode<T1, T2>(this CombinedResult<T1, InnerRuntimeCodeConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeCodeConfigurationFactory, InnerRuntimeCodeFactory> WithCode<T1, T2>(this CombinedResult<T1, T2, InnerRuntimeCodeConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeCodeConfigurationFactory, T1, T2, T3, InnerRuntimeCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<InnerRuntimeCodeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeCodeConfigurationFactory, T2, T3, InnerRuntimeCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<T1, InnerRuntimeCodeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeCodeConfigurationFactory, T3, InnerRuntimeCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuntimeCodeConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuntimeCodeConfigurationFactory, InnerRuntimeCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuntimeCodeConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeCodeConfigurationFactory, T1, T2, T3, T4, InnerRuntimeCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<InnerRuntimeCodeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeCodeConfigurationFactory, T2, T3, T4, InnerRuntimeCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuntimeCodeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeCodeConfigurationFactory, T3, T4, InnerRuntimeCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuntimeCodeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuntimeCodeConfigurationFactory, T4, InnerRuntimeCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuntimeCodeConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRuntimeCodeConfigurationFactory, InnerRuntimeCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuntimeCodeConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T5, subFactoryAction).T2);
}
