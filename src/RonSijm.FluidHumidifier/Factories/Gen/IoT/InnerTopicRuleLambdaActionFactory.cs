// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleLambdaActionFactory(Action<Humidifier.IoT.TopicRuleTypes.LambdaAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.LambdaAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.LambdaAction Create()
    {
        var lambdaActionResult = CreateLambdaAction();
        factoryAction?.Invoke(lambdaActionResult);

        return lambdaActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.LambdaAction CreateLambdaAction()
    {
        var lambdaActionResult = new Humidifier.IoT.TopicRuleTypes.LambdaAction();

        return lambdaActionResult;
    }

} // End Of Class

public static class InnerTopicRuleLambdaActionFactoryExtensions
{
}
