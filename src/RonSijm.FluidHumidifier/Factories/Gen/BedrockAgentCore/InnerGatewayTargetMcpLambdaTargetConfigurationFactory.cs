// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetMcpLambdaTargetConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpLambdaTargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpLambdaTargetConfiguration>
{

    internal InnerGatewayTargetToolSchemaFactory ToolSchemaFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.McpLambdaTargetConfiguration Create()
    {
        var mcpLambdaTargetConfigurationResult = CreateMcpLambdaTargetConfiguration();
        factoryAction?.Invoke(mcpLambdaTargetConfigurationResult);

        return mcpLambdaTargetConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.McpLambdaTargetConfiguration CreateMcpLambdaTargetConfiguration()
    {
        var mcpLambdaTargetConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.McpLambdaTargetConfiguration();

        return mcpLambdaTargetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.McpLambdaTargetConfiguration result)
    {
        base.CreateChildren(result);

        result.ToolSchema ??= ToolSchemaFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetMcpLambdaTargetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetMcpLambdaTargetConfigurationFactory, InnerGatewayTargetToolSchemaFactory> WithToolSchema(this InnerGatewayTargetMcpLambdaTargetConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null)
    {
        parentFactory.ToolSchemaFactory = new InnerGatewayTargetToolSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ToolSchemaFactory);
    }

    public static CombinedResult<InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T1, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1>(this CombinedResult<InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithToolSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1>(this CombinedResult<T1, InnerGatewayTargetMcpLambdaTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithToolSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T1, T2, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2>(this CombinedResult<InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T2, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2>(this CombinedResult<T1, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetMcpLambdaTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T1, T2, T3, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2, T3>(this CombinedResult<InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T2, T3, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T3, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetMcpLambdaTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T2, T3, T4, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T3, T4, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T4, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetMcpLambdaTargetConfigurationFactory, InnerGatewayTargetToolSchemaFactory> WithToolSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetMcpLambdaTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolSchema(combinedResult.T5, subFactoryAction).T2);
}
