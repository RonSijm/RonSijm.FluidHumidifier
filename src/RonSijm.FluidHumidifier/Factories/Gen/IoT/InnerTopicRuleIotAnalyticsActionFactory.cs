// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleIotAnalyticsActionFactory(Action<Humidifier.IoT.TopicRuleTypes.IotAnalyticsAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.IotAnalyticsAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.IotAnalyticsAction Create()
    {
        var iotAnalyticsActionResult = CreateIotAnalyticsAction();
        factoryAction?.Invoke(iotAnalyticsActionResult);

        return iotAnalyticsActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.IotAnalyticsAction CreateIotAnalyticsAction()
    {
        var iotAnalyticsActionResult = new Humidifier.IoT.TopicRuleTypes.IotAnalyticsAction();

        return iotAnalyticsActionResult;
    }

} // End Of Class

public static class InnerTopicRuleIotAnalyticsActionFactoryExtensions
{
}
