// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotDataPrivacyFactory(Action<Humidifier.Lex.BotTypes.DataPrivacy> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.DataPrivacy>
{

    protected override Humidifier.Lex.BotTypes.DataPrivacy Create()
    {
        var dataPrivacyResult = CreateDataPrivacy();
        factoryAction?.Invoke(dataPrivacyResult);

        return dataPrivacyResult;
    }

    private Humidifier.Lex.BotTypes.DataPrivacy CreateDataPrivacy()
    {
        var dataPrivacyResult = new Humidifier.Lex.BotTypes.DataPrivacy();

        return dataPrivacyResult;
    }

} // End Of Class

public static class InnerBotDataPrivacyFactoryExtensions
{
}
