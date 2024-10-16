// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeServiceDiscoveryFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.ServiceDiscovery> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.ServiceDiscovery>
{

    internal InnerVirtualNodeDnsServiceDiscoveryFactory DNSFactory { get; set; }

    internal InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory AWSCloudMapFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNodeTypes.ServiceDiscovery Create()
    {
        var serviceDiscoveryResult = CreateServiceDiscovery();
        factoryAction?.Invoke(serviceDiscoveryResult);

        return serviceDiscoveryResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.ServiceDiscovery CreateServiceDiscovery()
    {
        var serviceDiscoveryResult = new Humidifier.AppMesh.VirtualNodeTypes.ServiceDiscovery();

        return serviceDiscoveryResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNodeTypes.ServiceDiscovery result)
    {
        base.CreateChildren(result);

        result.DNS ??= DNSFactory?.Build();
        result.AWSCloudMap ??= AWSCloudMapFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualNodeServiceDiscoveryFactoryExtensions
{
    public static CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS(this InnerVirtualNodeServiceDiscoveryFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null)
    {
        parentFactory.DNSFactory = new InnerVirtualNodeDnsServiceDiscoveryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DNSFactory);
    }

    public static CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap(this InnerVirtualNodeServiceDiscoveryFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null)
    {
        parentFactory.AWSCloudMapFactory = new InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AWSCloudMapFactory);
    }

    public static CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1>(this CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, WithDNS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1>(this CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, WithDNS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2>(this CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2>(this CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2, T3, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2, T3>(this CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2, T3, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory, T3, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeServiceDiscoveryFactory, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeServiceDiscoveryFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2, T3, T4, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2, T3, T4, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory, T3, T4, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeServiceDiscoveryFactory, T4, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeServiceDiscoveryFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeServiceDiscoveryFactory, InnerVirtualNodeDnsServiceDiscoveryFactory> WithDNS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeServiceDiscoveryFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDNS(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1>(this CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1>(this CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2>(this CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2>(this CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2, T3, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2, T3>(this CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2, T3, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory, T3, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeServiceDiscoveryFactory, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeServiceDiscoveryFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2, T3, T4, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeServiceDiscoveryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2, T3, T4, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeServiceDiscoveryFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory, T3, T4, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeServiceDiscoveryFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeServiceDiscoveryFactory, T4, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeServiceDiscoveryFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeServiceDiscoveryFactory, InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory> WithAWSCloudMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeServiceDiscoveryFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAWSCloudMap(combinedResult.T5, subFactoryAction));
}
