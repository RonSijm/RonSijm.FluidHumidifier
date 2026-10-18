// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayConnectPeerFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayConnectPeer> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayConnectPeer>(resourceName)
{

    internal InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory ConnectPeerConfigurationFactory { get; set; }

    protected override Humidifier.EC2.TransitGatewayConnectPeer Create()
    {
        var transitGatewayConnectPeerResult = CreateTransitGatewayConnectPeer();
        factoryAction?.Invoke(transitGatewayConnectPeerResult);

        return transitGatewayConnectPeerResult;
    }

    private Humidifier.EC2.TransitGatewayConnectPeer CreateTransitGatewayConnectPeer()
    {
        var transitGatewayConnectPeerResult = new Humidifier.EC2.TransitGatewayConnectPeer
        {
            GivenName = InputResourceName,
        };

        return transitGatewayConnectPeerResult;
    }
    public override void CreateChildren(Humidifier.EC2.TransitGatewayConnectPeer result)
    {
        base.CreateChildren(result);

        result.ConnectPeerConfiguration ??= ConnectPeerConfigurationFactory?.Build();
    }

} // End Of Class

public static class TransitGatewayConnectPeerFactoryExtensions
{
    public static CombinedResult<TransitGatewayConnectPeerFactory, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration(this TransitGatewayConnectPeerFactory parentFactory, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null)
    {
        parentFactory.ConnectPeerConfigurationFactory = new InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectPeerConfigurationFactory);
    }

    public static CombinedResult<TransitGatewayConnectPeerFactory, T1, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1>(this CombinedResult<TransitGatewayConnectPeerFactory, T1> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayConnectPeerFactory, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1>(this CombinedResult<T1, TransitGatewayConnectPeerFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TransitGatewayConnectPeerFactory, T1, T2, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2>(this CombinedResult<TransitGatewayConnectPeerFactory, T1, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayConnectPeerFactory, T2, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2>(this CombinedResult<T1, TransitGatewayConnectPeerFactory, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitGatewayConnectPeerFactory, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2>(this CombinedResult<T1, T2, TransitGatewayConnectPeerFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TransitGatewayConnectPeerFactory, T1, T2, T3, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2, T3>(this CombinedResult<TransitGatewayConnectPeerFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayConnectPeerFactory, T2, T3, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2, T3>(this CombinedResult<T1, TransitGatewayConnectPeerFactory, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitGatewayConnectPeerFactory, T3, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, TransitGatewayConnectPeerFactory, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TransitGatewayConnectPeerFactory, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransitGatewayConnectPeerFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TransitGatewayConnectPeerFactory, T1, T2, T3, T4, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2, T3, T4>(this CombinedResult<TransitGatewayConnectPeerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayConnectPeerFactory, T2, T3, T4, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, TransitGatewayConnectPeerFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitGatewayConnectPeerFactory, T3, T4, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransitGatewayConnectPeerFactory, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TransitGatewayConnectPeerFactory, T4, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransitGatewayConnectPeerFactory, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TransitGatewayConnectPeerFactory, InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory> WithConnectPeerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransitGatewayConnectPeerFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectPeerConfiguration(combinedResult.T5, subFactoryAction).T2);
}
