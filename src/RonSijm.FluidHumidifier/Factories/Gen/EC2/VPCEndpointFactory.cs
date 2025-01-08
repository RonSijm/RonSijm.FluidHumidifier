// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCEndpointFactory(string resourceName = null, Action<Humidifier.EC2.VPCEndpoint> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCEndpoint>(resourceName)
{

    internal InnerVPCEndpointDnsOptionsSpecificationFactory DnsOptionsFactory { get; set; }

    protected override Humidifier.EC2.VPCEndpoint Create()
    {
        var vPCEndpointResult = CreateVPCEndpoint();
        factoryAction?.Invoke(vPCEndpointResult);

        return vPCEndpointResult;
    }

    private Humidifier.EC2.VPCEndpoint CreateVPCEndpoint()
    {
        var vPCEndpointResult = new Humidifier.EC2.VPCEndpoint
        {
            GivenName = InputResourceName,
        };

        return vPCEndpointResult;
    }
    public override void CreateChildren(Humidifier.EC2.VPCEndpoint result)
    {
        base.CreateChildren(result);

        result.DnsOptions ??= DnsOptionsFactory?.Build();
    }

} // End Of Class

public static class VPCEndpointFactoryExtensions
{
    public static CombinedResult<VPCEndpointFactory, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions(this VPCEndpointFactory parentFactory, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null)
    {
        parentFactory.DnsOptionsFactory = new InnerVPCEndpointDnsOptionsSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DnsOptionsFactory);
    }

    public static CombinedResult<VPCEndpointFactory, T1, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1>(this CombinedResult<VPCEndpointFactory, T1> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VPCEndpointFactory, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1>(this CombinedResult<T1, VPCEndpointFactory> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VPCEndpointFactory, T1, T2, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2>(this CombinedResult<VPCEndpointFactory, T1, T2> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VPCEndpointFactory, T2, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2>(this CombinedResult<T1, VPCEndpointFactory, T2> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VPCEndpointFactory, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2>(this CombinedResult<T1, T2, VPCEndpointFactory> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VPCEndpointFactory, T1, T2, T3, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2, T3>(this CombinedResult<VPCEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VPCEndpointFactory, T2, T3, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2, T3>(this CombinedResult<T1, VPCEndpointFactory, T2, T3> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VPCEndpointFactory, T3, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2, T3>(this CombinedResult<T1, T2, VPCEndpointFactory, T3> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VPCEndpointFactory, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, VPCEndpointFactory> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VPCEndpointFactory, T1, T2, T3, T4, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2, T3, T4>(this CombinedResult<VPCEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VPCEndpointFactory, T2, T3, T4, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2, T3, T4>(this CombinedResult<T1, VPCEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VPCEndpointFactory, T3, T4, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, VPCEndpointFactory, T3, T4> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VPCEndpointFactory, T4, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VPCEndpointFactory, T4> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VPCEndpointFactory, InnerVPCEndpointDnsOptionsSpecificationFactory> WithDnsOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VPCEndpointFactory> combinedResult, Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T5, subFactoryAction));
}
