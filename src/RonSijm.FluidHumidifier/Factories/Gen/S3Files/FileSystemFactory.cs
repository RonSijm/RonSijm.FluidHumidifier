// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Files;

public class FileSystemFactory(string resourceName = null, Action<Humidifier.S3Files.FileSystem> factoryAction = null) : ResourceFactory<Humidifier.S3Files.FileSystem>(resourceName)
{

    internal InnerFileSystemSynchronizationConfigurationFactory SynchronizationConfigurationFactory { get; set; }

    protected override Humidifier.S3Files.FileSystem Create()
    {
        var fileSystemResult = CreateFileSystem();
        factoryAction?.Invoke(fileSystemResult);

        return fileSystemResult;
    }

    private Humidifier.S3Files.FileSystem CreateFileSystem()
    {
        var fileSystemResult = new Humidifier.S3Files.FileSystem
        {
            GivenName = InputResourceName,
        };

        return fileSystemResult;
    }
    public override void CreateChildren(Humidifier.S3Files.FileSystem result)
    {
        base.CreateChildren(result);

        result.SynchronizationConfiguration ??= SynchronizationConfigurationFactory?.Build();
    }

} // End Of Class

public static class FileSystemFactoryExtensions
{
    public static CombinedResult<FileSystemFactory, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration(this FileSystemFactory parentFactory, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null)
    {
        parentFactory.SynchronizationConfigurationFactory = new InnerFileSystemSynchronizationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SynchronizationConfigurationFactory);
    }

    public static CombinedResult<FileSystemFactory, T1, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1>(this CombinedResult<FileSystemFactory, T1> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileSystemFactory, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1>(this CombinedResult<T1, FileSystemFactory> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FileSystemFactory, T1, T2, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2>(this CombinedResult<FileSystemFactory, T1, T2> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileSystemFactory, T2, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2>(this CombinedResult<T1, FileSystemFactory, T2> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FileSystemFactory, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2>(this CombinedResult<T1, T2, FileSystemFactory> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FileSystemFactory, T1, T2, T3, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2, T3>(this CombinedResult<FileSystemFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileSystemFactory, T2, T3, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2, T3>(this CombinedResult<T1, FileSystemFactory, T2, T3> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FileSystemFactory, T3, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, FileSystemFactory, T3> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FileSystemFactory, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, FileSystemFactory> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FileSystemFactory, T1, T2, T3, T4, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2, T3, T4>(this CombinedResult<FileSystemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileSystemFactory, T2, T3, T4, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, FileSystemFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FileSystemFactory, T3, T4, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, FileSystemFactory, T3, T4> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FileSystemFactory, T4, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FileSystemFactory, T4> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FileSystemFactory, InnerFileSystemSynchronizationConfigurationFactory> WithSynchronizationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FileSystemFactory> combinedResult, Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSynchronizationConfiguration(combinedResult.T5, subFactoryAction).T2);
}
