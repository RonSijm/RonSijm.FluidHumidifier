// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetRuntimeTargetConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.RuntimeTargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.RuntimeTargetConfiguration>
{

    internal InnerGatewayTargetHttpApiSchemaConfigurationFactory SchemaFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.RuntimeTargetConfiguration Create()
    {
        var runtimeTargetConfigurationResult = CreateRuntimeTargetConfiguration();
        factoryAction?.Invoke(runtimeTargetConfigurationResult);

        return runtimeTargetConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.RuntimeTargetConfiguration CreateRuntimeTargetConfiguration()
    {
        var runtimeTargetConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.RuntimeTargetConfiguration();

        return runtimeTargetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.RuntimeTargetConfiguration result)
    {
        base.CreateChildren(result);

        result.Schema ??= SchemaFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetRuntimeTargetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetRuntimeTargetConfigurationFactory, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema(this InnerGatewayTargetRuntimeTargetConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null)
    {
        parentFactory.SchemaFactory = new InnerGatewayTargetHttpApiSchemaConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaFactory);
    }

    public static CombinedResult<InnerGatewayTargetRuntimeTargetConfigurationFactory, T1, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1>(this CombinedResult<InnerGatewayTargetRuntimeTargetConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetRuntimeTargetConfigurationFactory, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1>(this CombinedResult<T1, InnerGatewayTargetRuntimeTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetRuntimeTargetConfigurationFactory, T1, T2, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2>(this CombinedResult<InnerGatewayTargetRuntimeTargetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetRuntimeTargetConfigurationFactory, T2, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2>(this CombinedResult<T1, InnerGatewayTargetRuntimeTargetConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetRuntimeTargetConfigurationFactory, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetRuntimeTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetRuntimeTargetConfigurationFactory, T1, T2, T3, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2, T3>(this CombinedResult<InnerGatewayTargetRuntimeTargetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetRuntimeTargetConfigurationFactory, T2, T3, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetRuntimeTargetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetRuntimeTargetConfigurationFactory, T3, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetRuntimeTargetConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetRuntimeTargetConfigurationFactory, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetRuntimeTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetRuntimeTargetConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetRuntimeTargetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetRuntimeTargetConfigurationFactory, T2, T3, T4, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetRuntimeTargetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetRuntimeTargetConfigurationFactory, T3, T4, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetRuntimeTargetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetRuntimeTargetConfigurationFactory, T4, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetRuntimeTargetConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetRuntimeTargetConfigurationFactory, InnerGatewayTargetHttpApiSchemaConfigurationFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetRuntimeTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T5, subFactoryAction).T2);
}
