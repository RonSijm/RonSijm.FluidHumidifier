// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryReadiness;

public class InnerResourceSetResourceFactory(Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> factoryAction = null) : SubResourceFactory<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource>
{

    internal InnerResourceSetDNSTargetResourceFactory DnsTargetResourceFactory { get; set; }

    protected override Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource Create()
    {
        var resourceResult = CreateResource();
        factoryAction?.Invoke(resourceResult);

        return resourceResult;
    }

    private Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource CreateResource()
    {
        var resourceResult = new Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource();

        return resourceResult;
    }
    public override void CreateChildren(Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource result)
    {
        base.CreateChildren(result);

        result.DnsTargetResource ??= DnsTargetResourceFactory?.Build();
    }

} // End Of Class

public static class InnerResourceSetResourceFactoryExtensions
{
    public static CombinedResult<InnerResourceSetResourceFactory, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource(this InnerResourceSetResourceFactory parentFactory, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null)
    {
        parentFactory.DnsTargetResourceFactory = new InnerResourceSetDNSTargetResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DnsTargetResourceFactory);
    }

    public static CombinedResult<InnerResourceSetResourceFactory, T1, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1>(this CombinedResult<InnerResourceSetResourceFactory, T1> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetResourceFactory, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1>(this CombinedResult<T1, InnerResourceSetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceSetResourceFactory, T1, T2, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2>(this CombinedResult<InnerResourceSetResourceFactory, T1, T2> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetResourceFactory, T2, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2>(this CombinedResult<T1, InnerResourceSetResourceFactory, T2> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetResourceFactory, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2>(this CombinedResult<T1, T2, InnerResourceSetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceSetResourceFactory, T1, T2, T3, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2, T3>(this CombinedResult<InnerResourceSetResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetResourceFactory, T2, T3, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2, T3>(this CombinedResult<T1, InnerResourceSetResourceFactory, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetResourceFactory, T3, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceSetResourceFactory, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceSetResourceFactory, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceSetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceSetResourceFactory, T1, T2, T3, T4, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2, T3, T4>(this CombinedResult<InnerResourceSetResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetResourceFactory, T2, T3, T4, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceSetResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetResourceFactory, T3, T4, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceSetResourceFactory, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceSetResourceFactory, T4, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceSetResourceFactory, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceSetResourceFactory, InnerResourceSetDNSTargetResourceFactory> WithDnsTargetResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceSetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsTargetResource(combinedResult.T5, subFactoryAction));
}
