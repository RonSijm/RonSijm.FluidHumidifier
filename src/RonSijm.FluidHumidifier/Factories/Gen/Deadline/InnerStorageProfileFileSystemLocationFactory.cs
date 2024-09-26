// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerStorageProfileFileSystemLocationFactory(Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation>
{

    protected override Humidifier.Deadline.StorageProfileTypes.FileSystemLocation Create()
    {
        var fileSystemLocationResult = CreateFileSystemLocation();
        factoryAction?.Invoke(fileSystemLocationResult);

        return fileSystemLocationResult;
    }

    private Humidifier.Deadline.StorageProfileTypes.FileSystemLocation CreateFileSystemLocation()
    {
        var fileSystemLocationResult = new Humidifier.Deadline.StorageProfileTypes.FileSystemLocation();

        return fileSystemLocationResult;
    }

} // End Of Class

public static class InnerStorageProfileFileSystemLocationFactoryExtensions
{
}
