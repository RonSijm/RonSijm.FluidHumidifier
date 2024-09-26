// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotConversationLogSettingsFactory(Action<Humidifier.Lex.BotTypes.ConversationLogSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.ConversationLogSettings>
{

    protected override Humidifier.Lex.BotTypes.ConversationLogSettings Create()
    {
        var conversationLogSettingsResult = CreateConversationLogSettings();
        factoryAction?.Invoke(conversationLogSettingsResult);

        return conversationLogSettingsResult;
    }

    private Humidifier.Lex.BotTypes.ConversationLogSettings CreateConversationLogSettings()
    {
        var conversationLogSettingsResult = new Humidifier.Lex.BotTypes.ConversationLogSettings();

        return conversationLogSettingsResult;
    }

} // End Of Class

public static class InnerBotConversationLogSettingsFactoryExtensions
{
}
