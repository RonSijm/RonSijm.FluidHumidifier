// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessAgentCoreGatewayConfigFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreGatewayConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreGatewayConfig>
{

    internal InnerHarnessHarnessGatewayOutboundAuthFactory OutboundAuthFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreGatewayConfig Create()
    {
        var harnessAgentCoreGatewayConfigResult = CreateHarnessAgentCoreGatewayConfig();
        factoryAction?.Invoke(harnessAgentCoreGatewayConfigResult);

        return harnessAgentCoreGatewayConfigResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreGatewayConfig CreateHarnessAgentCoreGatewayConfig()
    {
        var harnessAgentCoreGatewayConfigResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreGatewayConfig();

        return harnessAgentCoreGatewayConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreGatewayConfig result)
    {
        base.CreateChildren(result);

        result.OutboundAuth ??= OutboundAuthFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessAgentCoreGatewayConfigFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessAgentCoreGatewayConfigFactory, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth(this InnerHarnessHarnessAgentCoreGatewayConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null)
    {
        parentFactory.OutboundAuthFactory = new InnerHarnessHarnessGatewayOutboundAuthFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutboundAuthFactory);
    }

    public static CombinedResult<InnerHarnessHarnessAgentCoreGatewayConfigFactory, T1, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1>(this CombinedResult<InnerHarnessHarnessAgentCoreGatewayConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutboundAuth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAgentCoreGatewayConfigFactory, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1>(this CombinedResult<T1, InnerHarnessHarnessAgentCoreGatewayConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutboundAuth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessAgentCoreGatewayConfigFactory, T1, T2, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2>(this CombinedResult<InnerHarnessHarnessAgentCoreGatewayConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T2, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessAgentCoreGatewayConfigFactory, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessAgentCoreGatewayConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessAgentCoreGatewayConfigFactory, T1, T2, T3, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessAgentCoreGatewayConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T2, T3, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T3, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessAgentCoreGatewayConfigFactory, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessAgentCoreGatewayConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessAgentCoreGatewayConfigFactory, T1, T2, T3, T4, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessAgentCoreGatewayConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T2, T3, T4, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T3, T4, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T4, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessAgentCoreGatewayConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessAgentCoreGatewayConfigFactory, InnerHarnessHarnessGatewayOutboundAuthFactory> WithOutboundAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessAgentCoreGatewayConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundAuth(combinedResult.T5, subFactoryAction).T2);
}
