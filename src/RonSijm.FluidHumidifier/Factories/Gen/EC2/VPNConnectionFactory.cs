// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPNConnectionFactory(string resourceName = null, Action<Humidifier.EC2.VPNConnection> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPNConnection>(resourceName)
{

    internal List<InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> VpnTunnelOptionsSpecificationsFactories { get; set; } = [];

    protected override Humidifier.EC2.VPNConnection Create()
    {
        var vPNConnectionResult = CreateVPNConnection();
        factoryAction?.Invoke(vPNConnectionResult);

        return vPNConnectionResult;
    }

    private Humidifier.EC2.VPNConnection CreateVPNConnection()
    {
        var vPNConnectionResult = new Humidifier.EC2.VPNConnection
        {
            GivenName = InputResourceName,
        };

        return vPNConnectionResult;
    }
    public override void CreateChildren(Humidifier.EC2.VPNConnection result)
    {
        base.CreateChildren(result);

        result.VpnTunnelOptionsSpecifications = VpnTunnelOptionsSpecificationsFactories.Any() ? VpnTunnelOptionsSpecificationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class VPNConnectionFactoryExtensions
{
    public static CombinedResult<VPNConnectionFactory, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications(this VPNConnectionFactory parentFactory, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null)
    {
        var factory = new InnerVPNConnectionVpnTunnelOptionsSpecificationFactory(subFactoryAction);
        parentFactory.VpnTunnelOptionsSpecificationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<VPNConnectionFactory, T1, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1>(this CombinedResult<VPNConnectionFactory, T1> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VPNConnectionFactory, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1>(this CombinedResult<T1, VPNConnectionFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VPNConnectionFactory, T1, T2, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2>(this CombinedResult<VPNConnectionFactory, T1, T2> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VPNConnectionFactory, T2, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2>(this CombinedResult<T1, VPNConnectionFactory, T2> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VPNConnectionFactory, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2>(this CombinedResult<T1, T2, VPNConnectionFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VPNConnectionFactory, T1, T2, T3, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2, T3>(this CombinedResult<VPNConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VPNConnectionFactory, T2, T3, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2, T3>(this CombinedResult<T1, VPNConnectionFactory, T2, T3> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VPNConnectionFactory, T3, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, VPNConnectionFactory, T3> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VPNConnectionFactory, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, VPNConnectionFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VPNConnectionFactory, T1, T2, T3, T4, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2, T3, T4>(this CombinedResult<VPNConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VPNConnectionFactory, T2, T3, T4, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, VPNConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VPNConnectionFactory, T3, T4, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, VPNConnectionFactory, T3, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VPNConnectionFactory, T4, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VPNConnectionFactory, T4> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VPNConnectionFactory, InnerVPNConnectionVpnTunnelOptionsSpecificationFactory> WithVpnTunnelOptionsSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VPNConnectionFactory> combinedResult, Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpnTunnelOptionsSpecifications(combinedResult.T5, subFactoryAction));
}
