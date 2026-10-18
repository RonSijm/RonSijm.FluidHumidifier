// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaLiveConnectorPipelinePresenterOnlyConfigurationFactory(Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.PresenterOnlyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaLiveConnectorPipelineTypes.PresenterOnlyConfiguration>
{

    protected override Humidifier.Chime.MediaLiveConnectorPipelineTypes.PresenterOnlyConfiguration Create()
    {
        var presenterOnlyConfigurationResult = CreatePresenterOnlyConfiguration();
        factoryAction?.Invoke(presenterOnlyConfigurationResult);

        return presenterOnlyConfigurationResult;
    }

    private Humidifier.Chime.MediaLiveConnectorPipelineTypes.PresenterOnlyConfiguration CreatePresenterOnlyConfiguration()
    {
        var presenterOnlyConfigurationResult = new Humidifier.Chime.MediaLiveConnectorPipelineTypes.PresenterOnlyConfiguration();

        return presenterOnlyConfigurationResult;
    }

} // End Of Class

public static class InnerMediaLiveConnectorPipelinePresenterOnlyConfigurationFactoryExtensions
{
}
