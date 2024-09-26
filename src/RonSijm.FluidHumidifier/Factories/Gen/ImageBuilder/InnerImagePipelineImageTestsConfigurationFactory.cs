// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImagePipelineImageTestsConfigurationFactory(Action<Humidifier.ImageBuilder.ImagePipelineTypes.ImageTestsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImagePipelineTypes.ImageTestsConfiguration>
{

    protected override Humidifier.ImageBuilder.ImagePipelineTypes.ImageTestsConfiguration Create()
    {
        var imageTestsConfigurationResult = CreateImageTestsConfiguration();
        factoryAction?.Invoke(imageTestsConfigurationResult);

        return imageTestsConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImagePipelineTypes.ImageTestsConfiguration CreateImageTestsConfiguration()
    {
        var imageTestsConfigurationResult = new Humidifier.ImageBuilder.ImagePipelineTypes.ImageTestsConfiguration();

        return imageTestsConfigurationResult;
    }

} // End Of Class

public static class InnerImagePipelineImageTestsConfigurationFactoryExtensions
{
}
