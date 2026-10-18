// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetVersioningConfigurationFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.VersioningConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.VersioningConfiguration>
{

    protected override Humidifier.IoTAnalytics.DatasetTypes.VersioningConfiguration Create()
    {
        var versioningConfigurationResult = CreateVersioningConfiguration();
        factoryAction?.Invoke(versioningConfigurationResult);

        return versioningConfigurationResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.VersioningConfiguration CreateVersioningConfiguration()
    {
        var versioningConfigurationResult = new Humidifier.IoTAnalytics.DatasetTypes.VersioningConfiguration();

        return versioningConfigurationResult;
    }

} // End Of Class

public static class InnerDatasetVersioningConfigurationFactoryExtensions
{
}
