// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotAudioFillerSettingsFactory(Action<Humidifier.Lex.BotTypes.AudioFillerSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.AudioFillerSettings>
{

    protected override Humidifier.Lex.BotTypes.AudioFillerSettings Create()
    {
        var audioFillerSettingsResult = CreateAudioFillerSettings();
        factoryAction?.Invoke(audioFillerSettingsResult);

        return audioFillerSettingsResult;
    }

    private Humidifier.Lex.BotTypes.AudioFillerSettings CreateAudioFillerSettings()
    {
        var audioFillerSettingsResult = new Humidifier.Lex.BotTypes.AudioFillerSettings();

        return audioFillerSettingsResult;
    }

} // End Of Class

public static class InnerBotAudioFillerSettingsFactoryExtensions
{
}
