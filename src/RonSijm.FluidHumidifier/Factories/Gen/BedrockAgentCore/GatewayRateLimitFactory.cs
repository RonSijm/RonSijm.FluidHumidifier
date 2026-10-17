// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class GatewayRateLimitFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.GatewayRateLimit> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.GatewayRateLimit>(resourceName)
{

    internal List<InnerGatewayRateLimitLimitEntryFactory> EntriesFactories { get; set; } = [];

    protected override Humidifier.BedrockAgentCore.GatewayRateLimit Create()
    {
        var gatewayRateLimitResult = CreateGatewayRateLimit();
        factoryAction?.Invoke(gatewayRateLimitResult);

        return gatewayRateLimitResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRateLimit CreateGatewayRateLimit()
    {
        var gatewayRateLimitResult = new Humidifier.BedrockAgentCore.GatewayRateLimit
        {
            GivenName = InputResourceName,
        };

        return gatewayRateLimitResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayRateLimit result)
    {
        base.CreateChildren(result);

        result.Entries = EntriesFactories.Any() ? EntriesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class GatewayRateLimitFactoryExtensions
{
    public static CombinedResult<GatewayRateLimitFactory, InnerGatewayRateLimitLimitEntryFactory> WithEntries(this GatewayRateLimitFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null)
    {
        var factory = new InnerGatewayRateLimitLimitEntryFactory(subFactoryAction);
        parentFactory.EntriesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GatewayRateLimitFactory, T1, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1>(this CombinedResult<GatewayRateLimitFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntries(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRateLimitFactory, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1>(this CombinedResult<T1, GatewayRateLimitFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntries(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<GatewayRateLimitFactory, T1, T2, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2>(this CombinedResult<GatewayRateLimitFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRateLimitFactory, T2, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2>(this CombinedResult<T1, GatewayRateLimitFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayRateLimitFactory, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2>(this CombinedResult<T1, T2, GatewayRateLimitFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<GatewayRateLimitFactory, T1, T2, T3, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2, T3>(this CombinedResult<GatewayRateLimitFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRateLimitFactory, T2, T3, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2, T3>(this CombinedResult<T1, GatewayRateLimitFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayRateLimitFactory, T3, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2, T3>(this CombinedResult<T1, T2, GatewayRateLimitFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GatewayRateLimitFactory, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2, T3>(this CombinedResult<T1, T2, T3, GatewayRateLimitFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<GatewayRateLimitFactory, T1, T2, T3, T4, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2, T3, T4>(this CombinedResult<GatewayRateLimitFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRateLimitFactory, T2, T3, T4, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2, T3, T4>(this CombinedResult<T1, GatewayRateLimitFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayRateLimitFactory, T3, T4, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2, T3, T4>(this CombinedResult<T1, T2, GatewayRateLimitFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GatewayRateLimitFactory, T4, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GatewayRateLimitFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, GatewayRateLimitFactory, InnerGatewayRateLimitLimitEntryFactory> WithEntries<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GatewayRateLimitFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T5, subFactoryAction).T2);
}
