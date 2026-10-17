// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleRepublishActionFactory(Action<Humidifier.IoT.TopicRuleTypes.RepublishAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.RepublishAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.RepublishAction Create()
    {
        var republishActionResult = CreateRepublishAction();
        factoryAction?.Invoke(republishActionResult);

        return republishActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.RepublishAction CreateRepublishAction()
    {
        var republishActionResult = new Humidifier.IoT.TopicRuleTypes.RepublishAction();

        return republishActionResult;
    }

} // End Of Class

public static class InnerTopicRuleRepublishActionFactoryExtensions
{
}
