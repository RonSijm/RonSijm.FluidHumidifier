// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotAliasConversationLogSettingsFactory(Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotAliasTypes.ConversationLogSettings>
{

    protected override Humidifier.Lex.BotAliasTypes.ConversationLogSettings Create()
    {
        var conversationLogSettingsResult = CreateConversationLogSettings();
        factoryAction?.Invoke(conversationLogSettingsResult);

        return conversationLogSettingsResult;
    }

    private Humidifier.Lex.BotAliasTypes.ConversationLogSettings CreateConversationLogSettings()
    {
        var conversationLogSettingsResult = new Humidifier.Lex.BotAliasTypes.ConversationLogSettings();

        return conversationLogSettingsResult;
    }

} // End Of Class

public static class InnerBotAliasConversationLogSettingsFactoryExtensions
{
}
