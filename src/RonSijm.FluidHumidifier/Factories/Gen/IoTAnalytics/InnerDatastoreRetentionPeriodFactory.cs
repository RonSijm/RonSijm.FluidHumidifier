// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatastoreRetentionPeriodFactory(Action<Humidifier.IoTAnalytics.DatastoreTypes.RetentionPeriod> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatastoreTypes.RetentionPeriod>
{

    protected override Humidifier.IoTAnalytics.DatastoreTypes.RetentionPeriod Create()
    {
        var retentionPeriodResult = CreateRetentionPeriod();
        factoryAction?.Invoke(retentionPeriodResult);

        return retentionPeriodResult;
    }

    private Humidifier.IoTAnalytics.DatastoreTypes.RetentionPeriod CreateRetentionPeriod()
    {
        var retentionPeriodResult = new Humidifier.IoTAnalytics.DatastoreTypes.RetentionPeriod();

        return retentionPeriodResult;
    }

} // End Of Class

public static class InnerDatastoreRetentionPeriodFactoryExtensions
{
}
