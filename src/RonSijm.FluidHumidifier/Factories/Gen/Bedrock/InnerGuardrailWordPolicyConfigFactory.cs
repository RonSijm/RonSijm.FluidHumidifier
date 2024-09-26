// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailWordPolicyConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.WordPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.WordPolicyConfig>
{

    protected override Humidifier.Bedrock.GuardrailTypes.WordPolicyConfig Create()
    {
        var wordPolicyConfigResult = CreateWordPolicyConfig();
        factoryAction?.Invoke(wordPolicyConfigResult);

        return wordPolicyConfigResult;
    }

    private Humidifier.Bedrock.GuardrailTypes.WordPolicyConfig CreateWordPolicyConfig()
    {
        var wordPolicyConfigResult = new Humidifier.Bedrock.GuardrailTypes.WordPolicyConfig();

        return wordPolicyConfigResult;
    }

} // End Of Class

public static class InnerGuardrailWordPolicyConfigFactoryExtensions
{
}
