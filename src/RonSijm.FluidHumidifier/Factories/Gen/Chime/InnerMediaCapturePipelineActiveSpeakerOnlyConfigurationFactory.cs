// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineActiveSpeakerOnlyConfigurationFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.ActiveSpeakerOnlyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.ActiveSpeakerOnlyConfiguration>
{

    protected override Humidifier.Chime.MediaCapturePipelineTypes.ActiveSpeakerOnlyConfiguration Create()
    {
        var activeSpeakerOnlyConfigurationResult = CreateActiveSpeakerOnlyConfiguration();
        factoryAction?.Invoke(activeSpeakerOnlyConfigurationResult);

        return activeSpeakerOnlyConfigurationResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.ActiveSpeakerOnlyConfiguration CreateActiveSpeakerOnlyConfiguration()
    {
        var activeSpeakerOnlyConfigurationResult = new Humidifier.Chime.MediaCapturePipelineTypes.ActiveSpeakerOnlyConfiguration();

        return activeSpeakerOnlyConfigurationResult;
    }

} // End Of Class

public static class InnerMediaCapturePipelineActiveSpeakerOnlyConfigurationFactoryExtensions
{
}
