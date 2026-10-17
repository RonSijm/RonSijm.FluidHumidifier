// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaStreamPipelineMediaStreamSinkFactory(Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink>
{

    protected override Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink Create()
    {
        var mediaStreamSinkResult = CreateMediaStreamSink();
        factoryAction?.Invoke(mediaStreamSinkResult);

        return mediaStreamSinkResult;
    }

    private Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink CreateMediaStreamSink()
    {
        var mediaStreamSinkResult = new Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink();

        return mediaStreamSinkResult;
    }

} // End Of Class

public static class InnerMediaStreamPipelineMediaStreamSinkFactoryExtensions
{
}
