// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionStoppingConditionFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.StoppingCondition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.StoppingCondition>
{

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.StoppingCondition Create()
    {
        var stoppingConditionResult = CreateStoppingCondition();
        factoryAction?.Invoke(stoppingConditionResult);

        return stoppingConditionResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.StoppingCondition CreateStoppingCondition()
    {
        var stoppingConditionResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.StoppingCondition();

        return stoppingConditionResult;
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionStoppingConditionFactoryExtensions
{
}
