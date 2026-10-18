// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotIntentDisambiguationSettingsFactory(Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.IntentDisambiguationSettings>
{

    protected override Humidifier.Lex.BotTypes.IntentDisambiguationSettings Create()
    {
        var intentDisambiguationSettingsResult = CreateIntentDisambiguationSettings();
        factoryAction?.Invoke(intentDisambiguationSettingsResult);

        return intentDisambiguationSettingsResult;
    }

    private Humidifier.Lex.BotTypes.IntentDisambiguationSettings CreateIntentDisambiguationSettings()
    {
        var intentDisambiguationSettingsResult = new Humidifier.Lex.BotTypes.IntentDisambiguationSettings();

        return intentDisambiguationSettingsResult;
    }

} // End Of Class

public static class InnerBotIntentDisambiguationSettingsFactoryExtensions
{
}
