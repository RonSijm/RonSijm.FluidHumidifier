// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobTuningObjectiveFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.TuningObjective> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.TuningObjective>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.TuningObjective Create()
    {
        var tuningObjectiveResult = CreateTuningObjective();
        factoryAction?.Invoke(tuningObjectiveResult);

        return tuningObjectiveResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.TuningObjective CreateTuningObjective()
    {
        var tuningObjectiveResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.TuningObjective();

        return tuningObjectiveResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobTuningObjectiveFactoryExtensions
{
}
