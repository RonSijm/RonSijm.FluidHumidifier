// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineCompositedVideoConcatenationConfigurationFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.CompositedVideoConcatenationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.CompositedVideoConcatenationConfiguration>
{

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.CompositedVideoConcatenationConfiguration Create()
    {
        var compositedVideoConcatenationConfigurationResult = CreateCompositedVideoConcatenationConfiguration();
        factoryAction?.Invoke(compositedVideoConcatenationConfigurationResult);

        return compositedVideoConcatenationConfigurationResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.CompositedVideoConcatenationConfiguration CreateCompositedVideoConcatenationConfiguration()
    {
        var compositedVideoConcatenationConfigurationResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.CompositedVideoConcatenationConfiguration();

        return compositedVideoConcatenationConfigurationResult;
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineCompositedVideoConcatenationConfigurationFactoryExtensions
{
}
