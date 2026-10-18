// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowScheduledTriggerPropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties Create()
    {
        var scheduledTriggerPropertiesResult = CreateScheduledTriggerProperties();
        factoryAction?.Invoke(scheduledTriggerPropertiesResult);

        return scheduledTriggerPropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties CreateScheduledTriggerProperties()
    {
        var scheduledTriggerPropertiesResult = new Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties();

        return scheduledTriggerPropertiesResult;
    }

} // End Of Class

public static class InnerFlowScheduledTriggerPropertiesFactoryExtensions
{
}
