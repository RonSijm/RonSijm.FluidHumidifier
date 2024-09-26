// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptPromptModelInferenceConfigurationFactory(Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration>
{

    protected override Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration Create()
    {
        var promptModelInferenceConfigurationResult = CreatePromptModelInferenceConfiguration();
        factoryAction?.Invoke(promptModelInferenceConfigurationResult);

        return promptModelInferenceConfigurationResult;
    }

    private Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration CreatePromptModelInferenceConfiguration()
    {
        var promptModelInferenceConfigurationResult = new Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration();

        return promptModelInferenceConfigurationResult;
    }

} // End Of Class

public static class InnerPromptPromptModelInferenceConfigurationFactoryExtensions
{
}
