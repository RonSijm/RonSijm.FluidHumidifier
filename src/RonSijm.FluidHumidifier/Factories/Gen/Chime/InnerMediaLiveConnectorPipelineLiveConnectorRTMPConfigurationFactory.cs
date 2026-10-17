// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory(Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration>
{

    protected override Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration Create()
    {
        var liveConnectorRTMPConfigurationResult = CreateLiveConnectorRTMPConfiguration();
        factoryAction?.Invoke(liveConnectorRTMPConfigurationResult);

        return liveConnectorRTMPConfigurationResult;
    }

    private Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration CreateLiveConnectorRTMPConfiguration()
    {
        var liveConnectorRTMPConfigurationResult = new Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration();

        return liveConnectorRTMPConfigurationResult;
    }

} // End Of Class

public static class InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactoryExtensions
{
}
