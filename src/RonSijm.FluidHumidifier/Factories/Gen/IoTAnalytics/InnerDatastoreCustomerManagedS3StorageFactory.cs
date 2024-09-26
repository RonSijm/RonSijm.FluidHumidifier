// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatastoreCustomerManagedS3StorageFactory(Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage>
{

    protected override Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage Create()
    {
        var customerManagedS3StorageResult = CreateCustomerManagedS3Storage();
        factoryAction?.Invoke(customerManagedS3StorageResult);

        return customerManagedS3StorageResult;
    }

    private Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage CreateCustomerManagedS3Storage()
    {
        var customerManagedS3StorageResult = new Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage();

        return customerManagedS3StorageResult;
    }

} // End Of Class

public static class InnerDatastoreCustomerManagedS3StorageFactoryExtensions
{
}
