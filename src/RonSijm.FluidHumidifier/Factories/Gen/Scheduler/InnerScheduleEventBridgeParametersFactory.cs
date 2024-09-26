// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class InnerScheduleEventBridgeParametersFactory(Action<Humidifier.Scheduler.ScheduleTypes.EventBridgeParameters> factoryAction = null) : SubResourceFactory<Humidifier.Scheduler.ScheduleTypes.EventBridgeParameters>
{

    protected override Humidifier.Scheduler.ScheduleTypes.EventBridgeParameters Create()
    {
        var eventBridgeParametersResult = CreateEventBridgeParameters();
        factoryAction?.Invoke(eventBridgeParametersResult);

        return eventBridgeParametersResult;
    }

    private Humidifier.Scheduler.ScheduleTypes.EventBridgeParameters CreateEventBridgeParameters()
    {
        var eventBridgeParametersResult = new Humidifier.Scheduler.ScheduleTypes.EventBridgeParameters();

        return eventBridgeParametersResult;
    }

} // End Of Class

public static class InnerScheduleEventBridgeParametersFactoryExtensions
{
}
