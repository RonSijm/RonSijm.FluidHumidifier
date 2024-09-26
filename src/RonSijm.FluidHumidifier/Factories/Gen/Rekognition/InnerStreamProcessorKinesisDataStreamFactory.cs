// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerStreamProcessorKinesisDataStreamFactory(Action<Humidifier.Rekognition.StreamProcessorTypes.KinesisDataStream> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.StreamProcessorTypes.KinesisDataStream>
{

    protected override Humidifier.Rekognition.StreamProcessorTypes.KinesisDataStream Create()
    {
        var kinesisDataStreamResult = CreateKinesisDataStream();
        factoryAction?.Invoke(kinesisDataStreamResult);

        return kinesisDataStreamResult;
    }

    private Humidifier.Rekognition.StreamProcessorTypes.KinesisDataStream CreateKinesisDataStream()
    {
        var kinesisDataStreamResult = new Humidifier.Rekognition.StreamProcessorTypes.KinesisDataStream();

        return kinesisDataStreamResult;
    }

} // End Of Class

public static class InnerStreamProcessorKinesisDataStreamFactoryExtensions
{
}
