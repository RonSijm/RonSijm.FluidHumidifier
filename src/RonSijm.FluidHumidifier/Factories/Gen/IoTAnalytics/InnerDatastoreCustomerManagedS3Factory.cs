// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatastoreCustomerManagedS3Factory(Action<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3>
{

    protected override Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3 Create()
    {
        var customerManagedS3Result = CreateCustomerManagedS3();
        factoryAction?.Invoke(customerManagedS3Result);

        return customerManagedS3Result;
    }

    private Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3 CreateCustomerManagedS3()
    {
        var customerManagedS3Result = new Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3();

        return customerManagedS3Result;
    }

} // End Of Class

public static class InnerDatastoreCustomerManagedS3FactoryExtensions
{
}
