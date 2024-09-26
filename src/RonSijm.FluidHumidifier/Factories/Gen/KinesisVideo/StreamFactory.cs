// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisVideo;

public class StreamFactory(string resourceName = null, Action<Humidifier.KinesisVideo.Stream> factoryAction = null) : ResourceFactory<Humidifier.KinesisVideo.Stream>(resourceName)
{

    protected override Humidifier.KinesisVideo.Stream Create()
    {
        var streamResult = CreateStream();
        factoryAction?.Invoke(streamResult);

        return streamResult;
    }

    private Humidifier.KinesisVideo.Stream CreateStream()
    {
        var streamResult = new Humidifier.KinesisVideo.Stream
        {
            GivenName = InputResourceName,
        };

        return streamResult;
    }

} // End Of Class

public static class StreamFactoryExtensions
{
}
