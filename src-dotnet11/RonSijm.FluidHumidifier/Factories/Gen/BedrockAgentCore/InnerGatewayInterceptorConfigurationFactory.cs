// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayInterceptorConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorConfiguration>
{

    internal InnerGatewayLambdaInterceptorConfigurationFactory LambdaFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTypes.InterceptorConfiguration Create()
    {
        var interceptorConfigurationResult = CreateInterceptorConfiguration();
        factoryAction?.Invoke(interceptorConfigurationResult);

        return interceptorConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.InterceptorConfiguration CreateInterceptorConfiguration()
    {
        var interceptorConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTypes.InterceptorConfiguration();

        return interceptorConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTypes.InterceptorConfiguration result)
    {
        base.CreateChildren(result);

        result.Lambda ??= LambdaFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayInterceptorConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayInterceptorConfigurationFactory, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda(this InnerGatewayInterceptorConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null)
    {
        parentFactory.LambdaFactory = new InnerGatewayLambdaInterceptorConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaFactory);
    }

    public static CombinedResult<InnerGatewayInterceptorConfigurationFactory, T1, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1>(this CombinedResult<InnerGatewayInterceptorConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayInterceptorConfigurationFactory, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1>(this CombinedResult<T1, InnerGatewayInterceptorConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayInterceptorConfigurationFactory, T1, T2, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2>(this CombinedResult<InnerGatewayInterceptorConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayInterceptorConfigurationFactory, T2, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2>(this CombinedResult<T1, InnerGatewayInterceptorConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayInterceptorConfigurationFactory, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2>(this CombinedResult<T1, T2, InnerGatewayInterceptorConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayInterceptorConfigurationFactory, T1, T2, T3, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2, T3>(this CombinedResult<InnerGatewayInterceptorConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayInterceptorConfigurationFactory, T2, T3, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2, T3>(this CombinedResult<T1, InnerGatewayInterceptorConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayInterceptorConfigurationFactory, T3, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayInterceptorConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayInterceptorConfigurationFactory, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayInterceptorConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayInterceptorConfigurationFactory, T1, T2, T3, T4, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<InnerGatewayInterceptorConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayInterceptorConfigurationFactory, T2, T3, T4, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayInterceptorConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayInterceptorConfigurationFactory, T3, T4, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayInterceptorConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayInterceptorConfigurationFactory, T4, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayInterceptorConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayInterceptorConfigurationFactory, InnerGatewayLambdaInterceptorConfigurationFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayInterceptorConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T5, subFactoryAction).T2);
}
