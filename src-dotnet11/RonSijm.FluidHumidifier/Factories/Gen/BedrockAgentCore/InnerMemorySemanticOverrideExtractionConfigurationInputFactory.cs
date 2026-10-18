// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemorySemanticOverrideExtractionConfigurationInputFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideExtractionConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideExtractionConfigurationInput>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideExtractionConfigurationInput Create()
    {
        var semanticOverrideExtractionConfigurationInputResult = CreateSemanticOverrideExtractionConfigurationInput();
        factoryAction?.Invoke(semanticOverrideExtractionConfigurationInputResult);

        return semanticOverrideExtractionConfigurationInputResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideExtractionConfigurationInput CreateSemanticOverrideExtractionConfigurationInput()
    {
        var semanticOverrideExtractionConfigurationInputResult = new Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideExtractionConfigurationInput();

        return semanticOverrideExtractionConfigurationInputResult;
    }

} // End Of Class

public static class InnerMemorySemanticOverrideExtractionConfigurationInputFactoryExtensions
{
}
