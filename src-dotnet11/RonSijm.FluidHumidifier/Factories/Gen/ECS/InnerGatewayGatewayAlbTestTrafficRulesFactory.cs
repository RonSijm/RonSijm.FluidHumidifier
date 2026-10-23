// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerGatewayGatewayAlbTestTrafficRulesFactory(Action<Humidifier.ECS.GatewayTypes.GatewayAlbTestTrafficRules> factoryAction = null) : SubResourceFactory<Humidifier.ECS.GatewayTypes.GatewayAlbTestTrafficRules>
{

    internal InnerGatewayGatewayTestTrafficHeaderFactory HeaderFactory { get; set; }

    protected override Humidifier.ECS.GatewayTypes.GatewayAlbTestTrafficRules Create()
    {
        var gatewayAlbTestTrafficRulesResult = CreateGatewayAlbTestTrafficRules();
        factoryAction?.Invoke(gatewayAlbTestTrafficRulesResult);

        return gatewayAlbTestTrafficRulesResult;
    }

    private Humidifier.ECS.GatewayTypes.GatewayAlbTestTrafficRules CreateGatewayAlbTestTrafficRules()
    {
        var gatewayAlbTestTrafficRulesResult = new Humidifier.ECS.GatewayTypes.GatewayAlbTestTrafficRules();

        return gatewayAlbTestTrafficRulesResult;
    }
    public override void CreateChildren(Humidifier.ECS.GatewayTypes.GatewayAlbTestTrafficRules result)
    {
        base.CreateChildren(result);

        result.Header ??= HeaderFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayGatewayAlbTestTrafficRulesFactoryExtensions
{
    public static CombinedResult<InnerGatewayGatewayAlbTestTrafficRulesFactory, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader(this InnerGatewayGatewayAlbTestTrafficRulesFactory parentFactory, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null)
    {
        parentFactory.HeaderFactory = new InnerGatewayGatewayTestTrafficHeaderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HeaderFactory);
    }

    public static CombinedResult<InnerGatewayGatewayAlbTestTrafficRulesFactory, T1, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1>(this CombinedResult<InnerGatewayGatewayAlbTestTrafficRulesFactory, T1> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, WithHeader(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayAlbTestTrafficRulesFactory, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1>(this CombinedResult<T1, InnerGatewayGatewayAlbTestTrafficRulesFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, WithHeader(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayAlbTestTrafficRulesFactory, T1, T2, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2>(this CombinedResult<InnerGatewayGatewayAlbTestTrafficRulesFactory, T1, T2> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayAlbTestTrafficRulesFactory, T2, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2>(this CombinedResult<T1, InnerGatewayGatewayAlbTestTrafficRulesFactory, T2> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayAlbTestTrafficRulesFactory, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2>(this CombinedResult<T1, T2, InnerGatewayGatewayAlbTestTrafficRulesFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayAlbTestTrafficRulesFactory, T1, T2, T3, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2, T3>(this CombinedResult<InnerGatewayGatewayAlbTestTrafficRulesFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayAlbTestTrafficRulesFactory, T2, T3, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2, T3>(this CombinedResult<T1, InnerGatewayGatewayAlbTestTrafficRulesFactory, T2, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayAlbTestTrafficRulesFactory, T3, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayGatewayAlbTestTrafficRulesFactory, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayGatewayAlbTestTrafficRulesFactory, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayGatewayAlbTestTrafficRulesFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayAlbTestTrafficRulesFactory, T1, T2, T3, T4, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2, T3, T4>(this CombinedResult<InnerGatewayGatewayAlbTestTrafficRulesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayAlbTestTrafficRulesFactory, T2, T3, T4, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayGatewayAlbTestTrafficRulesFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayAlbTestTrafficRulesFactory, T3, T4, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayGatewayAlbTestTrafficRulesFactory, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayGatewayAlbTestTrafficRulesFactory, T4, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayGatewayAlbTestTrafficRulesFactory, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayGatewayAlbTestTrafficRulesFactory, InnerGatewayGatewayTestTrafficHeaderFactory> WithHeader<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayGatewayAlbTestTrafficRulesFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeader(combinedResult.T5, subFactoryAction).T2);
}
