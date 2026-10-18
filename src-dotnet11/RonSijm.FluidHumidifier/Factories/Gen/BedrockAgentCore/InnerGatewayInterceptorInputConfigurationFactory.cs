// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayInterceptorInputConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorInputConfiguration>
{

    internal InnerGatewayInterceptorPayloadFilterFactory PayloadFilterFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTypes.InterceptorInputConfiguration Create()
    {
        var interceptorInputConfigurationResult = CreateInterceptorInputConfiguration();
        factoryAction?.Invoke(interceptorInputConfigurationResult);

        return interceptorInputConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.InterceptorInputConfiguration CreateInterceptorInputConfiguration()
    {
        var interceptorInputConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTypes.InterceptorInputConfiguration();

        return interceptorInputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTypes.InterceptorInputConfiguration result)
    {
        base.CreateChildren(result);

        result.PayloadFilter ??= PayloadFilterFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayInterceptorInputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayInterceptorInputConfigurationFactory, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter(this InnerGatewayInterceptorInputConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null)
    {
        parentFactory.PayloadFilterFactory = new InnerGatewayInterceptorPayloadFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PayloadFilterFactory);
    }

    public static CombinedResult<InnerGatewayInterceptorInputConfigurationFactory, T1, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1>(this CombinedResult<InnerGatewayInterceptorInputConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithPayloadFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayInterceptorInputConfigurationFactory, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1>(this CombinedResult<T1, InnerGatewayInterceptorInputConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithPayloadFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayInterceptorInputConfigurationFactory, T1, T2, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2>(this CombinedResult<InnerGatewayInterceptorInputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayInterceptorInputConfigurationFactory, T2, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2>(this CombinedResult<T1, InnerGatewayInterceptorInputConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayInterceptorInputConfigurationFactory, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2>(this CombinedResult<T1, T2, InnerGatewayInterceptorInputConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayInterceptorInputConfigurationFactory, T1, T2, T3, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2, T3>(this CombinedResult<InnerGatewayInterceptorInputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayInterceptorInputConfigurationFactory, T2, T3, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2, T3>(this CombinedResult<T1, InnerGatewayInterceptorInputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayInterceptorInputConfigurationFactory, T3, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayInterceptorInputConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayInterceptorInputConfigurationFactory, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayInterceptorInputConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayInterceptorInputConfigurationFactory, T1, T2, T3, T4, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2, T3, T4>(this CombinedResult<InnerGatewayInterceptorInputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayInterceptorInputConfigurationFactory, T2, T3, T4, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayInterceptorInputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayInterceptorInputConfigurationFactory, T3, T4, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayInterceptorInputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayInterceptorInputConfigurationFactory, T4, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayInterceptorInputConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayInterceptorInputConfigurationFactory, InnerGatewayInterceptorPayloadFilterFactory> WithPayloadFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayInterceptorInputConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPayloadFilter(combinedResult.T5, subFactoryAction).T2);
}
