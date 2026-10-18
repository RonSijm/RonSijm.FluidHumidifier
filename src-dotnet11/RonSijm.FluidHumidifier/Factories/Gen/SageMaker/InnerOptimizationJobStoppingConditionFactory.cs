// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerOptimizationJobStoppingConditionFactory(Action<Humidifier.SageMaker.OptimizationJobTypes.StoppingCondition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.OptimizationJobTypes.StoppingCondition>
{

    protected override Humidifier.SageMaker.OptimizationJobTypes.StoppingCondition Create()
    {
        var stoppingConditionResult = CreateStoppingCondition();
        factoryAction?.Invoke(stoppingConditionResult);

        return stoppingConditionResult;
    }

    private Humidifier.SageMaker.OptimizationJobTypes.StoppingCondition CreateStoppingCondition()
    {
        var stoppingConditionResult = new Humidifier.SageMaker.OptimizationJobTypes.StoppingCondition();

        return stoppingConditionResult;
    }

} // End Of Class

public static class InnerOptimizationJobStoppingConditionFactoryExtensions
{
}
