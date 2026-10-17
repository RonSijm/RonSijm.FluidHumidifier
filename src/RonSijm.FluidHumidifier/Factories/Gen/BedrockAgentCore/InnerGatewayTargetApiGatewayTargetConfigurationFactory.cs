// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetApiGatewayTargetConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayTargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayTargetConfiguration>
{

    internal InnerGatewayTargetApiGatewayToolConfigurationFactory ApiGatewayToolConfigurationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayTargetConfiguration Create()
    {
        var apiGatewayTargetConfigurationResult = CreateApiGatewayTargetConfiguration();
        factoryAction?.Invoke(apiGatewayTargetConfigurationResult);

        return apiGatewayTargetConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayTargetConfiguration CreateApiGatewayTargetConfiguration()
    {
        var apiGatewayTargetConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayTargetConfiguration();

        return apiGatewayTargetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayTargetConfiguration result)
    {
        base.CreateChildren(result);

        result.ApiGatewayToolConfiguration ??= ApiGatewayToolConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetApiGatewayTargetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetApiGatewayTargetConfigurationFactory, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration(this InnerGatewayTargetApiGatewayTargetConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null)
    {
        parentFactory.ApiGatewayToolConfigurationFactory = new InnerGatewayTargetApiGatewayToolConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApiGatewayToolConfigurationFactory);
    }

    public static CombinedResult<InnerGatewayTargetApiGatewayTargetConfigurationFactory, T1, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1>(this CombinedResult<InnerGatewayTargetApiGatewayTargetConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetApiGatewayTargetConfigurationFactory, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1>(this CombinedResult<T1, InnerGatewayTargetApiGatewayTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetApiGatewayTargetConfigurationFactory, T1, T2, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2>(this CombinedResult<InnerGatewayTargetApiGatewayTargetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T2, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2>(this CombinedResult<T1, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetApiGatewayTargetConfigurationFactory, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetApiGatewayTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetApiGatewayTargetConfigurationFactory, T1, T2, T3, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2, T3>(this CombinedResult<InnerGatewayTargetApiGatewayTargetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T2, T3, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T3, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetApiGatewayTargetConfigurationFactory, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetApiGatewayTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetApiGatewayTargetConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetApiGatewayTargetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T2, T3, T4, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T3, T4, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T4, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetApiGatewayTargetConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetApiGatewayTargetConfigurationFactory, InnerGatewayTargetApiGatewayToolConfigurationFactory> WithApiGatewayToolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetApiGatewayTargetConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayToolConfiguration(combinedResult.T5, subFactoryAction).T2);
}
