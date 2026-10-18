// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectAudioLanguageConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioLanguageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.AudioLanguageConfiguration>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.AudioLanguageConfiguration Create()
    {
        var audioLanguageConfigurationResult = CreateAudioLanguageConfiguration();
        factoryAction?.Invoke(audioLanguageConfigurationResult);

        return audioLanguageConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.AudioLanguageConfiguration CreateAudioLanguageConfiguration()
    {
        var audioLanguageConfigurationResult = new Humidifier.Bedrock.DataAutomationProjectTypes.AudioLanguageConfiguration();

        return audioLanguageConfigurationResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectAudioLanguageConfigurationFactoryExtensions
{
}
