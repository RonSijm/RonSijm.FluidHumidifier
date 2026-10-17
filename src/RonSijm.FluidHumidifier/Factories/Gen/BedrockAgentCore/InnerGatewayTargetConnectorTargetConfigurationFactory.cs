// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetConnectorTargetConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorTargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorTargetConfiguration>
{

    internal InnerGatewayTargetConnectorSourceFactory SourceFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorTargetConfiguration Create()
    {
        var connectorTargetConfigurationResult = CreateConnectorTargetConfiguration();
        factoryAction?.Invoke(connectorTargetConfigurationResult);

        return connectorTargetConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorTargetConfiguration CreateConnectorTargetConfiguration()
    {
        var connectorTargetConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorTargetConfiguration();

        return connectorTargetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorTargetConfiguration result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetConnectorTargetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetConnectorTargetConfigurationFactory, InnerGatewayTargetConnectorSourceFactory> WithSource(this InnerGatewayTargetConnectorTargetConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerGatewayTargetConnectorSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<InnerGatewayTargetConnectorTargetConfigurationFactory, T1, InnerGatewayTargetConnectorSourceFactory> WithSource<T1>(this CombinedResult<InnerGatewayTargetConnectorTargetConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetConnectorTargetConfigurationFactory, InnerGatewayTargetConnectorSourceFactory> WithSource<T1>(this CombinedResult<T1, InnerGatewayTargetConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetConnectorTargetConfigurationFactory, T1, T2, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2>(this CombinedResult<InnerGatewayTargetConnectorTargetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetConnectorTargetConfigurationFactory, T2, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, InnerGatewayTargetConnectorTargetConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetConnectorTargetConfigurationFactory, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetConnectorTargetConfigurationFactory, T1, T2, T3, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<InnerGatewayTargetConnectorTargetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetConnectorTargetConfigurationFactory, T2, T3, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetConnectorTargetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetConnectorTargetConfigurationFactory, T3, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetConnectorTargetConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetConnectorTargetConfigurationFactory, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetConnectorTargetConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetConnectorTargetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetConnectorTargetConfigurationFactory, T2, T3, T4, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetConnectorTargetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetConnectorTargetConfigurationFactory, T3, T4, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetConnectorTargetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetConnectorTargetConfigurationFactory, T4, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetConnectorTargetConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetConnectorTargetConfigurationFactory, InnerGatewayTargetConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
