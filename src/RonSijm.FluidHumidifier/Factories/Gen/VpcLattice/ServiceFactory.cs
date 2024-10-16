// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ServiceFactory(string resourceName = null, Action<Humidifier.VpcLattice.Service> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.Service>(resourceName)
{

    internal InnerServiceDnsEntryFactory DnsEntryFactory { get; set; }

    protected override Humidifier.VpcLattice.Service Create()
    {
        var serviceResult = CreateService();
        factoryAction?.Invoke(serviceResult);

        return serviceResult;
    }

    private Humidifier.VpcLattice.Service CreateService()
    {
        var serviceResult = new Humidifier.VpcLattice.Service
        {
            GivenName = InputResourceName,
        };

        return serviceResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.Service result)
    {
        base.CreateChildren(result);

        result.DnsEntry ??= DnsEntryFactory?.Build();
    }

} // End Of Class

public static class ServiceFactoryExtensions
{
    public static CombinedResult<ServiceFactory, InnerServiceDnsEntryFactory> WithDnsEntry(this ServiceFactory parentFactory, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null)
    {
        parentFactory.DnsEntryFactory = new InnerServiceDnsEntryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DnsEntryFactory);
    }

    public static CombinedResult<ServiceFactory, T1, InnerServiceDnsEntryFactory> WithDnsEntry<T1>(this CombinedResult<ServiceFactory, T1> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, InnerServiceDnsEntryFactory> WithDnsEntry<T1>(this CombinedResult<T1, ServiceFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2>(this CombinedResult<ServiceFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2>(this CombinedResult<T1, ServiceFactory, T2> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2>(this CombinedResult<T1, T2, ServiceFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2, T3>(this CombinedResult<ServiceFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2, T3>(this CombinedResult<T1, ServiceFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2, T3>(this CombinedResult<T1, T2, ServiceFactory, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, T4, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2, T3, T4>(this CombinedResult<ServiceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, T4, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2, T3, T4>(this CombinedResult<T1, ServiceFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, T4, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, T4, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceFactory, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServiceFactory, InnerServiceDnsEntryFactory> WithDnsEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsEntry(combinedResult.T5, subFactoryAction));
}
