// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayMulticastDomainFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayMulticastDomain> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayMulticastDomain>(resourceName)
{

    internal InnerTransitGatewayMulticastDomainOptionsFactory OptionsFactory { get; set; }

    protected override Humidifier.EC2.TransitGatewayMulticastDomain Create()
    {
        var transitGatewayMulticastDomainResult = CreateTransitGatewayMulticastDomain();
        factoryAction?.Invoke(transitGatewayMulticastDomainResult);

        return transitGatewayMulticastDomainResult;
    }

    private Humidifier.EC2.TransitGatewayMulticastDomain CreateTransitGatewayMulticastDomain()
    {
        var transitGatewayMulticastDomainResult = new Humidifier.EC2.TransitGatewayMulticastDomain
        {
            GivenName = InputResourceName,
        };

        return transitGatewayMulticastDomainResult;
    }
    public override void CreateChildren(Humidifier.EC2.TransitGatewayMulticastDomain result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
    }

} // End Of Class

public static class TransitGatewayMulticastDomainFactoryExtensions
{
    public static CombinedResult<TransitGatewayMulticastDomainFactory, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions(this TransitGatewayMulticastDomainFactory parentFactory, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerTransitGatewayMulticastDomainOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<TransitGatewayMulticastDomainFactory, T1, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1>(this CombinedResult<TransitGatewayMulticastDomainFactory, T1> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayMulticastDomainFactory, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1>(this CombinedResult<T1, TransitGatewayMulticastDomainFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TransitGatewayMulticastDomainFactory, T1, T2, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2>(this CombinedResult<TransitGatewayMulticastDomainFactory, T1, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayMulticastDomainFactory, T2, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, TransitGatewayMulticastDomainFactory, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayMulticastDomainFactory, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, TransitGatewayMulticastDomainFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TransitGatewayMulticastDomainFactory, T1, T2, T3, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<TransitGatewayMulticastDomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayMulticastDomainFactory, T2, T3, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, TransitGatewayMulticastDomainFactory, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayMulticastDomainFactory, T3, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, TransitGatewayMulticastDomainFactory, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransitGatewayMulticastDomainFactory, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransitGatewayMulticastDomainFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TransitGatewayMulticastDomainFactory, T1, T2, T3, T4, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<TransitGatewayMulticastDomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayMulticastDomainFactory, T2, T3, T4, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, TransitGatewayMulticastDomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayMulticastDomainFactory, T3, T4, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransitGatewayMulticastDomainFactory, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransitGatewayMulticastDomainFactory, T4, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransitGatewayMulticastDomainFactory, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TransitGatewayMulticastDomainFactory, InnerTransitGatewayMulticastDomainOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransitGatewayMulticastDomainFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction));
}
