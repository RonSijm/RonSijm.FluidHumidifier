// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerChannelCustomerManagedS3Factory(Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3>
{

    protected override Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3 Create()
    {
        var customerManagedS3Result = CreateCustomerManagedS3();
        factoryAction?.Invoke(customerManagedS3Result);

        return customerManagedS3Result;
    }

    private Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3 CreateCustomerManagedS3()
    {
        var customerManagedS3Result = new Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3();

        return customerManagedS3Result;
    }

} // End Of Class

public static class InnerChannelCustomerManagedS3FactoryExtensions
{
}
