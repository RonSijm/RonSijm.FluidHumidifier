// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotVersionBotVersionLocaleDetailsFactory(Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails>
{

    protected override Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails Create()
    {
        var botVersionLocaleDetailsResult = CreateBotVersionLocaleDetails();
        factoryAction?.Invoke(botVersionLocaleDetailsResult);

        return botVersionLocaleDetailsResult;
    }

    private Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails CreateBotVersionLocaleDetails()
    {
        var botVersionLocaleDetailsResult = new Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails();

        return botVersionLocaleDetailsResult;
    }

} // End Of Class

public static class InnerBotVersionBotVersionLocaleDetailsFactoryExtensions
{
}
