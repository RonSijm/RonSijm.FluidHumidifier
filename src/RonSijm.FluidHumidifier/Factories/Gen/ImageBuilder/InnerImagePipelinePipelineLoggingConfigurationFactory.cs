// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImagePipelinePipelineLoggingConfigurationFactory(Action<Humidifier.ImageBuilder.ImagePipelineTypes.PipelineLoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImagePipelineTypes.PipelineLoggingConfiguration>
{

    protected override Humidifier.ImageBuilder.ImagePipelineTypes.PipelineLoggingConfiguration Create()
    {
        var pipelineLoggingConfigurationResult = CreatePipelineLoggingConfiguration();
        factoryAction?.Invoke(pipelineLoggingConfigurationResult);

        return pipelineLoggingConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImagePipelineTypes.PipelineLoggingConfiguration CreatePipelineLoggingConfiguration()
    {
        var pipelineLoggingConfigurationResult = new Humidifier.ImageBuilder.ImagePipelineTypes.PipelineLoggingConfiguration();

        return pipelineLoggingConfigurationResult;
    }

} // End Of Class

public static class InnerImagePipelinePipelineLoggingConfigurationFactoryExtensions
{
}
