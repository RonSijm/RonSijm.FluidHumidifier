// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleStepFunctionsActionFactory(Action<Humidifier.IoT.TopicRuleTypes.StepFunctionsAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.StepFunctionsAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.StepFunctionsAction Create()
    {
        var stepFunctionsActionResult = CreateStepFunctionsAction();
        factoryAction?.Invoke(stepFunctionsActionResult);

        return stepFunctionsActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.StepFunctionsAction CreateStepFunctionsAction()
    {
        var stepFunctionsActionResult = new Humidifier.IoT.TopicRuleTypes.StepFunctionsAction();

        return stepFunctionsActionResult;
    }

} // End Of Class

public static class InnerTopicRuleStepFunctionsActionFactoryExtensions
{
}
