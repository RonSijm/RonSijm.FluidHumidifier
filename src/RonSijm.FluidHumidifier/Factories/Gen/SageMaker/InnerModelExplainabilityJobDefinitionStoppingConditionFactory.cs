// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionStoppingConditionFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.StoppingCondition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.StoppingCondition>
{

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.StoppingCondition Create()
    {
        var stoppingConditionResult = CreateStoppingCondition();
        factoryAction?.Invoke(stoppingConditionResult);

        return stoppingConditionResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.StoppingCondition CreateStoppingCondition()
    {
        var stoppingConditionResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.StoppingCondition();

        return stoppingConditionResult;
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionStoppingConditionFactoryExtensions
{
}
