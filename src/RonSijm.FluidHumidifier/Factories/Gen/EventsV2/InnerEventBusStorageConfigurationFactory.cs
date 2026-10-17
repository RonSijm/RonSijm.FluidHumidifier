// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerEventBusStorageConfigurationFactory(Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.EventBusTypes.StorageConfiguration>
{

    protected override Humidifier.EventsV2.EventBusTypes.StorageConfiguration Create()
    {
        var storageConfigurationResult = CreateStorageConfiguration();
        factoryAction?.Invoke(storageConfigurationResult);

        return storageConfigurationResult;
    }

    private Humidifier.EventsV2.EventBusTypes.StorageConfiguration CreateStorageConfiguration()
    {
        var storageConfigurationResult = new Humidifier.EventsV2.EventBusTypes.StorageConfiguration();

        return storageConfigurationResult;
    }

} // End Of Class

public static class InnerEventBusStorageConfigurationFactoryExtensions
{
}
