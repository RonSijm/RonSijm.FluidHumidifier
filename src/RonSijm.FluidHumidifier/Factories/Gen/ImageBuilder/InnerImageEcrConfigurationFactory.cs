// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageEcrConfigurationFactory(Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration>
{

    protected override Humidifier.ImageBuilder.ImageTypes.EcrConfiguration Create()
    {
        var ecrConfigurationResult = CreateEcrConfiguration();
        factoryAction?.Invoke(ecrConfigurationResult);

        return ecrConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImageTypes.EcrConfiguration CreateEcrConfiguration()
    {
        var ecrConfigurationResult = new Humidifier.ImageBuilder.ImageTypes.EcrConfiguration();

        return ecrConfigurationResult;
    }

} // End Of Class

public static class InnerImageEcrConfigurationFactoryExtensions
{
}
