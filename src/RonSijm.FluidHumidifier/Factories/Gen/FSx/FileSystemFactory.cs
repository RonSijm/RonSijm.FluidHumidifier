// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class FileSystemFactory(string resourceName = null, Action<Humidifier.FSx.FileSystem> factoryAction = null) : ResourceFactory<Humidifier.FSx.FileSystem>(resourceName)
{

    internal InnerFileSystemLustreConfigurationFactory LustreConfigurationFactory { get; set; }

    internal InnerFileSystemOntapConfigurationFactory OntapConfigurationFactory { get; set; }

    internal InnerFileSystemWindowsConfigurationFactory WindowsConfigurationFactory { get; set; }

    internal InnerFileSystemOpenZFSConfigurationFactory OpenZFSConfigurationFactory { get; set; }

    protected override Humidifier.FSx.FileSystem Create()
    {
        var fileSystemResult = CreateFileSystem();
        factoryAction?.Invoke(fileSystemResult);

        return fileSystemResult;
    }

    private Humidifier.FSx.FileSystem CreateFileSystem()
    {
        var fileSystemResult = new Humidifier.FSx.FileSystem
        {
            GivenName = InputResourceName,
        };

        return fileSystemResult;
    }
    public override void CreateChildren(Humidifier.FSx.FileSystem result)
    {
        base.CreateChildren(result);

        result.LustreConfiguration ??= LustreConfigurationFactory?.Build();
        result.OntapConfiguration ??= OntapConfigurationFactory?.Build();
        result.WindowsConfiguration ??= WindowsConfigurationFactory?.Build();
        result.OpenZFSConfiguration ??= OpenZFSConfigurationFactory?.Build();
    }

} // End Of Class

public static class FileSystemFactoryExtensions
{
    public static CombinedResult<FileSystemFactory, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration(this FileSystemFactory parentFactory, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null)
    {
        parentFactory.LustreConfigurationFactory = new InnerFileSystemLustreConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LustreConfigurationFactory);
    }

    public static CombinedResult<FileSystemFactory, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration(this FileSystemFactory parentFactory, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null)
    {
        parentFactory.OntapConfigurationFactory = new InnerFileSystemOntapConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OntapConfigurationFactory);
    }

    public static CombinedResult<FileSystemFactory, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration(this FileSystemFactory parentFactory, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null)
    {
        parentFactory.WindowsConfigurationFactory = new InnerFileSystemWindowsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WindowsConfigurationFactory);
    }

    public static CombinedResult<FileSystemFactory, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration(this FileSystemFactory parentFactory, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null)
    {
        parentFactory.OpenZFSConfigurationFactory = new InnerFileSystemOpenZFSConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OpenZFSConfigurationFactory);
    }

    public static CombinedResult<FileSystemFactory, T1, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1>(this CombinedResult<FileSystemFactory, T1> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1>(this CombinedResult<T1, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2>(this CombinedResult<FileSystemFactory, T1, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2>(this CombinedResult<T1, FileSystemFactory, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2>(this CombinedResult<T1, T2, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, T3, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3>(this CombinedResult<FileSystemFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, T3, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3>(this CombinedResult<T1, FileSystemFactory, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, T3, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, FileSystemFactory, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FileSystemFactory, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, T3, T4, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3, T4>(this CombinedResult<FileSystemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, T3, T4, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, FileSystemFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, T3, T4, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, FileSystemFactory, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FileSystemFactory, T4, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FileSystemFactory, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FileSystemFactory, InnerFileSystemLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1>(this CombinedResult<FileSystemFactory, T1> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1>(this CombinedResult<T1, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2>(this CombinedResult<FileSystemFactory, T1, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2>(this CombinedResult<T1, FileSystemFactory, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2>(this CombinedResult<T1, T2, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, T3, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3>(this CombinedResult<FileSystemFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, T3, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3>(this CombinedResult<T1, FileSystemFactory, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, T3, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, FileSystemFactory, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FileSystemFactory, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, T3, T4, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3, T4>(this CombinedResult<FileSystemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, T3, T4, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, FileSystemFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, T3, T4, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, FileSystemFactory, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FileSystemFactory, T4, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FileSystemFactory, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FileSystemFactory, InnerFileSystemOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1>(this CombinedResult<FileSystemFactory, T1> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1>(this CombinedResult<T1, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2>(this CombinedResult<FileSystemFactory, T1, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2>(this CombinedResult<T1, FileSystemFactory, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2>(this CombinedResult<T1, T2, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, T3, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2, T3>(this CombinedResult<FileSystemFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, T3, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2, T3>(this CombinedResult<T1, FileSystemFactory, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, T3, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, FileSystemFactory, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FileSystemFactory, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, T3, T4, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2, T3, T4>(this CombinedResult<FileSystemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, T3, T4, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, FileSystemFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, T3, T4, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, FileSystemFactory, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FileSystemFactory, T4, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FileSystemFactory, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FileSystemFactory, InnerFileSystemWindowsConfigurationFactory> WithWindowsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.WindowsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindowsConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1>(this CombinedResult<FileSystemFactory, T1> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1>(this CombinedResult<T1, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2>(this CombinedResult<FileSystemFactory, T1, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2>(this CombinedResult<T1, FileSystemFactory, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2>(this CombinedResult<T1, T2, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, T3, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3>(this CombinedResult<FileSystemFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, T3, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3>(this CombinedResult<T1, FileSystemFactory, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, T3, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, FileSystemFactory, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FileSystemFactory, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FileSystemFactory, T1, T2, T3, T4, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3, T4>(this CombinedResult<FileSystemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FileSystemFactory, T2, T3, T4, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, FileSystemFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FileSystemFactory, T3, T4, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, FileSystemFactory, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FileSystemFactory, T4, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FileSystemFactory, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FileSystemFactory, InnerFileSystemOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FileSystemFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T5, subFactoryAction));
}
