// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemLustreConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.LustreConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.LustreConfiguration>
{

    internal InnerFileSystemMetadataConfigurationFactory MetadataConfigurationFactory { get; set; }

    protected override Humidifier.FSx.FileSystemTypes.LustreConfiguration Create()
    {
        var lustreConfigurationResult = CreateLustreConfiguration();
        factoryAction?.Invoke(lustreConfigurationResult);

        return lustreConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.LustreConfiguration CreateLustreConfiguration()
    {
        var lustreConfigurationResult = new Humidifier.FSx.FileSystemTypes.LustreConfiguration();

        return lustreConfigurationResult;
    }
    public override void CreateChildren(Humidifier.FSx.FileSystemTypes.LustreConfiguration result)
    {
        base.CreateChildren(result);

        result.MetadataConfiguration ??= MetadataConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerFileSystemLustreConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFileSystemLustreConfigurationFactory, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration(this InnerFileSystemLustreConfigurationFactory parentFactory, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null)
    {
        parentFactory.MetadataConfigurationFactory = new InnerFileSystemMetadataConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetadataConfigurationFactory);
    }

    public static CombinedResult<InnerFileSystemLustreConfigurationFactory, T1, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1>(this CombinedResult<InnerFileSystemLustreConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFileSystemLustreConfigurationFactory, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1>(this CombinedResult<T1, InnerFileSystemLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFileSystemLustreConfigurationFactory, T1, T2, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2>(this CombinedResult<InnerFileSystemLustreConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFileSystemLustreConfigurationFactory, T2, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2>(this CombinedResult<T1, InnerFileSystemLustreConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFileSystemLustreConfigurationFactory, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFileSystemLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFileSystemLustreConfigurationFactory, T1, T2, T3, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<InnerFileSystemLustreConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFileSystemLustreConfigurationFactory, T2, T3, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFileSystemLustreConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFileSystemLustreConfigurationFactory, T3, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFileSystemLustreConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFileSystemLustreConfigurationFactory, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFileSystemLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFileSystemLustreConfigurationFactory, T1, T2, T3, T4, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFileSystemLustreConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFileSystemLustreConfigurationFactory, T2, T3, T4, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFileSystemLustreConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFileSystemLustreConfigurationFactory, T3, T4, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFileSystemLustreConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFileSystemLustreConfigurationFactory, T4, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFileSystemLustreConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFileSystemLustreConfigurationFactory, InnerFileSystemMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFileSystemLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T5, subFactoryAction));
}
