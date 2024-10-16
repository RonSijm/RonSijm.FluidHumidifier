// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleCloudwatchLogsActionFactory(Action<Humidifier.IoT.TopicRuleTypes.CloudwatchLogsAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.CloudwatchLogsAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.CloudwatchLogsAction Create()
    {
        var cloudwatchLogsActionResult = CreateCloudwatchLogsAction();
        factoryAction?.Invoke(cloudwatchLogsActionResult);

        return cloudwatchLogsActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.CloudwatchLogsAction CreateCloudwatchLogsAction()
    {
        var cloudwatchLogsActionResult = new Humidifier.IoT.TopicRuleTypes.CloudwatchLogsAction();

        return cloudwatchLogsActionResult;
    }

} // End Of Class

public static class InnerTopicRuleCloudwatchLogsActionFactoryExtensions
{
}
