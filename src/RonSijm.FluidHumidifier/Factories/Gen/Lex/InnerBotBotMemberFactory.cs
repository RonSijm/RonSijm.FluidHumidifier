// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotBotMemberFactory(Action<Humidifier.Lex.BotTypes.BotMember> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.BotMember>
{

    protected override Humidifier.Lex.BotTypes.BotMember Create()
    {
        var botMemberResult = CreateBotMember();
        factoryAction?.Invoke(botMemberResult);

        return botMemberResult;
    }

    private Humidifier.Lex.BotTypes.BotMember CreateBotMember()
    {
        var botMemberResult = new Humidifier.Lex.BotTypes.BotMember();

        return botMemberResult;
    }

} // End Of Class

public static class InnerBotBotMemberFactoryExtensions
{
}
