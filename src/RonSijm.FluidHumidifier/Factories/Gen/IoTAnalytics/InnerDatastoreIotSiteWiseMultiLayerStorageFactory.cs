// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatastoreIotSiteWiseMultiLayerStorageFactory(Action<Humidifier.IoTAnalytics.DatastoreTypes.IotSiteWiseMultiLayerStorage> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatastoreTypes.IotSiteWiseMultiLayerStorage>
{

    internal InnerDatastoreCustomerManagedS3StorageFactory CustomerManagedS3StorageFactory { get; set; }

    protected override Humidifier.IoTAnalytics.DatastoreTypes.IotSiteWiseMultiLayerStorage Create()
    {
        var iotSiteWiseMultiLayerStorageResult = CreateIotSiteWiseMultiLayerStorage();
        factoryAction?.Invoke(iotSiteWiseMultiLayerStorageResult);

        return iotSiteWiseMultiLayerStorageResult;
    }

    private Humidifier.IoTAnalytics.DatastoreTypes.IotSiteWiseMultiLayerStorage CreateIotSiteWiseMultiLayerStorage()
    {
        var iotSiteWiseMultiLayerStorageResult = new Humidifier.IoTAnalytics.DatastoreTypes.IotSiteWiseMultiLayerStorage();

        return iotSiteWiseMultiLayerStorageResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.DatastoreTypes.IotSiteWiseMultiLayerStorage result)
    {
        base.CreateChildren(result);

        result.CustomerManagedS3Storage ??= CustomerManagedS3StorageFactory?.Build();
    }

} // End Of Class

public static class InnerDatastoreIotSiteWiseMultiLayerStorageFactoryExtensions
{
    public static CombinedResult<InnerDatastoreIotSiteWiseMultiLayerStorageFactory, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage(this InnerDatastoreIotSiteWiseMultiLayerStorageFactory parentFactory, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null)
    {
        parentFactory.CustomerManagedS3StorageFactory = new InnerDatastoreCustomerManagedS3StorageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomerManagedS3StorageFactory);
    }

    public static CombinedResult<InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T1, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1>(this CombinedResult<InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1>(this CombinedResult<T1, InnerDatastoreIotSiteWiseMultiLayerStorageFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T1, T2, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2>(this CombinedResult<InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T2, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2>(this CombinedResult<T1, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2>(this CombinedResult<T1, T2, InnerDatastoreIotSiteWiseMultiLayerStorageFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T1, T2, T3, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2, T3>(this CombinedResult<InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T2, T3, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2, T3>(this CombinedResult<T1, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T3, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatastoreIotSiteWiseMultiLayerStorageFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T1, T2, T3, T4, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2, T3, T4>(this CombinedResult<InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T2, T3, T4, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T3, T4, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T4, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatastoreIotSiteWiseMultiLayerStorageFactory, InnerDatastoreCustomerManagedS3StorageFactory> WithCustomerManagedS3Storage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatastoreIotSiteWiseMultiLayerStorageFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3Storage(combinedResult.T5, subFactoryAction));
}
