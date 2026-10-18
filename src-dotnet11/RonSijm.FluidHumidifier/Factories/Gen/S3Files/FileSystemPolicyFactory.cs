// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Files;

public class FileSystemPolicyFactory(string resourceName = null, Action<Humidifier.S3Files.FileSystemPolicy> factoryAction = null) : ResourceFactory<Humidifier.S3Files.FileSystemPolicy>(resourceName)
{

    protected override Humidifier.S3Files.FileSystemPolicy Create()
    {
        var fileSystemPolicyResult = CreateFileSystemPolicy();
        factoryAction?.Invoke(fileSystemPolicyResult);

        return fileSystemPolicyResult;
    }

    private Humidifier.S3Files.FileSystemPolicy CreateFileSystemPolicy()
    {
        var fileSystemPolicyResult = new Humidifier.S3Files.FileSystemPolicy
        {
            GivenName = InputResourceName,
        };

        return fileSystemPolicyResult;
    }

} // End Of Class

public static class FileSystemPolicyFactoryExtensions
{
}
