// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleCloudwatchAlarmActionFactory(Action<Humidifier.IoT.TopicRuleTypes.CloudwatchAlarmAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.CloudwatchAlarmAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.CloudwatchAlarmAction Create()
    {
        var cloudwatchAlarmActionResult = CreateCloudwatchAlarmAction();
        factoryAction?.Invoke(cloudwatchAlarmActionResult);

        return cloudwatchAlarmActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.CloudwatchAlarmAction CreateCloudwatchAlarmAction()
    {
        var cloudwatchAlarmActionResult = new Humidifier.IoT.TopicRuleTypes.CloudwatchAlarmAction();

        return cloudwatchAlarmActionResult;
    }

} // End Of Class

public static class InnerTopicRuleCloudwatchAlarmActionFactoryExtensions
{
}
