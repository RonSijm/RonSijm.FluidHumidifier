// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionStoppingConditionFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.StoppingCondition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.StoppingCondition>
{

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.StoppingCondition Create()
    {
        var stoppingConditionResult = CreateStoppingCondition();
        factoryAction?.Invoke(stoppingConditionResult);

        return stoppingConditionResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.StoppingCondition CreateStoppingCondition()
    {
        var stoppingConditionResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.StoppingCondition();

        return stoppingConditionResult;
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionStoppingConditionFactoryExtensions
{
}
