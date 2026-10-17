// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaLiveConnectorPipelineVerticalLayoutConfigurationFactory(Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.VerticalLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaLiveConnectorPipelineTypes.VerticalLayoutConfiguration>
{

    protected override Humidifier.Chime.MediaLiveConnectorPipelineTypes.VerticalLayoutConfiguration Create()
    {
        var verticalLayoutConfigurationResult = CreateVerticalLayoutConfiguration();
        factoryAction?.Invoke(verticalLayoutConfigurationResult);

        return verticalLayoutConfigurationResult;
    }

    private Humidifier.Chime.MediaLiveConnectorPipelineTypes.VerticalLayoutConfiguration CreateVerticalLayoutConfiguration()
    {
        var verticalLayoutConfigurationResult = new Humidifier.Chime.MediaLiveConnectorPipelineTypes.VerticalLayoutConfiguration();

        return verticalLayoutConfigurationResult;
    }

} // End Of Class

public static class InnerMediaLiveConnectorPipelineVerticalLayoutConfigurationFactoryExtensions
{
}
