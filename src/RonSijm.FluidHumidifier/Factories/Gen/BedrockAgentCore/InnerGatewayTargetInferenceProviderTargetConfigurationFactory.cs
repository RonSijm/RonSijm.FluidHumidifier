// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetInferenceProviderTargetConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceProviderTargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceProviderTargetConfiguration>
{

    internal InnerGatewayTargetModelMappingFactory ModelMappingFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceProviderTargetConfiguration Create()
    {
        var inferenceProviderTargetConfigurationResult = CreateInferenceProviderTargetConfiguration();
        factoryAction?.Invoke(inferenceProviderTargetConfigurationResult);

        return inferenceProviderTargetConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceProviderTargetConfiguration CreateInferenceProviderTargetConfiguration()
    {
        var inferenceProviderTargetConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceProviderTargetConfiguration();

        return inferenceProviderTargetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceProviderTargetConfiguration result)
    {
        base.CreateChildren(result);

        result.ModelMapping ??= ModelMappingFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetInferenceProviderTargetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetInferenceProviderTargetConfigurationFactory, InnerGatewayTargetModelMappingFactory> WithModelMapping(this InnerGatewayTargetInferenceProviderTargetConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null)
    {
        parentFactory.ModelMappingFactory = new InnerGatewayTargetModelMappingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ModelMappingFactory);
    }

    public static CombinedResult<InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T1, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1>(this CombinedResult<InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1>(this CombinedResult<T1, InnerGatewayTargetInferenceProviderTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T1, T2, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2>(this CombinedResult<InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T2, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2>(this CombinedResult<T1, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetInferenceProviderTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T1, T2, T3, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2, T3>(this CombinedResult<InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T2, T3, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T3, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetInferenceProviderTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T2, T3, T4, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T3, T4, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T4, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetInferenceProviderTargetConfigurationFactory, InnerGatewayTargetModelMappingFactory> WithModelMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetInferenceProviderTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelMapping(combinedResult.T5, subFactoryAction).T2);
}
