// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetRetentionPeriodFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.RetentionPeriod> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.RetentionPeriod>
{

    protected override Humidifier.IoTAnalytics.DatasetTypes.RetentionPeriod Create()
    {
        var retentionPeriodResult = CreateRetentionPeriod();
        factoryAction?.Invoke(retentionPeriodResult);

        return retentionPeriodResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.RetentionPeriod CreateRetentionPeriod()
    {
        var retentionPeriodResult = new Humidifier.IoTAnalytics.DatasetTypes.RetentionPeriod();

        return retentionPeriodResult;
    }

} // End Of Class

public static class InnerDatasetRetentionPeriodFactoryExtensions
{
}
