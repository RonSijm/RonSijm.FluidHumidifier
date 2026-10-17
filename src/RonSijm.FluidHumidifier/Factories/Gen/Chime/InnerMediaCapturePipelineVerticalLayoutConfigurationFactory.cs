// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineVerticalLayoutConfigurationFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.VerticalLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.VerticalLayoutConfiguration>
{

    protected override Humidifier.Chime.MediaCapturePipelineTypes.VerticalLayoutConfiguration Create()
    {
        var verticalLayoutConfigurationResult = CreateVerticalLayoutConfiguration();
        factoryAction?.Invoke(verticalLayoutConfigurationResult);

        return verticalLayoutConfigurationResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.VerticalLayoutConfiguration CreateVerticalLayoutConfiguration()
    {
        var verticalLayoutConfigurationResult = new Humidifier.Chime.MediaCapturePipelineTypes.VerticalLayoutConfiguration();

        return verticalLayoutConfigurationResult;
    }

} // End Of Class

public static class InnerMediaCapturePipelineVerticalLayoutConfigurationFactoryExtensions
{
}
