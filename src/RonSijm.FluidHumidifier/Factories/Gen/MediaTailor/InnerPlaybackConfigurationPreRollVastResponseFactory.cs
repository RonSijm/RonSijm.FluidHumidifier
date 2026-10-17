// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationPreRollVastResponseFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse Create()
    {
        var preRollVastResponseResult = CreatePreRollVastResponse();
        factoryAction?.Invoke(preRollVastResponseResult);

        return preRollVastResponseResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse CreatePreRollVastResponse()
    {
        var preRollVastResponseResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse();

        return preRollVastResponseResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationPreRollVastResponseFactoryExtensions
{
}
