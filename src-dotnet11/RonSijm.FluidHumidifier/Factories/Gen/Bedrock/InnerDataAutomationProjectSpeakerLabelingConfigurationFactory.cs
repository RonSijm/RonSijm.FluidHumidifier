// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectSpeakerLabelingConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.SpeakerLabelingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.SpeakerLabelingConfiguration>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.SpeakerLabelingConfiguration Create()
    {
        var speakerLabelingConfigurationResult = CreateSpeakerLabelingConfiguration();
        factoryAction?.Invoke(speakerLabelingConfigurationResult);

        return speakerLabelingConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.SpeakerLabelingConfiguration CreateSpeakerLabelingConfiguration()
    {
        var speakerLabelingConfigurationResult = new Humidifier.Bedrock.DataAutomationProjectTypes.SpeakerLabelingConfiguration();

        return speakerLabelingConfigurationResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectSpeakerLabelingConfigurationFactoryExtensions
{
}
