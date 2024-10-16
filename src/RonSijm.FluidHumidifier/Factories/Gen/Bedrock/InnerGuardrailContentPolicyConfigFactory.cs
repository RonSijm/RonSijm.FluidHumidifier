// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailContentPolicyConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig>
{

    protected override Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig Create()
    {
        var contentPolicyConfigResult = CreateContentPolicyConfig();
        factoryAction?.Invoke(contentPolicyConfigResult);

        return contentPolicyConfigResult;
    }

    private Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig CreateContentPolicyConfig()
    {
        var contentPolicyConfigResult = new Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig();

        return contentPolicyConfigResult;
    }

} // End Of Class

public static class InnerGuardrailContentPolicyConfigFactoryExtensions
{
}
