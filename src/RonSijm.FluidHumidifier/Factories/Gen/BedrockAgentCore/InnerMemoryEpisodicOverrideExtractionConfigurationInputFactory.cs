// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryEpisodicOverrideExtractionConfigurationInputFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideExtractionConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideExtractionConfigurationInput>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideExtractionConfigurationInput Create()
    {
        var episodicOverrideExtractionConfigurationInputResult = CreateEpisodicOverrideExtractionConfigurationInput();
        factoryAction?.Invoke(episodicOverrideExtractionConfigurationInputResult);

        return episodicOverrideExtractionConfigurationInputResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideExtractionConfigurationInput CreateEpisodicOverrideExtractionConfigurationInput()
    {
        var episodicOverrideExtractionConfigurationInputResult = new Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideExtractionConfigurationInput();

        return episodicOverrideExtractionConfigurationInputResult;
    }

} // End Of Class

public static class InnerMemoryEpisodicOverrideExtractionConfigurationInputFactoryExtensions
{
}
