// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EFS;

public class InnerFileSystemFileSystemProtectionFactory(Action<Humidifier.EFS.FileSystemTypes.FileSystemProtection> factoryAction = null) : SubResourceFactory<Humidifier.EFS.FileSystemTypes.FileSystemProtection>
{

    protected override Humidifier.EFS.FileSystemTypes.FileSystemProtection Create()
    {
        var fileSystemProtectionResult = CreateFileSystemProtection();
        factoryAction?.Invoke(fileSystemProtectionResult);

        return fileSystemProtectionResult;
    }

    private Humidifier.EFS.FileSystemTypes.FileSystemProtection CreateFileSystemProtection()
    {
        var fileSystemProtectionResult = new Humidifier.EFS.FileSystemTypes.FileSystemProtection();

        return fileSystemProtectionResult;
    }

} // End Of Class

public static class InnerFileSystemFileSystemProtectionFactoryExtensions
{
}
