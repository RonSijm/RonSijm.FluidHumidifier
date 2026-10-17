// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineHorizontalLayoutConfigurationFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.HorizontalLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.HorizontalLayoutConfiguration>
{

    protected override Humidifier.Chime.MediaCapturePipelineTypes.HorizontalLayoutConfiguration Create()
    {
        var horizontalLayoutConfigurationResult = CreateHorizontalLayoutConfiguration();
        factoryAction?.Invoke(horizontalLayoutConfigurationResult);

        return horizontalLayoutConfigurationResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.HorizontalLayoutConfiguration CreateHorizontalLayoutConfiguration()
    {
        var horizontalLayoutConfigurationResult = new Humidifier.Chime.MediaCapturePipelineTypes.HorizontalLayoutConfiguration();

        return horizontalLayoutConfigurationResult;
    }

} // End Of Class

public static class InnerMediaCapturePipelineHorizontalLayoutConfigurationFactoryExtensions
{
}
