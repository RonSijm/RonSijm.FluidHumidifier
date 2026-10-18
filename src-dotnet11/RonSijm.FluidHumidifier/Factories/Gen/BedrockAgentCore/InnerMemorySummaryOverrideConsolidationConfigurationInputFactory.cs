// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemorySummaryOverrideConsolidationConfigurationInputFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput Create()
    {
        var summaryOverrideConsolidationConfigurationInputResult = CreateSummaryOverrideConsolidationConfigurationInput();
        factoryAction?.Invoke(summaryOverrideConsolidationConfigurationInputResult);

        return summaryOverrideConsolidationConfigurationInputResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput CreateSummaryOverrideConsolidationConfigurationInput()
    {
        var summaryOverrideConsolidationConfigurationInputResult = new Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput();

        return summaryOverrideConsolidationConfigurationInputResult;
    }

} // End Of Class

public static class InnerMemorySummaryOverrideConsolidationConfigurationInputFactoryExtensions
{
}
