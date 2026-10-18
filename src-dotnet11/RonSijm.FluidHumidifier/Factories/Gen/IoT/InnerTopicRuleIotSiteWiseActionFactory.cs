// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleIotSiteWiseActionFactory(Action<Humidifier.IoT.TopicRuleTypes.IotSiteWiseAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.IotSiteWiseAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.IotSiteWiseAction Create()
    {
        var iotSiteWiseActionResult = CreateIotSiteWiseAction();
        factoryAction?.Invoke(iotSiteWiseActionResult);

        return iotSiteWiseActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.IotSiteWiseAction CreateIotSiteWiseAction()
    {
        var iotSiteWiseActionResult = new Humidifier.IoT.TopicRuleTypes.IotSiteWiseAction();

        return iotSiteWiseActionResult;
    }

} // End Of Class

public static class InnerTopicRuleIotSiteWiseActionFactoryExtensions
{
}
