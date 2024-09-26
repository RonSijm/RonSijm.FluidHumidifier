// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerBuildStorageLocationFactory(Action<Humidifier.GameLift.BuildTypes.StorageLocation> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.BuildTypes.StorageLocation>
{

    protected override Humidifier.GameLift.BuildTypes.StorageLocation Create()
    {
        var storageLocationResult = CreateStorageLocation();
        factoryAction?.Invoke(storageLocationResult);

        return storageLocationResult;
    }

    private Humidifier.GameLift.BuildTypes.StorageLocation CreateStorageLocation()
    {
        var storageLocationResult = new Humidifier.GameLift.BuildTypes.StorageLocation();

        return storageLocationResult;
    }

} // End Of Class

public static class InnerBuildStorageLocationFactoryExtensions
{
}
