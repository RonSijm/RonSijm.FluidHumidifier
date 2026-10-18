// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationHttpRequestFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.HttpRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.HttpRequest>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.HttpRequest Create()
    {
        var httpRequestResult = CreateHttpRequest();
        factoryAction?.Invoke(httpRequestResult);

        return httpRequestResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.HttpRequest CreateHttpRequest()
    {
        var httpRequestResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.HttpRequest();

        return httpRequestResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationHttpRequestFactoryExtensions
{
}
