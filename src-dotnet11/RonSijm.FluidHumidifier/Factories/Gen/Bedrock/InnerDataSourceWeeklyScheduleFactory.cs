// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceWeeklyScheduleFactory(Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule>
{

    protected override Humidifier.Bedrock.DataSourceTypes.WeeklySchedule Create()
    {
        var weeklyScheduleResult = CreateWeeklySchedule();
        factoryAction?.Invoke(weeklyScheduleResult);

        return weeklyScheduleResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.WeeklySchedule CreateWeeklySchedule()
    {
        var weeklyScheduleResult = new Humidifier.Bedrock.DataSourceTypes.WeeklySchedule();

        return weeklyScheduleResult;
    }

} // End Of Class

public static class InnerDataSourceWeeklyScheduleFactoryExtensions
{
}
