// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVPNConnectionVpnTunnelOptionsSpecificationFactory(Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification>
{

    internal InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory LogOptionsFactory { get; set; }

    protected override Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification Create()
    {
        var vpnTunnelOptionsSpecificationResult = CreateVpnTunnelOptionsSpecification();
        factoryAction?.Invoke(vpnTunnelOptionsSpecificationResult);

        return vpnTunnelOptionsSpecificationResult;
    }

    private Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification CreateVpnTunnelOptionsSpecification()
    {
        var vpnTunnelOptionsSpecificationResult = new Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification();

        return vpnTunnelOptionsSpecificationResult;
    }
    public override void CreateChildren(Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification result)
    {
        base.CreateChildren(result);

        result.LogOptions ??= LogOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerVPNConnectionVpnTunnelOptionsSpecificationFactoryExtensions
{
    public static CombinedResult<InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions(this InnerVPNConnectionVpnTunnelOptionsSpecificationFactory parentFactory, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null)
    {
        parentFactory.LogOptionsFactory = new InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogOptionsFactory);
    }

    public static CombinedResult<InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T1, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1>(this CombinedResult<InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T1> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1>(this CombinedResult<T1, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T1, T2, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2>(this CombinedResult<InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T2, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2>(this CombinedResult<T1, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T2> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2>(this CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T1, T2, T3, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2, T3>(this CombinedResult<InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T2, T3, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2, T3>(this CombinedResult<T1, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T3, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T3> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T1, T2, T3, T4, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2, T3, T4>(this CombinedResult<InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T2, T3, T4, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T3, T4, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T4, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> WithLogOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogOptions(combinedResult.T5, subFactoryAction));
}
