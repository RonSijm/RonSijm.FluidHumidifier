// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory(Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget>
{

    protected override Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget Create()
    {
        var eventBridgeRuleTemplateTargetResult = CreateEventBridgeRuleTemplateTarget();
        factoryAction?.Invoke(eventBridgeRuleTemplateTargetResult);

        return eventBridgeRuleTemplateTargetResult;
    }

    private Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget CreateEventBridgeRuleTemplateTarget()
    {
        var eventBridgeRuleTemplateTargetResult = new Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget();

        return eventBridgeRuleTemplateTargetResult;
    }

} // End Of Class

public static class InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactoryExtensions
{
}
