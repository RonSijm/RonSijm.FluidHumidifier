// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotErrorLogSettingsFactory(Action<Humidifier.Lex.BotTypes.ErrorLogSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.ErrorLogSettings>
{

    protected override Humidifier.Lex.BotTypes.ErrorLogSettings Create()
    {
        var errorLogSettingsResult = CreateErrorLogSettings();
        factoryAction?.Invoke(errorLogSettingsResult);

        return errorLogSettingsResult;
    }

    private Humidifier.Lex.BotTypes.ErrorLogSettings CreateErrorLogSettings()
    {
        var errorLogSettingsResult = new Humidifier.Lex.BotTypes.ErrorLogSettings();

        return errorLogSettingsResult;
    }

} // End Of Class

public static class InnerBotErrorLogSettingsFactoryExtensions
{
}
