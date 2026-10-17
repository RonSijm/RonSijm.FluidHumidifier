// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobHyperParameterTuningJobObjectiveFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobObjective> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobObjective>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobObjective Create()
    {
        var hyperParameterTuningJobObjectiveResult = CreateHyperParameterTuningJobObjective();
        factoryAction?.Invoke(hyperParameterTuningJobObjectiveResult);

        return hyperParameterTuningJobObjectiveResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobObjective CreateHyperParameterTuningJobObjective()
    {
        var hyperParameterTuningJobObjectiveResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobObjective();

        return hyperParameterTuningJobObjectiveResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobHyperParameterTuningJobObjectiveFactoryExtensions
{
}
