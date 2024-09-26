// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageImageTestsConfigurationFactory(Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration>
{

    protected override Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration Create()
    {
        var imageTestsConfigurationResult = CreateImageTestsConfiguration();
        factoryAction?.Invoke(imageTestsConfigurationResult);

        return imageTestsConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration CreateImageTestsConfiguration()
    {
        var imageTestsConfigurationResult = new Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration();

        return imageTestsConfigurationResult;
    }

} // End Of Class

public static class InnerImageImageTestsConfigurationFactoryExtensions
{
}
