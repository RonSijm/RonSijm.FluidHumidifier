// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetMcpServerTargetConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpServerTargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpServerTargetConfiguration>
{

    internal InnerGatewayTargetMcpToolSchemaConfigurationFactory McpToolSchemaFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.McpServerTargetConfiguration Create()
    {
        var mcpServerTargetConfigurationResult = CreateMcpServerTargetConfiguration();
        factoryAction?.Invoke(mcpServerTargetConfigurationResult);

        return mcpServerTargetConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.McpServerTargetConfiguration CreateMcpServerTargetConfiguration()
    {
        var mcpServerTargetConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.McpServerTargetConfiguration();

        return mcpServerTargetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.McpServerTargetConfiguration result)
    {
        base.CreateChildren(result);

        result.McpToolSchema ??= McpToolSchemaFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetMcpServerTargetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetMcpServerTargetConfigurationFactory, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema(this InnerGatewayTargetMcpServerTargetConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null)
    {
        parentFactory.McpToolSchemaFactory = new InnerGatewayTargetMcpToolSchemaConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.McpToolSchemaFactory);
    }

    public static CombinedResult<InnerGatewayTargetMcpServerTargetConfigurationFactory, T1, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1>(this CombinedResult<InnerGatewayTargetMcpServerTargetConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpServerTargetConfigurationFactory, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1>(this CombinedResult<T1, InnerGatewayTargetMcpServerTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetMcpServerTargetConfigurationFactory, T1, T2, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2>(this CombinedResult<InnerGatewayTargetMcpServerTargetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpServerTargetConfigurationFactory, T2, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2>(this CombinedResult<T1, InnerGatewayTargetMcpServerTargetConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetMcpServerTargetConfigurationFactory, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetMcpServerTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetMcpServerTargetConfigurationFactory, T1, T2, T3, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2, T3>(this CombinedResult<InnerGatewayTargetMcpServerTargetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpServerTargetConfigurationFactory, T2, T3, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetMcpServerTargetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetMcpServerTargetConfigurationFactory, T3, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetMcpServerTargetConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetMcpServerTargetConfigurationFactory, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetMcpServerTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetMcpServerTargetConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetMcpServerTargetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpServerTargetConfigurationFactory, T2, T3, T4, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetMcpServerTargetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetMcpServerTargetConfigurationFactory, T3, T4, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetMcpServerTargetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetMcpServerTargetConfigurationFactory, T4, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetMcpServerTargetConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetMcpServerTargetConfigurationFactory, InnerGatewayTargetMcpToolSchemaConfigurationFactory> WithMcpToolSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetMcpServerTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMcpToolSchema(combinedResult.T5, subFactoryAction).T2);
}
