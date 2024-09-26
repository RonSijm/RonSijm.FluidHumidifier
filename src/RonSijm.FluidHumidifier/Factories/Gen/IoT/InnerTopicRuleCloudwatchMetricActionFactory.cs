// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleCloudwatchMetricActionFactory(Action<Humidifier.IoT.TopicRuleTypes.CloudwatchMetricAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.CloudwatchMetricAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.CloudwatchMetricAction Create()
    {
        var cloudwatchMetricActionResult = CreateCloudwatchMetricAction();
        factoryAction?.Invoke(cloudwatchMetricActionResult);

        return cloudwatchMetricActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.CloudwatchMetricAction CreateCloudwatchMetricAction()
    {
        var cloudwatchMetricActionResult = new Humidifier.IoT.TopicRuleTypes.CloudwatchMetricAction();

        return cloudwatchMetricActionResult;
    }

} // End Of Class

public static class InnerTopicRuleCloudwatchMetricActionFactoryExtensions
{
}
