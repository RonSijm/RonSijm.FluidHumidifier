// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemorySemanticOverrideConsolidationConfigurationInputFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideConsolidationConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideConsolidationConfigurationInput>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideConsolidationConfigurationInput Create()
    {
        var semanticOverrideConsolidationConfigurationInputResult = CreateSemanticOverrideConsolidationConfigurationInput();
        factoryAction?.Invoke(semanticOverrideConsolidationConfigurationInputResult);

        return semanticOverrideConsolidationConfigurationInputResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideConsolidationConfigurationInput CreateSemanticOverrideConsolidationConfigurationInput()
    {
        var semanticOverrideConsolidationConfigurationInputResult = new Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideConsolidationConfigurationInput();

        return semanticOverrideConsolidationConfigurationInputResult;
    }

} // End Of Class

public static class InnerMemorySemanticOverrideConsolidationConfigurationInputFactoryExtensions
{
}
