// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerFpgaImageStorageLocationFactory(Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> factoryAction = null) : SubResourceFactory<Humidifier.EC2.FpgaImageTypes.StorageLocation>
{

    protected override Humidifier.EC2.FpgaImageTypes.StorageLocation Create()
    {
        var storageLocationResult = CreateStorageLocation();
        factoryAction?.Invoke(storageLocationResult);

        return storageLocationResult;
    }

    private Humidifier.EC2.FpgaImageTypes.StorageLocation CreateStorageLocation()
    {
        var storageLocationResult = new Humidifier.EC2.FpgaImageTypes.StorageLocation();

        return storageLocationResult;
    }

} // End Of Class

public static class InnerFpgaImageStorageLocationFactoryExtensions
{
}
