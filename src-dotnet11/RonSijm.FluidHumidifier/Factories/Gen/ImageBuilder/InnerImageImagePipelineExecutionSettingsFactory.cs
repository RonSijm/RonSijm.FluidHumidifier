// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageImagePipelineExecutionSettingsFactory(Action<Humidifier.ImageBuilder.ImageTypes.ImagePipelineExecutionSettings> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageTypes.ImagePipelineExecutionSettings>
{

    protected override Humidifier.ImageBuilder.ImageTypes.ImagePipelineExecutionSettings Create()
    {
        var imagePipelineExecutionSettingsResult = CreateImagePipelineExecutionSettings();
        factoryAction?.Invoke(imagePipelineExecutionSettingsResult);

        return imagePipelineExecutionSettingsResult;
    }

    private Humidifier.ImageBuilder.ImageTypes.ImagePipelineExecutionSettings CreateImagePipelineExecutionSettings()
    {
        var imagePipelineExecutionSettingsResult = new Humidifier.ImageBuilder.ImageTypes.ImagePipelineExecutionSettings();

        return imagePipelineExecutionSettingsResult;
    }

} // End Of Class

public static class InnerImageImagePipelineExecutionSettingsFactoryExtensions
{
}
