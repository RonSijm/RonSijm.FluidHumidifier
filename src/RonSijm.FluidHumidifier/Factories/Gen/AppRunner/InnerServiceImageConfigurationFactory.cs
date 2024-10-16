// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceImageConfigurationFactory(Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.ImageConfiguration>
{

    protected override Humidifier.AppRunner.ServiceTypes.ImageConfiguration Create()
    {
        var imageConfigurationResult = CreateImageConfiguration();
        factoryAction?.Invoke(imageConfigurationResult);

        return imageConfigurationResult;
    }

    private Humidifier.AppRunner.ServiceTypes.ImageConfiguration CreateImageConfiguration()
    {
        var imageConfigurationResult = new Humidifier.AppRunner.ServiceTypes.ImageConfiguration();

        return imageConfigurationResult;
    }

} // End Of Class

public static class InnerServiceImageConfigurationFactoryExtensions
{
}
