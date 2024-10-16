// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class StreamingImageFactory(string resourceName = null, Action<Humidifier.NimbleStudio.StreamingImage> factoryAction = null) : ResourceFactory<Humidifier.NimbleStudio.StreamingImage>(resourceName)
{

    protected override Humidifier.NimbleStudio.StreamingImage Create()
    {
        var streamingImageResult = CreateStreamingImage();
        factoryAction?.Invoke(streamingImageResult);

        return streamingImageResult;
    }

    private Humidifier.NimbleStudio.StreamingImage CreateStreamingImage()
    {
        var streamingImageResult = new Humidifier.NimbleStudio.StreamingImage
        {
            GivenName = InputResourceName,
        };

        return streamingImageResult;
    }

} // End Of Class

public static class StreamingImageFactoryExtensions
{
}
