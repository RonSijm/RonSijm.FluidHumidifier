// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OSIS;

public class PipelineBlueprintFactory(string resourceName = null, Action<Humidifier.OSIS.PipelineBlueprint> factoryAction = null) : ResourceFactory<Humidifier.OSIS.PipelineBlueprint>(resourceName)
{

    protected override Humidifier.OSIS.PipelineBlueprint Create()
    {
        var pipelineBlueprintResult = CreatePipelineBlueprint();
        factoryAction?.Invoke(pipelineBlueprintResult);

        return pipelineBlueprintResult;
    }

    private Humidifier.OSIS.PipelineBlueprint CreatePipelineBlueprint()
    {
        var pipelineBlueprintResult = new Humidifier.OSIS.PipelineBlueprint
        {
            GivenName = InputResourceName,
        };

        return pipelineBlueprintResult;
    }

} // End Of Class

public static class PipelineBlueprintFactoryExtensions
{
}
