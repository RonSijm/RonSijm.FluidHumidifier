// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class EventBridgeRuleTemplateGroupFactory(string resourceName = null, Action<Humidifier.MediaLive.EventBridgeRuleTemplateGroup> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.EventBridgeRuleTemplateGroup>(resourceName)
{

    protected override Humidifier.MediaLive.EventBridgeRuleTemplateGroup Create()
    {
        var eventBridgeRuleTemplateGroupResult = CreateEventBridgeRuleTemplateGroup();
        factoryAction?.Invoke(eventBridgeRuleTemplateGroupResult);

        return eventBridgeRuleTemplateGroupResult;
    }

    private Humidifier.MediaLive.EventBridgeRuleTemplateGroup CreateEventBridgeRuleTemplateGroup()
    {
        var eventBridgeRuleTemplateGroupResult = new Humidifier.MediaLive.EventBridgeRuleTemplateGroup
        {
            GivenName = InputResourceName,
        };

        return eventBridgeRuleTemplateGroupResult;
    }

} // End Of Class

public static class EventBridgeRuleTemplateGroupFactoryExtensions
{
}
