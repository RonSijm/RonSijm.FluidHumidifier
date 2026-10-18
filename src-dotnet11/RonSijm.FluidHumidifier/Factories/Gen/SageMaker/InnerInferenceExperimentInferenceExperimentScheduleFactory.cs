// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceExperimentInferenceExperimentScheduleFactory(Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule>
{

    protected override Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule Create()
    {
        var inferenceExperimentScheduleResult = CreateInferenceExperimentSchedule();
        factoryAction?.Invoke(inferenceExperimentScheduleResult);

        return inferenceExperimentScheduleResult;
    }

    private Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule CreateInferenceExperimentSchedule()
    {
        var inferenceExperimentScheduleResult = new Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule();

        return inferenceExperimentScheduleResult;
    }

} // End Of Class

public static class InnerInferenceExperimentInferenceExperimentScheduleFactoryExtensions
{
}
