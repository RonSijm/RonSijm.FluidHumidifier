// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaStreamPipelineMediaStreamSourceFactory(Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource>
{

    protected override Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource Create()
    {
        var mediaStreamSourceResult = CreateMediaStreamSource();
        factoryAction?.Invoke(mediaStreamSourceResult);

        return mediaStreamSourceResult;
    }

    private Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource CreateMediaStreamSource()
    {
        var mediaStreamSourceResult = new Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource();

        return mediaStreamSourceResult;
    }

} // End Of Class

public static class InnerMediaStreamPipelineMediaStreamSourceFactoryExtensions
{
}
