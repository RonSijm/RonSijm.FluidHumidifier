// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class VoiceConnectorFactory(string resourceName = null, Action<Humidifier.Chime.VoiceConnector> factoryAction = null) : ResourceFactory<Humidifier.Chime.VoiceConnector>(resourceName)
{

    protected override Humidifier.Chime.VoiceConnector Create()
    {
        var voiceConnectorResult = CreateVoiceConnector();
        factoryAction?.Invoke(voiceConnectorResult);

        return voiceConnectorResult;
    }

    private Humidifier.Chime.VoiceConnector CreateVoiceConnector()
    {
        var voiceConnectorResult = new Humidifier.Chime.VoiceConnector
        {
            GivenName = InputResourceName,
        };

        return voiceConnectorResult;
    }

} // End Of Class

public static class VoiceConnectorFactoryExtensions
{
}
