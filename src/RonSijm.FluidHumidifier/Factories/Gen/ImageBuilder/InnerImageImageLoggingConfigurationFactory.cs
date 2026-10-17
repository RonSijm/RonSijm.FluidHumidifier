// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageImageLoggingConfigurationFactory(Action<Humidifier.ImageBuilder.ImageTypes.ImageLoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageTypes.ImageLoggingConfiguration>
{

    protected override Humidifier.ImageBuilder.ImageTypes.ImageLoggingConfiguration Create()
    {
        var imageLoggingConfigurationResult = CreateImageLoggingConfiguration();
        factoryAction?.Invoke(imageLoggingConfigurationResult);

        return imageLoggingConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImageTypes.ImageLoggingConfiguration CreateImageLoggingConfiguration()
    {
        var imageLoggingConfigurationResult = new Humidifier.ImageBuilder.ImageTypes.ImageLoggingConfiguration();

        return imageLoggingConfigurationResult;
    }

} // End Of Class

public static class InnerImageImageLoggingConfigurationFactoryExtensions
{
}
