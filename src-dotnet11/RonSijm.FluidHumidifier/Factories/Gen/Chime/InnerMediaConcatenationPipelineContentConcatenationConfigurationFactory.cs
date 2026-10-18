// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineContentConcatenationConfigurationFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ContentConcatenationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.ContentConcatenationConfiguration>
{

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.ContentConcatenationConfiguration Create()
    {
        var contentConcatenationConfigurationResult = CreateContentConcatenationConfiguration();
        factoryAction?.Invoke(contentConcatenationConfigurationResult);

        return contentConcatenationConfigurationResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.ContentConcatenationConfiguration CreateContentConcatenationConfiguration()
    {
        var contentConcatenationConfigurationResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.ContentConcatenationConfiguration();

        return contentConcatenationConfigurationResult;
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineContentConcatenationConfigurationFactoryExtensions
{
}
