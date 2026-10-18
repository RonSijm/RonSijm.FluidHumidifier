// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetHttpApiSchemaConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration>
{

    internal InnerGatewayTargetApiSchemaConfigurationFactory SourceFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration Create()
    {
        var httpApiSchemaConfigurationResult = CreateHttpApiSchemaConfiguration();
        factoryAction?.Invoke(httpApiSchemaConfigurationResult);

        return httpApiSchemaConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration CreateHttpApiSchemaConfiguration()
    {
        var httpApiSchemaConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration();

        return httpApiSchemaConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetHttpApiSchemaConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetHttpApiSchemaConfigurationFactory, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource(this InnerGatewayTargetHttpApiSchemaConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerGatewayTargetApiSchemaConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<InnerGatewayTargetHttpApiSchemaConfigurationFactory, T1, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1>(this CombinedResult<InnerGatewayTargetHttpApiSchemaConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetHttpApiSchemaConfigurationFactory, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1>(this CombinedResult<T1, InnerGatewayTargetHttpApiSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetHttpApiSchemaConfigurationFactory, T1, T2, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2>(this CombinedResult<InnerGatewayTargetHttpApiSchemaConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T2, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2>(this CombinedResult<T1, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetHttpApiSchemaConfigurationFactory, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetHttpApiSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetHttpApiSchemaConfigurationFactory, T1, T2, T3, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2, T3>(this CombinedResult<InnerGatewayTargetHttpApiSchemaConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T2, T3, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T3, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetHttpApiSchemaConfigurationFactory, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetHttpApiSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetHttpApiSchemaConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetHttpApiSchemaConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T2, T3, T4, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T3, T4, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T4, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetHttpApiSchemaConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetHttpApiSchemaConfigurationFactory, InnerGatewayTargetApiSchemaConfigurationFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetHttpApiSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
