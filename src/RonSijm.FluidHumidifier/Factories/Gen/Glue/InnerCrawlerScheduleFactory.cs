// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCrawlerScheduleFactory(Action<Humidifier.Glue.CrawlerTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CrawlerTypes.Schedule>
{

    protected override Humidifier.Glue.CrawlerTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.Glue.CrawlerTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.Glue.CrawlerTypes.Schedule();

        return scheduleResult;
    }

} // End Of Class

public static class InnerCrawlerScheduleFactoryExtensions
{
}
