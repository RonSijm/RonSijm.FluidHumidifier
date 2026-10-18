// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaLiveConnectorPipelineHorizontalLayoutConfigurationFactory(Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.HorizontalLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaLiveConnectorPipelineTypes.HorizontalLayoutConfiguration>
{

    protected override Humidifier.Chime.MediaLiveConnectorPipelineTypes.HorizontalLayoutConfiguration Create()
    {
        var horizontalLayoutConfigurationResult = CreateHorizontalLayoutConfiguration();
        factoryAction?.Invoke(horizontalLayoutConfigurationResult);

        return horizontalLayoutConfigurationResult;
    }

    private Humidifier.Chime.MediaLiveConnectorPipelineTypes.HorizontalLayoutConfiguration CreateHorizontalLayoutConfiguration()
    {
        var horizontalLayoutConfigurationResult = new Humidifier.Chime.MediaLiveConnectorPipelineTypes.HorizontalLayoutConfiguration();

        return horizontalLayoutConfigurationResult;
    }

} // End Of Class

public static class InnerMediaLiveConnectorPipelineHorizontalLayoutConfigurationFactoryExtensions
{
}
