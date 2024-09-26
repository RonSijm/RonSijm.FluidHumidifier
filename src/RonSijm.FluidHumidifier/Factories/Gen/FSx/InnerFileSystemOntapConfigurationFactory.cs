// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemOntapConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.OntapConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.OntapConfiguration>
{

    internal InnerFileSystemDiskIopsConfigurationFactory DiskIopsConfigurationFactory { get; set; }

    protected override Humidifier.FSx.FileSystemTypes.OntapConfiguration Create()
    {
        var ontapConfigurationResult = CreateOntapConfiguration();
        factoryAction?.Invoke(ontapConfigurationResult);

        return ontapConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.OntapConfiguration CreateOntapConfiguration()
    {
        var ontapConfigurationResult = new Humidifier.FSx.FileSystemTypes.OntapConfiguration();

        return ontapConfigurationResult;
    }
    public override void CreateChildren(Humidifier.FSx.FileSystemTypes.OntapConfiguration result)
    {
        base.CreateChildren(result);

        result.DiskIopsConfiguration ??= DiskIopsConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerFileSystemOntapConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFileSystemOntapConfigurationFactory, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration(this InnerFileSystemOntapConfigurationFactory parentFactory, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null)
    {
        parentFactory.DiskIopsConfigurationFactory = new InnerFileSystemDiskIopsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DiskIopsConfigurationFactory);
    }

    public static CombinedResult<InnerFileSystemOntapConfigurationFactory, T1, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1>(this CombinedResult<InnerFileSystemOntapConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFileSystemOntapConfigurationFactory, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1>(this CombinedResult<T1, InnerFileSystemOntapConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFileSystemOntapConfigurationFactory, T1, T2, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2>(this CombinedResult<InnerFileSystemOntapConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFileSystemOntapConfigurationFactory, T2, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2>(this CombinedResult<T1, InnerFileSystemOntapConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFileSystemOntapConfigurationFactory, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFileSystemOntapConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFileSystemOntapConfigurationFactory, T1, T2, T3, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2, T3>(this CombinedResult<InnerFileSystemOntapConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFileSystemOntapConfigurationFactory, T2, T3, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFileSystemOntapConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFileSystemOntapConfigurationFactory, T3, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFileSystemOntapConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFileSystemOntapConfigurationFactory, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFileSystemOntapConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFileSystemOntapConfigurationFactory, T1, T2, T3, T4, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFileSystemOntapConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFileSystemOntapConfigurationFactory, T2, T3, T4, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFileSystemOntapConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFileSystemOntapConfigurationFactory, T3, T4, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFileSystemOntapConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFileSystemOntapConfigurationFactory, T4, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFileSystemOntapConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFileSystemOntapConfigurationFactory, InnerFileSystemDiskIopsConfigurationFactory> WithDiskIopsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFileSystemOntapConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDiskIopsConfiguration(combinedResult.T5, subFactoryAction));
}
