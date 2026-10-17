// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailGuardrailCrossRegionConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.GuardrailCrossRegionConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.GuardrailCrossRegionConfig>
{

    protected override Humidifier.Bedrock.GuardrailTypes.GuardrailCrossRegionConfig Create()
    {
        var guardrailCrossRegionConfigResult = CreateGuardrailCrossRegionConfig();
        factoryAction?.Invoke(guardrailCrossRegionConfigResult);

        return guardrailCrossRegionConfigResult;
    }

    private Humidifier.Bedrock.GuardrailTypes.GuardrailCrossRegionConfig CreateGuardrailCrossRegionConfig()
    {
        var guardrailCrossRegionConfigResult = new Humidifier.Bedrock.GuardrailTypes.GuardrailCrossRegionConfig();

        return guardrailCrossRegionConfigResult;
    }

} // End Of Class

public static class InnerGuardrailGuardrailCrossRegionConfigFactoryExtensions
{
}
