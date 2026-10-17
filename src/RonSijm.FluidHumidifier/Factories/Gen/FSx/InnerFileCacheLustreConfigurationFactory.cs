// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileCacheLustreConfigurationFactory(Action<Humidifier.FSx.FileCacheTypes.LustreConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileCacheTypes.LustreConfiguration>
{

    internal InnerFileCacheMetadataConfigurationFactory MetadataConfigurationFactory { get; set; }

    internal InnerFileCacheLogConfigurationFactory LogConfigurationFactory { get; set; }

    protected override Humidifier.FSx.FileCacheTypes.LustreConfiguration Create()
    {
        var lustreConfigurationResult = CreateLustreConfiguration();
        factoryAction?.Invoke(lustreConfigurationResult);

        return lustreConfigurationResult;
    }

    private Humidifier.FSx.FileCacheTypes.LustreConfiguration CreateLustreConfiguration()
    {
        var lustreConfigurationResult = new Humidifier.FSx.FileCacheTypes.LustreConfiguration();

        return lustreConfigurationResult;
    }
    public override void CreateChildren(Humidifier.FSx.FileCacheTypes.LustreConfiguration result)
    {
        base.CreateChildren(result);

        result.MetadataConfiguration ??= MetadataConfigurationFactory?.Build();
        result.LogConfiguration ??= LogConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerFileCacheLustreConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFileCacheLustreConfigurationFactory, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration(this InnerFileCacheLustreConfigurationFactory parentFactory, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null)
    {
        parentFactory.MetadataConfigurationFactory = new InnerFileCacheMetadataConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetadataConfigurationFactory);
    }

    public static CombinedResult<InnerFileCacheLustreConfigurationFactory, InnerFileCacheLogConfigurationFactory> WithLogConfiguration(this InnerFileCacheLustreConfigurationFactory parentFactory, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null)
    {
        parentFactory.LogConfigurationFactory = new InnerFileCacheLogConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogConfigurationFactory);
    }

    public static CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1>(this CombinedResult<InnerFileCacheLustreConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1>(this CombinedResult<T1, InnerFileCacheLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2>(this CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2>(this CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2, T3, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2, T3, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory, T3, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFileCacheLustreConfigurationFactory, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFileCacheLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2, T3, T4, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2, T3, T4, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory, T3, T4, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFileCacheLustreConfigurationFactory, T4, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFileCacheLustreConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFileCacheLustreConfigurationFactory, InnerFileCacheMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFileCacheLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1>(this CombinedResult<InnerFileCacheLustreConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1>(this CombinedResult<T1, InnerFileCacheLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2, T3, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2, T3, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory, T3, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFileCacheLustreConfigurationFactory, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFileCacheLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2, T3, T4, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFileCacheLustreConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2, T3, T4, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFileCacheLustreConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory, T3, T4, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFileCacheLustreConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFileCacheLustreConfigurationFactory, T4, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFileCacheLustreConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFileCacheLustreConfigurationFactory, InnerFileCacheLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFileCacheLustreConfigurationFactory> combinedResult, Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T5, subFactoryAction).T2);
}
