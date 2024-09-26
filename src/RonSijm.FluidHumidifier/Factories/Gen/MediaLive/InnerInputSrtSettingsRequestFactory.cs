// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputSrtSettingsRequestFactory(Action<Humidifier.MediaLive.InputTypes.SrtSettingsRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.SrtSettingsRequest>
{

    protected override Humidifier.MediaLive.InputTypes.SrtSettingsRequest Create()
    {
        var srtSettingsRequestResult = CreateSrtSettingsRequest();
        factoryAction?.Invoke(srtSettingsRequestResult);

        return srtSettingsRequestResult;
    }

    private Humidifier.MediaLive.InputTypes.SrtSettingsRequest CreateSrtSettingsRequest()
    {
        var srtSettingsRequestResult = new Humidifier.MediaLive.InputTypes.SrtSettingsRequest();

        return srtSettingsRequestResult;
    }

} // End Of Class

public static class InnerInputSrtSettingsRequestFactoryExtensions
{
}
