// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetInferenceConnectorTargetConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorTargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorTargetConfiguration>
{

    internal InnerGatewayTargetInferenceConnectorSourceFactory SourceFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorTargetConfiguration Create()
    {
        var inferenceConnectorTargetConfigurationResult = CreateInferenceConnectorTargetConfiguration();
        factoryAction?.Invoke(inferenceConnectorTargetConfigurationResult);

        return inferenceConnectorTargetConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorTargetConfiguration CreateInferenceConnectorTargetConfiguration()
    {
        var inferenceConnectorTargetConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorTargetConfiguration();

        return inferenceConnectorTargetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorTargetConfiguration result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetInferenceConnectorTargetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource(this InnerGatewayTargetInferenceConnectorTargetConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerGatewayTargetInferenceConnectorSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T1, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1>(this CombinedResult<InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1>(this CombinedResult<T1, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T1, T2, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2>(this CombinedResult<InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T2, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T1, T2, T3, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T2, T3, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T3, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T2, T3, T4, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T3, T4, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T4, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory, InnerGatewayTargetInferenceConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetInferenceConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
