// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleSqsActionFactory(Action<Humidifier.IoT.TopicRuleTypes.SqsAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.SqsAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.SqsAction Create()
    {
        var sqsActionResult = CreateSqsAction();
        factoryAction?.Invoke(sqsActionResult);

        return sqsActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.SqsAction CreateSqsAction()
    {
        var sqsActionResult = new Humidifier.IoT.TopicRuleTypes.SqsAction();

        return sqsActionResult;
    }

} // End Of Class

public static class InnerTopicRuleSqsActionFactoryExtensions
{
}
