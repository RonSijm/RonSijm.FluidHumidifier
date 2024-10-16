// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerStreamProcessorKinesisVideoStreamFactory(Action<Humidifier.Rekognition.StreamProcessorTypes.KinesisVideoStream> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.StreamProcessorTypes.KinesisVideoStream>
{

    protected override Humidifier.Rekognition.StreamProcessorTypes.KinesisVideoStream Create()
    {
        var kinesisVideoStreamResult = CreateKinesisVideoStream();
        factoryAction?.Invoke(kinesisVideoStreamResult);

        return kinesisVideoStreamResult;
    }

    private Humidifier.Rekognition.StreamProcessorTypes.KinesisVideoStream CreateKinesisVideoStream()
    {
        var kinesisVideoStreamResult = new Humidifier.Rekognition.StreamProcessorTypes.KinesisVideoStream();

        return kinesisVideoStreamResult;
    }

} // End Of Class

public static class InnerStreamProcessorKinesisVideoStreamFactoryExtensions
{
}
