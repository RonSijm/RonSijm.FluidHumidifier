// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class VoiceChannelFactory(string resourceName = null, Action<Humidifier.Pinpoint.VoiceChannel> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.VoiceChannel>(resourceName)
{

    protected override Humidifier.Pinpoint.VoiceChannel Create()
    {
        var voiceChannelResult = CreateVoiceChannel();
        factoryAction?.Invoke(voiceChannelResult);

        return voiceChannelResult;
    }

    private Humidifier.Pinpoint.VoiceChannel CreateVoiceChannel()
    {
        var voiceChannelResult = new Humidifier.Pinpoint.VoiceChannel
        {
            GivenName = InputResourceName,
        };

        return voiceChannelResult;
    }

} // End Of Class

public static class VoiceChannelFactoryExtensions
{
}
