// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryUserPreferenceOverrideExtractionConfigurationInputFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideExtractionConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideExtractionConfigurationInput>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideExtractionConfigurationInput Create()
    {
        var userPreferenceOverrideExtractionConfigurationInputResult = CreateUserPreferenceOverrideExtractionConfigurationInput();
        factoryAction?.Invoke(userPreferenceOverrideExtractionConfigurationInputResult);

        return userPreferenceOverrideExtractionConfigurationInputResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideExtractionConfigurationInput CreateUserPreferenceOverrideExtractionConfigurationInput()
    {
        var userPreferenceOverrideExtractionConfigurationInputResult = new Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideExtractionConfigurationInput();

        return userPreferenceOverrideExtractionConfigurationInputResult;
    }

} // End Of Class

public static class InnerMemoryUserPreferenceOverrideExtractionConfigurationInputFactoryExtensions
{
}
