// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleOpenSearchActionFactory(Action<Humidifier.IoT.TopicRuleTypes.OpenSearchAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.OpenSearchAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.OpenSearchAction Create()
    {
        var openSearchActionResult = CreateOpenSearchAction();
        factoryAction?.Invoke(openSearchActionResult);

        return openSearchActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.OpenSearchAction CreateOpenSearchAction()
    {
        var openSearchActionResult = new Humidifier.IoT.TopicRuleTypes.OpenSearchAction();

        return openSearchActionResult;
    }

} // End Of Class

public static class InnerTopicRuleOpenSearchActionFactoryExtensions
{
}
