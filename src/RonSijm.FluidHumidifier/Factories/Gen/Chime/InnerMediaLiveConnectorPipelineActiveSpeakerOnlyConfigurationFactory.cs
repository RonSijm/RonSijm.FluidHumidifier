// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaLiveConnectorPipelineActiveSpeakerOnlyConfigurationFactory(Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.ActiveSpeakerOnlyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaLiveConnectorPipelineTypes.ActiveSpeakerOnlyConfiguration>
{

    protected override Humidifier.Chime.MediaLiveConnectorPipelineTypes.ActiveSpeakerOnlyConfiguration Create()
    {
        var activeSpeakerOnlyConfigurationResult = CreateActiveSpeakerOnlyConfiguration();
        factoryAction?.Invoke(activeSpeakerOnlyConfigurationResult);

        return activeSpeakerOnlyConfigurationResult;
    }

    private Humidifier.Chime.MediaLiveConnectorPipelineTypes.ActiveSpeakerOnlyConfiguration CreateActiveSpeakerOnlyConfiguration()
    {
        var activeSpeakerOnlyConfigurationResult = new Humidifier.Chime.MediaLiveConnectorPipelineTypes.ActiveSpeakerOnlyConfiguration();

        return activeSpeakerOnlyConfigurationResult;
    }

} // End Of Class

public static class InnerMediaLiveConnectorPipelineActiveSpeakerOnlyConfigurationFactoryExtensions
{
}
