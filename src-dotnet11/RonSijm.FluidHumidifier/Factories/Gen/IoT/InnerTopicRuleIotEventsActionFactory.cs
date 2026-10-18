// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleIotEventsActionFactory(Action<Humidifier.IoT.TopicRuleTypes.IotEventsAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.IotEventsAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.IotEventsAction Create()
    {
        var iotEventsActionResult = CreateIotEventsAction();
        factoryAction?.Invoke(iotEventsActionResult);

        return iotEventsActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.IotEventsAction CreateIotEventsAction()
    {
        var iotEventsActionResult = new Humidifier.IoT.TopicRuleTypes.IotEventsAction();

        return iotEventsActionResult;
    }

} // End Of Class

public static class InnerTopicRuleIotEventsActionFactoryExtensions
{
}
