// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleStatisticsResourceFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.StatisticsResource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.StatisticsResource>
{

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.StatisticsResource Create()
    {
        var statisticsResourceResult = CreateStatisticsResource();
        factoryAction?.Invoke(statisticsResourceResult);

        return statisticsResourceResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.StatisticsResource CreateStatisticsResource()
    {
        var statisticsResourceResult = new Humidifier.SageMaker.MonitoringScheduleTypes.StatisticsResource();

        return statisticsResourceResult;
    }

} // End Of Class

public static class InnerMonitoringScheduleStatisticsResourceFactoryExtensions
{
}
