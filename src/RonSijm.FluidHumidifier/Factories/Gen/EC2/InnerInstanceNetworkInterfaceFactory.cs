// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceNetworkInterfaceFactory(Action<Humidifier.EC2.InstanceTypes.NetworkInterface> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.NetworkInterface>
{

    internal List<InnerInstancePrivateIpAddressSpecificationFactory> PrivateIpAddressesFactories { get; set; } = [];

    internal List<InnerInstanceInstanceIpv6AddressFactory> Ipv6AddressesFactories { get; set; } = [];

    protected override Humidifier.EC2.InstanceTypes.NetworkInterface Create()
    {
        var networkInterfaceResult = CreateNetworkInterface();
        factoryAction?.Invoke(networkInterfaceResult);

        return networkInterfaceResult;
    }

    private Humidifier.EC2.InstanceTypes.NetworkInterface CreateNetworkInterface()
    {
        var networkInterfaceResult = new Humidifier.EC2.InstanceTypes.NetworkInterface();

        return networkInterfaceResult;
    }
    public override void CreateChildren(Humidifier.EC2.InstanceTypes.NetworkInterface result)
    {
        base.CreateChildren(result);

        result.PrivateIpAddresses = PrivateIpAddressesFactories.Any() ? PrivateIpAddressesFactories.Select(x => x.Build()).ToList() : null;
        result.Ipv6Addresses = Ipv6AddressesFactories.Any() ? Ipv6AddressesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerInstanceNetworkInterfaceFactoryExtensions
{
    public static CombinedResult<InnerInstanceNetworkInterfaceFactory, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses(this InnerInstanceNetworkInterfaceFactory parentFactory, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null)
    {
        var factory = new InnerInstancePrivateIpAddressSpecificationFactory(subFactoryAction);
        parentFactory.PrivateIpAddressesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerInstanceNetworkInterfaceFactory, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses(this InnerInstanceNetworkInterfaceFactory parentFactory, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null)
    {
        var factory = new InnerInstanceInstanceIpv6AddressFactory(subFactoryAction);
        parentFactory.Ipv6AddressesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1>(this CombinedResult<InnerInstanceNetworkInterfaceFactory, T1> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1>(this CombinedResult<T1, InnerInstanceNetworkInterfaceFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2>(this CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2>(this CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2>(this CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2, T3, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2, T3>(this CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2, T3, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2, T3>(this CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory, T3, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceNetworkInterfaceFactory, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceNetworkInterfaceFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2, T3, T4, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2, T3, T4>(this CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2, T3, T4, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory, T3, T4, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceNetworkInterfaceFactory, T4, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceNetworkInterfaceFactory, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceNetworkInterfaceFactory, InnerInstancePrivateIpAddressSpecificationFactory> WithPrivateIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceNetworkInterfaceFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateIpAddresses(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1>(this CombinedResult<InnerInstanceNetworkInterfaceFactory, T1> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1>(this CombinedResult<T1, InnerInstanceNetworkInterfaceFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2>(this CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2>(this CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2>(this CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2, T3, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2, T3>(this CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2, T3, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2, T3>(this CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory, T3, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceNetworkInterfaceFactory, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceNetworkInterfaceFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2, T3, T4, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2, T3, T4>(this CombinedResult<InnerInstanceNetworkInterfaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2, T3, T4, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceNetworkInterfaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory, T3, T4, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceNetworkInterfaceFactory, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceNetworkInterfaceFactory, T4, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceNetworkInterfaceFactory, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceNetworkInterfaceFactory, InnerInstanceInstanceIpv6AddressFactory> WithIpv6Addresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceNetworkInterfaceFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpv6Addresses(combinedResult.T5, subFactoryAction));
}
