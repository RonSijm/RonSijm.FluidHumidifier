// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotSpeechFoundationModelFactory(Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.SpeechFoundationModel>
{

    protected override Humidifier.Lex.BotTypes.SpeechFoundationModel Create()
    {
        var speechFoundationModelResult = CreateSpeechFoundationModel();
        factoryAction?.Invoke(speechFoundationModelResult);

        return speechFoundationModelResult;
    }

    private Humidifier.Lex.BotTypes.SpeechFoundationModel CreateSpeechFoundationModel()
    {
        var speechFoundationModelResult = new Humidifier.Lex.BotTypes.SpeechFoundationModel();

        return speechFoundationModelResult;
    }

} // End Of Class

public static class InnerBotSpeechFoundationModelFactoryExtensions
{
}
