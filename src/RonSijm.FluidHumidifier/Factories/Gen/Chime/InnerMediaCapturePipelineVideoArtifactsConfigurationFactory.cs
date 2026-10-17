// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineVideoArtifactsConfigurationFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.VideoArtifactsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.VideoArtifactsConfiguration>
{

    protected override Humidifier.Chime.MediaCapturePipelineTypes.VideoArtifactsConfiguration Create()
    {
        var videoArtifactsConfigurationResult = CreateVideoArtifactsConfiguration();
        factoryAction?.Invoke(videoArtifactsConfigurationResult);

        return videoArtifactsConfigurationResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.VideoArtifactsConfiguration CreateVideoArtifactsConfiguration()
    {
        var videoArtifactsConfigurationResult = new Humidifier.Chime.MediaCapturePipelineTypes.VideoArtifactsConfiguration();

        return videoArtifactsConfigurationResult;
    }

} // End Of Class

public static class InnerMediaCapturePipelineVideoArtifactsConfigurationFactoryExtensions
{
}
