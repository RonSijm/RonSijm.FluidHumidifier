// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationObjectStorageFactory(string resourceName = null, Action<Humidifier.DataSync.LocationObjectStorage> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationObjectStorage>(resourceName)
{

    protected override Humidifier.DataSync.LocationObjectStorage Create()
    {
        var locationObjectStorageResult = CreateLocationObjectStorage();
        factoryAction?.Invoke(locationObjectStorageResult);

        return locationObjectStorageResult;
    }

    private Humidifier.DataSync.LocationObjectStorage CreateLocationObjectStorage()
    {
        var locationObjectStorageResult = new Humidifier.DataSync.LocationObjectStorage
        {
            GivenName = InputResourceName,
        };

        return locationObjectStorageResult;
    }

} // End Of Class

public static class LocationObjectStorageFactoryExtensions
{
}
