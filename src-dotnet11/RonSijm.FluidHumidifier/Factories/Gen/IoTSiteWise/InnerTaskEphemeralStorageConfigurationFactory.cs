// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerTaskEphemeralStorageConfigurationFactory(Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration>
{

    protected override Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration Create()
    {
        var ephemeralStorageConfigurationResult = CreateEphemeralStorageConfiguration();
        factoryAction?.Invoke(ephemeralStorageConfigurationResult);

        return ephemeralStorageConfigurationResult;
    }

    private Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration CreateEphemeralStorageConfiguration()
    {
        var ephemeralStorageConfigurationResult = new Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration();

        return ephemeralStorageConfigurationResult;
    }

} // End Of Class

public static class InnerTaskEphemeralStorageConfigurationFactoryExtensions
{
}
