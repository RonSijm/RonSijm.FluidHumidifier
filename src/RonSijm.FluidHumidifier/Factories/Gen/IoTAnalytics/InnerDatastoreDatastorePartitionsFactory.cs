// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatastoreDatastorePartitionsFactory(Action<Humidifier.IoTAnalytics.DatastoreTypes.DatastorePartitions> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatastoreTypes.DatastorePartitions>
{

    protected override Humidifier.IoTAnalytics.DatastoreTypes.DatastorePartitions Create()
    {
        var datastorePartitionsResult = CreateDatastorePartitions();
        factoryAction?.Invoke(datastorePartitionsResult);

        return datastorePartitionsResult;
    }

    private Humidifier.IoTAnalytics.DatastoreTypes.DatastorePartitions CreateDatastorePartitions()
    {
        var datastorePartitionsResult = new Humidifier.IoTAnalytics.DatastoreTypes.DatastorePartitions();

        return datastorePartitionsResult;
    }

} // End Of Class

public static class InnerDatastoreDatastorePartitionsFactoryExtensions
{
}
