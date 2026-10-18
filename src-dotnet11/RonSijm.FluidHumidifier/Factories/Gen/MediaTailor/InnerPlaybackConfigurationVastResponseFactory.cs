// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationVastResponseFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.VastResponse> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.VastResponse>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.VastResponse Create()
    {
        var vastResponseResult = CreateVastResponse();
        factoryAction?.Invoke(vastResponseResult);

        return vastResponseResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.VastResponse CreateVastResponse()
    {
        var vastResponseResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.VastResponse();

        return vastResponseResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationVastResponseFactoryExtensions
{
}
