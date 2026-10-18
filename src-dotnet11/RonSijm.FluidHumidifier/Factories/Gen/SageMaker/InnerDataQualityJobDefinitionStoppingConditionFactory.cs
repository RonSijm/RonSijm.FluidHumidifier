// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionStoppingConditionFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.StoppingCondition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.StoppingCondition>
{

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.StoppingCondition Create()
    {
        var stoppingConditionResult = CreateStoppingCondition();
        factoryAction?.Invoke(stoppingConditionResult);

        return stoppingConditionResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.StoppingCondition CreateStoppingCondition()
    {
        var stoppingConditionResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.StoppingCondition();

        return stoppingConditionResult;
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionStoppingConditionFactoryExtensions
{
}
