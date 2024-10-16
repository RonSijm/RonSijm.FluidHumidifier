// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerChannelRetentionPeriodFactory(Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod>
{

    protected override Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod Create()
    {
        var retentionPeriodResult = CreateRetentionPeriod();
        factoryAction?.Invoke(retentionPeriodResult);

        return retentionPeriodResult;
    }

    private Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod CreateRetentionPeriod()
    {
        var retentionPeriodResult = new Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod();

        return retentionPeriodResult;
    }

} // End Of Class

public static class InnerChannelRetentionPeriodFactoryExtensions
{
}
