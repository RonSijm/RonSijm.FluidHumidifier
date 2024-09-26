// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ServiceNetworkServiceAssociationFactory(string resourceName = null, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociation> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.ServiceNetworkServiceAssociation>(resourceName)
{

    internal InnerServiceNetworkServiceAssociationDnsEntryFactory DnsEntryFactory { get; set; }

    protected override Humidifier.VpcLattice.ServiceNetworkServiceAssociation Create()
    {
        var serviceNetworkServiceAssociationResult = CreateServiceNetworkServiceAssociation();
        factoryAction?.Invoke(serviceNetworkServiceAssociationResult);

        return serviceNetworkServiceAssociationResult;
    }

    private Humidifier.VpcLattice.ServiceNetworkServiceAssociation CreateServiceNetworkServiceAssociation()
    {
        var serviceNetworkServiceAssociationResult = new Humidifier.VpcLattice.ServiceNetworkServiceAssociation
        {
            GivenName = InputResourceName,
        };

        return serviceNetworkServiceAssociationResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.ServiceNetworkServiceAssociation result)
    {
        base.CreateChildren(result);

        result.DnsEntry ??= DnsEntryFactory?.Build();
    }

} // End Of Class

public static class ServiceNetworkServiceAssociationFactoryExtensions
{
    public static CombinedResult<ServiceNetworkServiceAssociationFactory, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry(this ServiceNetworkServiceAssociationFactory parentFactory, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null)
    {
        parentFactory.DnsEntryFactory = new InnerServiceNetworkServiceAssociationDnsEntryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DnsEntryFactory);
    }

    public static CombinedResult<ServiceNetworkServiceAssociationFactory, T1, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1>(this CombinedResult<ServiceNetworkServiceAssociationFactory, T1> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceNetworkServiceAssociationFactory, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1>(this CombinedResult<T1, ServiceNetworkServiceAssociationFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServiceNetworkServiceAssociationFactory, T1, T2, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2>(this CombinedResult<ServiceNetworkServiceAssociationFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceNetworkServiceAssociationFactory, T2, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2>(this CombinedResult<T1, ServiceNetworkServiceAssociationFactory, T2> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceNetworkServiceAssociationFactory, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2>(this CombinedResult<T1, T2, ServiceNetworkServiceAssociationFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServiceNetworkServiceAssociationFactory, T1, T2, T3, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2, T3>(this CombinedResult<ServiceNetworkServiceAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceNetworkServiceAssociationFactory, T2, T3, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2, T3>(this CombinedResult<T1, ServiceNetworkServiceAssociationFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceNetworkServiceAssociationFactory, T3, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2, T3>(this CombinedResult<T1, T2, ServiceNetworkServiceAssociationFactory, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceNetworkServiceAssociationFactory, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceNetworkServiceAssociationFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServiceNetworkServiceAssociationFactory, T1, T2, T3, T4, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2, T3, T4>(this CombinedResult<ServiceNetworkServiceAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceNetworkServiceAssociationFactory, T2, T3, T4, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2, T3, T4>(this CombinedResult<T1, ServiceNetworkServiceAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceNetworkServiceAssociationFactory, T3, T4, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceNetworkServiceAssociationFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceNetworkServiceAssociationFactory, T4, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceNetworkServiceAssociationFactory, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServiceNetworkServiceAssociationFactory, InnerServiceNetworkServiceAssociationDnsEntryFactory> WithDnsEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceNetworkServiceAssociationFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T5, subFactoryAction));
}
