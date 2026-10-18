// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayGatewayProtocolConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.GatewayProtocolConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.GatewayProtocolConfiguration>
{

    internal InnerGatewayMCPGatewayConfigurationFactory McpFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTypes.GatewayProtocolConfiguration Create()
    {
        var gatewayProtocolConfigurationResult = CreateGatewayProtocolConfiguration();
        factoryAction?.Invoke(gatewayProtocolConfigurationResult);

        return gatewayProtocolConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.GatewayProtocolConfiguration CreateGatewayProtocolConfiguration()
    {
        var gatewayProtocolConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTypes.GatewayProtocolConfiguration();

        return gatewayProtocolConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTypes.GatewayProtocolConfiguration result)
    {
        base.CreateChildren(result);

        result.Mcp ??= McpFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayGatewayProtocolConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayGatewayProtocolConfigurationFactory, InnerGatewayMCPGatewayConfigurationFactory> WithMcp(this InnerGatewayGatewayProtocolConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null)
    {
        parentFactory.McpFactory = new InnerGatewayMCPGatewayConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.McpFactory);
    }

    public static CombinedResult<InnerGatewayGatewayProtocolConfigurationFactory, T1, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1>(this CombinedResult<InnerGatewayGatewayProtocolConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMcp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayProtocolConfigurationFactory, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1>(this CombinedResult<T1, InnerGatewayGatewayProtocolConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMcp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayProtocolConfigurationFactory, T1, T2, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2>(this CombinedResult<InnerGatewayGatewayProtocolConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayProtocolConfigurationFactory, T2, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2>(this CombinedResult<T1, InnerGatewayGatewayProtocolConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayProtocolConfigurationFactory, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2>(this CombinedResult<T1, T2, InnerGatewayGatewayProtocolConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayProtocolConfigurationFactory, T1, T2, T3, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2, T3>(this CombinedResult<InnerGatewayGatewayProtocolConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayProtocolConfigurationFactory, T2, T3, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2, T3>(this CombinedResult<T1, InnerGatewayGatewayProtocolConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayProtocolConfigurationFactory, T3, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayGatewayProtocolConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayGatewayProtocolConfigurationFactory, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayGatewayProtocolConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayProtocolConfigurationFactory, T1, T2, T3, T4, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2, T3, T4>(this CombinedResult<InnerGatewayGatewayProtocolConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayProtocolConfigurationFactory, T2, T3, T4, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayGatewayProtocolConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayProtocolConfigurationFactory, T3, T4, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayGatewayProtocolConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayGatewayProtocolConfigurationFactory, T4, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayGatewayProtocolConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayGatewayProtocolConfigurationFactory, InnerGatewayMCPGatewayConfigurationFactory> WithMcp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayGatewayProtocolConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMcp(combinedResult.T5, subFactoryAction).T2);
}
