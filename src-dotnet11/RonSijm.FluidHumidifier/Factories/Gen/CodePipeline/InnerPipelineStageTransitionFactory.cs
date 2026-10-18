// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineStageTransitionFactory(Action<Humidifier.CodePipeline.PipelineTypes.StageTransition> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.StageTransition>
{

    protected override Humidifier.CodePipeline.PipelineTypes.StageTransition Create()
    {
        var stageTransitionResult = CreateStageTransition();
        factoryAction?.Invoke(stageTransitionResult);

        return stageTransitionResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.StageTransition CreateStageTransition()
    {
        var stageTransitionResult = new Humidifier.CodePipeline.PipelineTypes.StageTransition();

        return stageTransitionResult;
    }

} // End Of Class

public static class InnerPipelineStageTransitionFactoryExtensions
{
}
