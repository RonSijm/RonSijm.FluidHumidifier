// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayConnectFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayConnect> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayConnect>(resourceName)
{

    internal InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory OptionsFactory { get; set; }

    protected override Humidifier.EC2.TransitGatewayConnect Create()
    {
        var transitGatewayConnectResult = CreateTransitGatewayConnect();
        factoryAction?.Invoke(transitGatewayConnectResult);

        return transitGatewayConnectResult;
    }

    private Humidifier.EC2.TransitGatewayConnect CreateTransitGatewayConnect()
    {
        var transitGatewayConnectResult = new Humidifier.EC2.TransitGatewayConnect
        {
            GivenName = InputResourceName,
        };

        return transitGatewayConnectResult;
    }
    public override void CreateChildren(Humidifier.EC2.TransitGatewayConnect result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
    }

} // End Of Class

public static class TransitGatewayConnectFactoryExtensions
{
    public static CombinedResult<TransitGatewayConnectFactory, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions(this TransitGatewayConnectFactory parentFactory, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<TransitGatewayConnectFactory, T1, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1>(this CombinedResult<TransitGatewayConnectFactory, T1> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayConnectFactory, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1>(this CombinedResult<T1, TransitGatewayConnectFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TransitGatewayConnectFactory, T1, T2, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2>(this CombinedResult<TransitGatewayConnectFactory, T1, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayConnectFactory, T2, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, TransitGatewayConnectFactory, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayConnectFactory, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, TransitGatewayConnectFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TransitGatewayConnectFactory, T1, T2, T3, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<TransitGatewayConnectFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayConnectFactory, T2, T3, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, TransitGatewayConnectFactory, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayConnectFactory, T3, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, TransitGatewayConnectFactory, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransitGatewayConnectFactory, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransitGatewayConnectFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TransitGatewayConnectFactory, T1, T2, T3, T4, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<TransitGatewayConnectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayConnectFactory, T2, T3, T4, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, TransitGatewayConnectFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayConnectFactory, T3, T4, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransitGatewayConnectFactory, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransitGatewayConnectFactory, T4, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransitGatewayConnectFactory, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TransitGatewayConnectFactory, InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransitGatewayConnectFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction));
}
