// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobStoppingConditionFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.StoppingCondition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.StoppingCondition>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.StoppingCondition Create()
    {
        var stoppingConditionResult = CreateStoppingCondition();
        factoryAction?.Invoke(stoppingConditionResult);

        return stoppingConditionResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.StoppingCondition CreateStoppingCondition()
    {
        var stoppingConditionResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.StoppingCondition();

        return stoppingConditionResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobStoppingConditionFactoryExtensions
{
}
