// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Panorama;

public class InnerPackageStorageLocationFactory(Action<Humidifier.Panorama.PackageTypes.StorageLocation> factoryAction = null) : SubResourceFactory<Humidifier.Panorama.PackageTypes.StorageLocation>
{

    protected override Humidifier.Panorama.PackageTypes.StorageLocation Create()
    {
        var storageLocationResult = CreateStorageLocation();
        factoryAction?.Invoke(storageLocationResult);

        return storageLocationResult;
    }

    private Humidifier.Panorama.PackageTypes.StorageLocation CreateStorageLocation()
    {
        var storageLocationResult = new Humidifier.Panorama.PackageTypes.StorageLocation();

        return storageLocationResult;
    }

} // End Of Class

public static class InnerPackageStorageLocationFactoryExtensions
{
}
