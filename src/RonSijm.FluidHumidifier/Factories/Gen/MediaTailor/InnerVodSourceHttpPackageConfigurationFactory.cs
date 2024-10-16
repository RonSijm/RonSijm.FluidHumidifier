// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerVodSourceHttpPackageConfigurationFactory(Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration>
{

    protected override Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration Create()
    {
        var httpPackageConfigurationResult = CreateHttpPackageConfiguration();
        factoryAction?.Invoke(httpPackageConfigurationResult);

        return httpPackageConfigurationResult;
    }

    private Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration CreateHttpPackageConfiguration()
    {
        var httpPackageConfigurationResult = new Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration();

        return httpPackageConfigurationResult;
    }

} // End Of Class

public static class InnerVodSourceHttpPackageConfigurationFactoryExtensions
{
}
