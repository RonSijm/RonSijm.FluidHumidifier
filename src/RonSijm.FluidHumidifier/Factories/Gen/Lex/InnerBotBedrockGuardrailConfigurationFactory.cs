// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotBedrockGuardrailConfigurationFactory(Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration>
{

    protected override Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration Create()
    {
        var bedrockGuardrailConfigurationResult = CreateBedrockGuardrailConfiguration();
        factoryAction?.Invoke(bedrockGuardrailConfigurationResult);

        return bedrockGuardrailConfigurationResult;
    }

    private Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration CreateBedrockGuardrailConfiguration()
    {
        var bedrockGuardrailConfigurationResult = new Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration();

        return bedrockGuardrailConfigurationResult;
    }

} // End Of Class

public static class InnerBotBedrockGuardrailConfigurationFactoryExtensions
{
}
