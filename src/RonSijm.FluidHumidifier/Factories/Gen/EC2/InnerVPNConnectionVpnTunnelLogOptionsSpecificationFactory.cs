// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory(Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification>
{

    internal InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory CloudwatchLogOptionsFactory { get; set; }

    protected override Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification Create()
    {
        var vpnTunnelLogOptionsSpecificationResult = CreateVpnTunnelLogOptionsSpecification();
        factoryAction?.Invoke(vpnTunnelLogOptionsSpecificationResult);

        return vpnTunnelLogOptionsSpecificationResult;
    }

    private Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification CreateVpnTunnelLogOptionsSpecification()
    {
        var vpnTunnelLogOptionsSpecificationResult = new Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification();

        return vpnTunnelLogOptionsSpecificationResult;
    }
    public override void CreateChildren(Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification result)
    {
        base.CreateChildren(result);

        result.CloudwatchLogOptions ??= CloudwatchLogOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactoryExtensions
{
    public static CombinedResult<InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions(this InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory parentFactory, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null)
    {
        parentFactory.CloudwatchLogOptionsFactory = new InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudwatchLogOptionsFactory);
    }

    public static CombinedResult<InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T1, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1>(this CombinedResult<InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T1> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1>(this CombinedResult<T1, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T1, T2, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2>(this CombinedResult<InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T2, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2>(this CombinedResult<T1, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T2> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2>(this CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T1, T2, T3, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2, T3>(this CombinedResult<InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T2, T3, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2, T3>(this CombinedResult<T1, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T3, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T3> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T1, T2, T3, T4, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2, T3, T4>(this CombinedResult<InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T2, T3, T4, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T3, T4, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T4, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory, InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory> WithCloudwatchLogOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVPNConnectionVpnTunnelLogOptionsSpecificationFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudwatchLogOptions(combinedResult.T5, subFactoryAction));
}
