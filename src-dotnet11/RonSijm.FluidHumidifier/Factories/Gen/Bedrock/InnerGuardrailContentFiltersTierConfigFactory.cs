// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailContentFiltersTierConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig>
{

    protected override Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig Create()
    {
        var contentFiltersTierConfigResult = CreateContentFiltersTierConfig();
        factoryAction?.Invoke(contentFiltersTierConfigResult);

        return contentFiltersTierConfigResult;
    }

    private Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig CreateContentFiltersTierConfig()
    {
        var contentFiltersTierConfigResult = new Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig();

        return contentFiltersTierConfigResult;
    }

} // End Of Class

public static class InnerGuardrailContentFiltersTierConfigFactoryExtensions
{
}
