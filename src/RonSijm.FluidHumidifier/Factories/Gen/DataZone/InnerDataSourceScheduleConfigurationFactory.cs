// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerDataSourceScheduleConfigurationFactory(Action<Humidifier.DataZone.DataSourceTypes.ScheduleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.DataSourceTypes.ScheduleConfiguration>
{

    protected override Humidifier.DataZone.DataSourceTypes.ScheduleConfiguration Create()
    {
        var scheduleConfigurationResult = CreateScheduleConfiguration();
        factoryAction?.Invoke(scheduleConfigurationResult);

        return scheduleConfigurationResult;
    }

    private Humidifier.DataZone.DataSourceTypes.ScheduleConfiguration CreateScheduleConfiguration()
    {
        var scheduleConfigurationResult = new Humidifier.DataZone.DataSourceTypes.ScheduleConfiguration();

        return scheduleConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceScheduleConfigurationFactoryExtensions
{
}
