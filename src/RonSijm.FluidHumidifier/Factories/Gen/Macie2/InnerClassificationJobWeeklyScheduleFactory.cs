// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie2;

public class InnerClassificationJobWeeklyScheduleFactory(Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> factoryAction = null) : SubResourceFactory<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule>
{

    protected override Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule Create()
    {
        var weeklyScheduleResult = CreateWeeklySchedule();
        factoryAction?.Invoke(weeklyScheduleResult);

        return weeklyScheduleResult;
    }

    private Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule CreateWeeklySchedule()
    {
        var weeklyScheduleResult = new Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule();

        return weeklyScheduleResult;
    }

} // End Of Class

public static class InnerClassificationJobWeeklyScheduleFactoryExtensions
{
}
