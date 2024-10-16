// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NetworkAclEntryFactory(string resourceName = null, Action<Humidifier.EC2.NetworkAclEntry> factoryAction = null) : ResourceFactory<Humidifier.EC2.NetworkAclEntry>(resourceName)
{

    internal InnerNetworkAclEntryPortRangeFactory PortRangeFactory { get; set; }

    internal InnerNetworkAclEntryIcmpFactory IcmpFactory { get; set; }

    protected override Humidifier.EC2.NetworkAclEntry Create()
    {
        var networkAclEntryResult = CreateNetworkAclEntry();
        factoryAction?.Invoke(networkAclEntryResult);

        return networkAclEntryResult;
    }

    private Humidifier.EC2.NetworkAclEntry CreateNetworkAclEntry()
    {
        var networkAclEntryResult = new Humidifier.EC2.NetworkAclEntry
        {
            GivenName = InputResourceName,
        };

        return networkAclEntryResult;
    }
    public override void CreateChildren(Humidifier.EC2.NetworkAclEntry result)
    {
        base.CreateChildren(result);

        result.PortRange ??= PortRangeFactory?.Build();
        result.Icmp ??= IcmpFactory?.Build();
    }

} // End Of Class

public static class NetworkAclEntryFactoryExtensions
{
    public static CombinedResult<NetworkAclEntryFactory, InnerNetworkAclEntryPortRangeFactory> WithPortRange(this NetworkAclEntryFactory parentFactory, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null)
    {
        parentFactory.PortRangeFactory = new InnerNetworkAclEntryPortRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PortRangeFactory);
    }

    public static CombinedResult<NetworkAclEntryFactory, InnerNetworkAclEntryIcmpFactory> WithIcmp(this NetworkAclEntryFactory parentFactory, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null)
    {
        parentFactory.IcmpFactory = new InnerNetworkAclEntryIcmpFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IcmpFactory);
    }

    public static CombinedResult<NetworkAclEntryFactory, T1, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1>(this CombinedResult<NetworkAclEntryFactory, T1> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAclEntryFactory, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1>(this CombinedResult<T1, NetworkAclEntryFactory> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkAclEntryFactory, T1, T2, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2>(this CombinedResult<NetworkAclEntryFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAclEntryFactory, T2, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2>(this CombinedResult<T1, NetworkAclEntryFactory, T2> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkAclEntryFactory, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2>(this CombinedResult<T1, T2, NetworkAclEntryFactory> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkAclEntryFactory, T1, T2, T3, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<NetworkAclEntryFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAclEntryFactory, T2, T3, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<T1, NetworkAclEntryFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkAclEntryFactory, T3, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<T1, T2, NetworkAclEntryFactory, T3> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkAclEntryFactory, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkAclEntryFactory> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkAclEntryFactory, T1, T2, T3, T4, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<NetworkAclEntryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAclEntryFactory, T2, T3, T4, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, NetworkAclEntryFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkAclEntryFactory, T3, T4, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkAclEntryFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkAclEntryFactory, T4, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkAclEntryFactory, T4> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkAclEntryFactory, InnerNetworkAclEntryPortRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkAclEntryFactory> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T5, subFactoryAction));
    public static CombinedResult<NetworkAclEntryFactory, T1, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1>(this CombinedResult<NetworkAclEntryFactory, T1> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcmp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAclEntryFactory, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1>(this CombinedResult<T1, NetworkAclEntryFactory> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcmp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkAclEntryFactory, T1, T2, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2>(this CombinedResult<NetworkAclEntryFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAclEntryFactory, T2, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2>(this CombinedResult<T1, NetworkAclEntryFactory, T2> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkAclEntryFactory, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2>(this CombinedResult<T1, T2, NetworkAclEntryFactory> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkAclEntryFactory, T1, T2, T3, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2, T3>(this CombinedResult<NetworkAclEntryFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAclEntryFactory, T2, T3, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2, T3>(this CombinedResult<T1, NetworkAclEntryFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkAclEntryFactory, T3, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2, T3>(this CombinedResult<T1, T2, NetworkAclEntryFactory, T3> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkAclEntryFactory, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkAclEntryFactory> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkAclEntryFactory, T1, T2, T3, T4, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2, T3, T4>(this CombinedResult<NetworkAclEntryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAclEntryFactory, T2, T3, T4, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2, T3, T4>(this CombinedResult<T1, NetworkAclEntryFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkAclEntryFactory, T3, T4, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkAclEntryFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkAclEntryFactory, T4, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkAclEntryFactory, T4> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkAclEntryFactory, InnerNetworkAclEntryIcmpFactory> WithIcmp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkAclEntryFactory> combinedResult, Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcmp(combinedResult.T5, subFactoryAction));
}
