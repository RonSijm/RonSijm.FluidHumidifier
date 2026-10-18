// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetMcpToolSchemaConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration>
{

    internal InnerGatewayTargetS3ConfigurationFactory S3Factory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration Create()
    {
        var mcpToolSchemaConfigurationResult = CreateMcpToolSchemaConfiguration();
        factoryAction?.Invoke(mcpToolSchemaConfigurationResult);

        return mcpToolSchemaConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration CreateMcpToolSchemaConfiguration()
    {
        var mcpToolSchemaConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration();

        return mcpToolSchemaConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetMcpToolSchemaConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetMcpToolSchemaConfigurationFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3(this InnerGatewayTargetMcpToolSchemaConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerGatewayTargetS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerGatewayTargetMcpToolSchemaConfigurationFactory, T1, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1>(this CombinedResult<InnerGatewayTargetMcpToolSchemaConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpToolSchemaConfigurationFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1>(this CombinedResult<T1, InnerGatewayTargetMcpToolSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetMcpToolSchemaConfigurationFactory, T1, T2, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2>(this CombinedResult<InnerGatewayTargetMcpToolSchemaConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T2, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetMcpToolSchemaConfigurationFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetMcpToolSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetMcpToolSchemaConfigurationFactory, T1, T2, T3, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerGatewayTargetMcpToolSchemaConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T2, T3, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T3, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetMcpToolSchemaConfigurationFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetMcpToolSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetMcpToolSchemaConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetMcpToolSchemaConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T2, T3, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T3, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetMcpToolSchemaConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetMcpToolSchemaConfigurationFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetMcpToolSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
}
