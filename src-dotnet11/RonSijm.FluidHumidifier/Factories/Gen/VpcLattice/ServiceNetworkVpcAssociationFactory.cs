// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ServiceNetworkVpcAssociationFactory(string resourceName = null, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociation> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.ServiceNetworkVpcAssociation>(resourceName)
{

    internal InnerServiceNetworkVpcAssociationDnsOptionsFactory DnsOptionsFactory { get; set; }

    protected override Humidifier.VpcLattice.ServiceNetworkVpcAssociation Create()
    {
        var serviceNetworkVpcAssociationResult = CreateServiceNetworkVpcAssociation();
        factoryAction?.Invoke(serviceNetworkVpcAssociationResult);

        return serviceNetworkVpcAssociationResult;
    }

    private Humidifier.VpcLattice.ServiceNetworkVpcAssociation CreateServiceNetworkVpcAssociation()
    {
        var serviceNetworkVpcAssociationResult = new Humidifier.VpcLattice.ServiceNetworkVpcAssociation
        {
            GivenName = InputResourceName,
        };

        return serviceNetworkVpcAssociationResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.ServiceNetworkVpcAssociation result)
    {
        base.CreateChildren(result);

        result.DnsOptions ??= DnsOptionsFactory?.Build();
    }

} // End Of Class

public static class ServiceNetworkVpcAssociationFactoryExtensions
{
    public static CombinedResult<ServiceNetworkVpcAssociationFactory, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions(this ServiceNetworkVpcAssociationFactory parentFactory, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null)
    {
        parentFactory.DnsOptionsFactory = new InnerServiceNetworkVpcAssociationDnsOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DnsOptionsFactory);
    }

    public static CombinedResult<ServiceNetworkVpcAssociationFactory, T1, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1>(this CombinedResult<ServiceNetworkVpcAssociationFactory, T1> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceNetworkVpcAssociationFactory, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1>(this CombinedResult<T1, ServiceNetworkVpcAssociationFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ServiceNetworkVpcAssociationFactory, T1, T2, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2>(this CombinedResult<ServiceNetworkVpcAssociationFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceNetworkVpcAssociationFactory, T2, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2>(this CombinedResult<T1, ServiceNetworkVpcAssociationFactory, T2> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ServiceNetworkVpcAssociationFactory, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2>(this CombinedResult<T1, T2, ServiceNetworkVpcAssociationFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ServiceNetworkVpcAssociationFactory, T1, T2, T3, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2, T3>(this CombinedResult<ServiceNetworkVpcAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceNetworkVpcAssociationFactory, T2, T3, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2, T3>(this CombinedResult<T1, ServiceNetworkVpcAssociationFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ServiceNetworkVpcAssociationFactory, T3, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2, T3>(this CombinedResult<T1, T2, ServiceNetworkVpcAssociationFactory, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ServiceNetworkVpcAssociationFactory, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceNetworkVpcAssociationFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ServiceNetworkVpcAssociationFactory, T1, T2, T3, T4, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2, T3, T4>(this CombinedResult<ServiceNetworkVpcAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceNetworkVpcAssociationFactory, T2, T3, T4, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2, T3, T4>(this CombinedResult<T1, ServiceNetworkVpcAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ServiceNetworkVpcAssociationFactory, T3, T4, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceNetworkVpcAssociationFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ServiceNetworkVpcAssociationFactory, T4, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceNetworkVpcAssociationFactory, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ServiceNetworkVpcAssociationFactory, InnerServiceNetworkVpcAssociationDnsOptionsFactory> WithDnsOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceNetworkVpcAssociationFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsOptions(combinedResult.T5, subFactoryAction).T2);
}
