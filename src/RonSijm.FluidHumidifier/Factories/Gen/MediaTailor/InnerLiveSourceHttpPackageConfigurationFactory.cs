// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerLiveSourceHttpPackageConfigurationFactory(Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration>
{

    protected override Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration Create()
    {
        var httpPackageConfigurationResult = CreateHttpPackageConfiguration();
        factoryAction?.Invoke(httpPackageConfigurationResult);

        return httpPackageConfigurationResult;
    }

    private Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration CreateHttpPackageConfiguration()
    {
        var httpPackageConfigurationResult = new Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration();

        return httpPackageConfigurationResult;
    }

} // End Of Class

public static class InnerLiveSourceHttpPackageConfigurationFactoryExtensions
{
}
