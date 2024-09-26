// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class InnerScheduleSageMakerPipelineParametersFactory(Action<Humidifier.Scheduler.ScheduleTypes.SageMakerPipelineParameters> factoryAction = null) : SubResourceFactory<Humidifier.Scheduler.ScheduleTypes.SageMakerPipelineParameters>
{

    protected override Humidifier.Scheduler.ScheduleTypes.SageMakerPipelineParameters Create()
    {
        var sageMakerPipelineParametersResult = CreateSageMakerPipelineParameters();
        factoryAction?.Invoke(sageMakerPipelineParametersResult);

        return sageMakerPipelineParametersResult;
    }

    private Humidifier.Scheduler.ScheduleTypes.SageMakerPipelineParameters CreateSageMakerPipelineParameters()
    {
        var sageMakerPipelineParametersResult = new Humidifier.Scheduler.ScheduleTypes.SageMakerPipelineParameters();

        return sageMakerPipelineParametersResult;
    }

} // End Of Class

public static class InnerScheduleSageMakerPipelineParametersFactoryExtensions
{
}
