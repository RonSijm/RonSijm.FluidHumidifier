// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class FileCacheFactory(string resourceName = null, Action<Humidifier.FSx.FileCache> factoryAction = null) : ResourceFactory<Humidifier.FSx.FileCache>(resourceName)
{

    internal List<InnerFileCacheDataRepositoryAssociationFactory> DataRepositoryAssociationsFactories { get; set; } = [];

    internal InnerFileCacheLustreConfigurationFactory LustreConfigurationFactory { get; set; }

    protected override Humidifier.FSx.FileCache Create()
    {
        var fileCacheResult = CreateFileCache();
        factoryAction?.Invoke(fileCacheResult);

        return fileCacheResult;
    }

    private Humidifier.FSx.FileCache CreateFileCache()
    {
        var fileCacheResult = new Humidifier.FSx.FileCache
        {
            GivenName = InputResourceName,
        };

        return fileCacheResult;
    }
    public override void CreateChildren(Humidifier.FSx.FileCache result)
    {
        base.CreateChildren(result);

        result.DataRepositoryAssociations = DataRepositoryAssociationsFactories.Any() ? DataRepositoryAssociationsFactories.Select(x => x.Build()).ToList() : null;
        result.LustreConfiguration ??= LustreConfigurationFactory?.Build();
    }

} // End Of Class

public static class FileCacheFactoryExtensions
{
    public static CombinedResult<FileCacheFactory, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations(this FileCacheFactory parentFactory, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null)
    {
        var factory = new InnerFileCacheDataRepositoryAssociationFactory(subFactoryAction);
        parentFactory.DataRepositoryAssociationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FileCacheFactory, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration(this FileCacheFactory parentFactory, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null)
    {
        parentFactory.LustreConfigurationFactory = new InnerFileCacheLustreConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LustreConfigurationFactory);
    }

    public static CombinedResult<FileCacheFactory, T1, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1>(this CombinedResult<FileCacheFactory, T1> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileCacheFactory, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1>(this CombinedResult<T1, FileCacheFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FileCacheFactory, T1, T2, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2>(this CombinedResult<FileCacheFactory, T1, T2> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileCacheFactory, T2, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2>(this CombinedResult<T1, FileCacheFactory, T2> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FileCacheFactory, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2>(this CombinedResult<T1, T2, FileCacheFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FileCacheFactory, T1, T2, T3, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2, T3>(this CombinedResult<FileCacheFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileCacheFactory, T2, T3, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2, T3>(this CombinedResult<T1, FileCacheFactory, T2, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FileCacheFactory, T3, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2, T3>(this CombinedResult<T1, T2, FileCacheFactory, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FileCacheFactory, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2, T3>(this CombinedResult<T1, T2, T3, FileCacheFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FileCacheFactory, T1, T2, T3, T4, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2, T3, T4>(this CombinedResult<FileCacheFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileCacheFactory, T2, T3, T4, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2, T3, T4>(this CombinedResult<T1, FileCacheFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FileCacheFactory, T3, T4, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, FileCacheFactory, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FileCacheFactory, T4, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FileCacheFactory, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FileCacheFactory, InnerFileCacheDataRepositoryAssociationFactory> WithDataRepositoryAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FileCacheFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataRepositoryAssociations(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<FileCacheFactory, T1, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1>(this CombinedResult<FileCacheFactory, T1> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileCacheFactory, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1>(this CombinedResult<T1, FileCacheFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FileCacheFactory, T1, T2, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2>(this CombinedResult<FileCacheFactory, T1, T2> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileCacheFactory, T2, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2>(this CombinedResult<T1, FileCacheFactory, T2> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FileCacheFactory, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2>(this CombinedResult<T1, T2, FileCacheFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FileCacheFactory, T1, T2, T3, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3>(this CombinedResult<FileCacheFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileCacheFactory, T2, T3, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3>(this CombinedResult<T1, FileCacheFactory, T2, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FileCacheFactory, T3, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, FileCacheFactory, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FileCacheFactory, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, FileCacheFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FileCacheFactory, T1, T2, T3, T4, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3, T4>(this CombinedResult<FileCacheFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FileCacheFactory, T2, T3, T4, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, FileCacheFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FileCacheFactory, T3, T4, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, FileCacheFactory, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FileCacheFactory, T4, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FileCacheFactory, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FileCacheFactory, InnerFileCacheLustreConfigurationFactory> WithLustreConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FileCacheFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLustreConfiguration(combinedResult.T5, subFactoryAction).T2);
}
