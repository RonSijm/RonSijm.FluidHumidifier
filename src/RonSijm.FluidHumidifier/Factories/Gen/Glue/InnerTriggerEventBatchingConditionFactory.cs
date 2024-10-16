// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTriggerEventBatchingConditionFactory(Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TriggerTypes.EventBatchingCondition>
{

    protected override Humidifier.Glue.TriggerTypes.EventBatchingCondition Create()
    {
        var eventBatchingConditionResult = CreateEventBatchingCondition();
        factoryAction?.Invoke(eventBatchingConditionResult);

        return eventBatchingConditionResult;
    }

    private Humidifier.Glue.TriggerTypes.EventBatchingCondition CreateEventBatchingCondition()
    {
        var eventBatchingConditionResult = new Humidifier.Glue.TriggerTypes.EventBatchingCondition();

        return eventBatchingConditionResult;
    }

} // End Of Class

public static class InnerTriggerEventBatchingConditionFactoryExtensions
{
}
