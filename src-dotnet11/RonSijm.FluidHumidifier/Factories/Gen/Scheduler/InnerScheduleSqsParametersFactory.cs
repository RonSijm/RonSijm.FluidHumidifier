// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class InnerScheduleSqsParametersFactory(Action<Humidifier.Scheduler.ScheduleTypes.SqsParameters> factoryAction = null) : SubResourceFactory<Humidifier.Scheduler.ScheduleTypes.SqsParameters>
{

    protected override Humidifier.Scheduler.ScheduleTypes.SqsParameters Create()
    {
        var sqsParametersResult = CreateSqsParameters();
        factoryAction?.Invoke(sqsParametersResult);

        return sqsParametersResult;
    }

    private Humidifier.Scheduler.ScheduleTypes.SqsParameters CreateSqsParameters()
    {
        var sqsParametersResult = new Humidifier.Scheduler.ScheduleTypes.SqsParameters();

        return sqsParametersResult;
    }

} // End Of Class

public static class InnerScheduleSqsParametersFactoryExtensions
{
}
