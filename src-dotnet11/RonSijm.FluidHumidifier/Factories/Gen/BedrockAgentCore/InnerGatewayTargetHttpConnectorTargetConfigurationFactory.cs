// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetHttpConnectorTargetConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorTargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorTargetConfiguration>
{

    internal InnerGatewayTargetHttpConnectorSourceFactory SourceFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorTargetConfiguration Create()
    {
        var httpConnectorTargetConfigurationResult = CreateHttpConnectorTargetConfiguration();
        factoryAction?.Invoke(httpConnectorTargetConfigurationResult);

        return httpConnectorTargetConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorTargetConfiguration CreateHttpConnectorTargetConfiguration()
    {
        var httpConnectorTargetConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorTargetConfiguration();

        return httpConnectorTargetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorTargetConfiguration result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetHttpConnectorTargetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetHttpConnectorTargetConfigurationFactory, InnerGatewayTargetHttpConnectorSourceFactory> WithSource(this InnerGatewayTargetHttpConnectorTargetConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerGatewayTargetHttpConnectorSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T1, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1>(this CombinedResult<InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1>(this CombinedResult<T1, InnerGatewayTargetHttpConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T1, T2, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2>(this CombinedResult<InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T2, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetHttpConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T1, T2, T3, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T2, T3, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T3, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetHttpConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T2, T3, T4, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T3, T4, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T4, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetHttpConnectorTargetConfigurationFactory, InnerGatewayTargetHttpConnectorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetHttpConnectorTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
