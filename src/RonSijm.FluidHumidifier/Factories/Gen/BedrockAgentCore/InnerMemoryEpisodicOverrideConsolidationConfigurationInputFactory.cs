// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryEpisodicOverrideConsolidationConfigurationInputFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideConsolidationConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideConsolidationConfigurationInput>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideConsolidationConfigurationInput Create()
    {
        var episodicOverrideConsolidationConfigurationInputResult = CreateEpisodicOverrideConsolidationConfigurationInput();
        factoryAction?.Invoke(episodicOverrideConsolidationConfigurationInputResult);

        return episodicOverrideConsolidationConfigurationInputResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideConsolidationConfigurationInput CreateEpisodicOverrideConsolidationConfigurationInput()
    {
        var episodicOverrideConsolidationConfigurationInputResult = new Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideConsolidationConfigurationInput();

        return episodicOverrideConsolidationConfigurationInputResult;
    }

} // End Of Class

public static class InnerMemoryEpisodicOverrideConsolidationConfigurationInputFactoryExtensions
{
}
