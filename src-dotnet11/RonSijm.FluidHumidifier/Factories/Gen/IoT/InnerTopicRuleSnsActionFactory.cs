// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleSnsActionFactory(Action<Humidifier.IoT.TopicRuleTypes.SnsAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.SnsAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.SnsAction Create()
    {
        var snsActionResult = CreateSnsAction();
        factoryAction?.Invoke(snsActionResult);

        return snsActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.SnsAction CreateSnsAction()
    {
        var snsActionResult = new Humidifier.IoT.TopicRuleTypes.SnsAction();

        return snsActionResult;
    }

} // End Of Class

public static class InnerTopicRuleSnsActionFactoryExtensions
{
}
