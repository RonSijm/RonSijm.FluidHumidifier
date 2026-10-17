// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineVideoConcatenationConfigurationFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.VideoConcatenationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.VideoConcatenationConfiguration>
{

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.VideoConcatenationConfiguration Create()
    {
        var videoConcatenationConfigurationResult = CreateVideoConcatenationConfiguration();
        factoryAction?.Invoke(videoConcatenationConfigurationResult);

        return videoConcatenationConfigurationResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.VideoConcatenationConfiguration CreateVideoConcatenationConfiguration()
    {
        var videoConcatenationConfigurationResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.VideoConcatenationConfiguration();

        return videoConcatenationConfigurationResult;
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineVideoConcatenationConfigurationFactoryExtensions
{
}
