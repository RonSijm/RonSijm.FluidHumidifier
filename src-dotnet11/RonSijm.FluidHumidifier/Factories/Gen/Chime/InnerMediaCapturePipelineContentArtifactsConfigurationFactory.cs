// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineContentArtifactsConfigurationFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.ContentArtifactsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.ContentArtifactsConfiguration>
{

    protected override Humidifier.Chime.MediaCapturePipelineTypes.ContentArtifactsConfiguration Create()
    {
        var contentArtifactsConfigurationResult = CreateContentArtifactsConfiguration();
        factoryAction?.Invoke(contentArtifactsConfigurationResult);

        return contentArtifactsConfigurationResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.ContentArtifactsConfiguration CreateContentArtifactsConfiguration()
    {
        var contentArtifactsConfigurationResult = new Humidifier.Chime.MediaCapturePipelineTypes.ContentArtifactsConfiguration();

        return contentArtifactsConfigurationResult;
    }

} // End Of Class

public static class InnerMediaCapturePipelineContentArtifactsConfigurationFactoryExtensions
{
}
