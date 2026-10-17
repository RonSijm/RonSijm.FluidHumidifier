// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerWorkerHostPropertiesRequestFactory(Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest>
{

    internal InnerWorkerIpAddressesFactory IpAddressesFactory { get; set; }

    protected override Humidifier.Deadline.WorkerTypes.HostPropertiesRequest Create()
    {
        var hostPropertiesRequestResult = CreateHostPropertiesRequest();
        factoryAction?.Invoke(hostPropertiesRequestResult);

        return hostPropertiesRequestResult;
    }

    private Humidifier.Deadline.WorkerTypes.HostPropertiesRequest CreateHostPropertiesRequest()
    {
        var hostPropertiesRequestResult = new Humidifier.Deadline.WorkerTypes.HostPropertiesRequest();

        return hostPropertiesRequestResult;
    }
    public override void CreateChildren(Humidifier.Deadline.WorkerTypes.HostPropertiesRequest result)
    {
        base.CreateChildren(result);

        result.IpAddresses ??= IpAddressesFactory?.Build();
    }

} // End Of Class

public static class InnerWorkerHostPropertiesRequestFactoryExtensions
{
    public static CombinedResult<InnerWorkerHostPropertiesRequestFactory, InnerWorkerIpAddressesFactory> WithIpAddresses(this InnerWorkerHostPropertiesRequestFactory parentFactory, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null)
    {
        parentFactory.IpAddressesFactory = new InnerWorkerIpAddressesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IpAddressesFactory);
    }

    public static CombinedResult<InnerWorkerHostPropertiesRequestFactory, T1, InnerWorkerIpAddressesFactory> WithIpAddresses<T1>(this CombinedResult<InnerWorkerHostPropertiesRequestFactory, T1> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpAddresses(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkerHostPropertiesRequestFactory, InnerWorkerIpAddressesFactory> WithIpAddresses<T1>(this CombinedResult<T1, InnerWorkerHostPropertiesRequestFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpAddresses(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkerHostPropertiesRequestFactory, T1, T2, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2>(this CombinedResult<InnerWorkerHostPropertiesRequestFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkerHostPropertiesRequestFactory, T2, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2>(this CombinedResult<T1, InnerWorkerHostPropertiesRequestFactory, T2> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkerHostPropertiesRequestFactory, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2>(this CombinedResult<T1, T2, InnerWorkerHostPropertiesRequestFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkerHostPropertiesRequestFactory, T1, T2, T3, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2, T3>(this CombinedResult<InnerWorkerHostPropertiesRequestFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkerHostPropertiesRequestFactory, T2, T3, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2, T3>(this CombinedResult<T1, InnerWorkerHostPropertiesRequestFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkerHostPropertiesRequestFactory, T3, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkerHostPropertiesRequestFactory, T3> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkerHostPropertiesRequestFactory, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkerHostPropertiesRequestFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkerHostPropertiesRequestFactory, T1, T2, T3, T4, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2, T3, T4>(this CombinedResult<InnerWorkerHostPropertiesRequestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkerHostPropertiesRequestFactory, T2, T3, T4, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkerHostPropertiesRequestFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkerHostPropertiesRequestFactory, T3, T4, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkerHostPropertiesRequestFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkerHostPropertiesRequestFactory, T4, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkerHostPropertiesRequestFactory, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkerHostPropertiesRequestFactory, InnerWorkerIpAddressesFactory> WithIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkerHostPropertiesRequestFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.IpAddresses> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T5, subFactoryAction).T2);
}
