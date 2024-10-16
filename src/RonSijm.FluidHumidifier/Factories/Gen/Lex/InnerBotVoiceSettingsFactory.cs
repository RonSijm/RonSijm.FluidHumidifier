// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotVoiceSettingsFactory(Action<Humidifier.Lex.BotTypes.VoiceSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.VoiceSettings>
{

    protected override Humidifier.Lex.BotTypes.VoiceSettings Create()
    {
        var voiceSettingsResult = CreateVoiceSettings();
        factoryAction?.Invoke(voiceSettingsResult);

        return voiceSettingsResult;
    }

    private Humidifier.Lex.BotTypes.VoiceSettings CreateVoiceSettings()
    {
        var voiceSettingsResult = new Humidifier.Lex.BotTypes.VoiceSettings();

        return voiceSettingsResult;
    }

} // End Of Class

public static class InnerBotVoiceSettingsFactoryExtensions
{
}
