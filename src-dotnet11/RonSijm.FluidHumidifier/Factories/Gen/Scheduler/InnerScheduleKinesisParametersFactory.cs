// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class InnerScheduleKinesisParametersFactory(Action<Humidifier.Scheduler.ScheduleTypes.KinesisParameters> factoryAction = null) : SubResourceFactory<Humidifier.Scheduler.ScheduleTypes.KinesisParameters>
{

    protected override Humidifier.Scheduler.ScheduleTypes.KinesisParameters Create()
    {
        var kinesisParametersResult = CreateKinesisParameters();
        factoryAction?.Invoke(kinesisParametersResult);

        return kinesisParametersResult;
    }

    private Humidifier.Scheduler.ScheduleTypes.KinesisParameters CreateKinesisParameters()
    {
        var kinesisParametersResult = new Humidifier.Scheduler.ScheduleTypes.KinesisParameters();

        return kinesisParametersResult;
    }

} // End Of Class

public static class InnerScheduleKinesisParametersFactoryExtensions
{
}
