// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryUserPreferenceOverrideConsolidationConfigurationInputFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideConsolidationConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideConsolidationConfigurationInput>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideConsolidationConfigurationInput Create()
    {
        var userPreferenceOverrideConsolidationConfigurationInputResult = CreateUserPreferenceOverrideConsolidationConfigurationInput();
        factoryAction?.Invoke(userPreferenceOverrideConsolidationConfigurationInputResult);

        return userPreferenceOverrideConsolidationConfigurationInputResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideConsolidationConfigurationInput CreateUserPreferenceOverrideConsolidationConfigurationInput()
    {
        var userPreferenceOverrideConsolidationConfigurationInputResult = new Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideConsolidationConfigurationInput();

        return userPreferenceOverrideConsolidationConfigurationInputResult;
    }

} // End Of Class

public static class InnerMemoryUserPreferenceOverrideConsolidationConfigurationInputFactoryExtensions
{
}
