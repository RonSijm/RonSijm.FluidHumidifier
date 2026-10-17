// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class IndexFactory(string resourceName = null, Action<Humidifier.OpenSearchServerless.Index> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchServerless.Index>(resourceName)
{

    internal InnerIndexMappingsFactory MappingsFactory { get; set; }

    internal InnerIndexIndexSettingsFactory SettingsFactory { get; set; }

    protected override Humidifier.OpenSearchServerless.Index Create()
    {
        var indexResult = CreateIndex();
        factoryAction?.Invoke(indexResult);

        return indexResult;
    }

    private Humidifier.OpenSearchServerless.Index CreateIndex()
    {
        var indexResult = new Humidifier.OpenSearchServerless.Index
        {
            GivenName = InputResourceName,
        };

        return indexResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchServerless.Index result)
    {
        base.CreateChildren(result);

        result.Mappings ??= MappingsFactory?.Build();
        result.Settings ??= SettingsFactory?.Build();
    }

} // End Of Class

public static class IndexFactoryExtensions
{
    public static CombinedResult<IndexFactory, InnerIndexMappingsFactory> WithMappings(this IndexFactory parentFactory, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null)
    {
        parentFactory.MappingsFactory = new InnerIndexMappingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MappingsFactory);
    }

    public static CombinedResult<IndexFactory, InnerIndexIndexSettingsFactory> WithSettings(this IndexFactory parentFactory, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null)
    {
        parentFactory.SettingsFactory = new InnerIndexIndexSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SettingsFactory);
    }

    public static CombinedResult<IndexFactory, T1, InnerIndexMappingsFactory> WithMappings<T1>(this CombinedResult<IndexFactory, T1> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, InnerIndexMappingsFactory> WithMappings<T1>(this CombinedResult<T1, IndexFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, InnerIndexMappingsFactory> WithMappings<T1, T2>(this CombinedResult<IndexFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, InnerIndexMappingsFactory> WithMappings<T1, T2>(this CombinedResult<T1, IndexFactory, T2> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, InnerIndexMappingsFactory> WithMappings<T1, T2>(this CombinedResult<T1, T2, IndexFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, T3, InnerIndexMappingsFactory> WithMappings<T1, T2, T3>(this CombinedResult<IndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, T3, InnerIndexMappingsFactory> WithMappings<T1, T2, T3>(this CombinedResult<T1, IndexFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, T3, InnerIndexMappingsFactory> WithMappings<T1, T2, T3>(this CombinedResult<T1, T2, IndexFactory, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IndexFactory, InnerIndexMappingsFactory> WithMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, IndexFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, T3, T4, InnerIndexMappingsFactory> WithMappings<T1, T2, T3, T4>(this CombinedResult<IndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, T3, T4, InnerIndexMappingsFactory> WithMappings<T1, T2, T3, T4>(this CombinedResult<T1, IndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, T3, T4, InnerIndexMappingsFactory> WithMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, IndexFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IndexFactory, T4, InnerIndexMappingsFactory> WithMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IndexFactory, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IndexFactory, InnerIndexMappingsFactory> WithMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IndexFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappings(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, InnerIndexIndexSettingsFactory> WithSettings<T1>(this CombinedResult<IndexFactory, T1> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, InnerIndexIndexSettingsFactory> WithSettings<T1>(this CombinedResult<T1, IndexFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, InnerIndexIndexSettingsFactory> WithSettings<T1, T2>(this CombinedResult<IndexFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, InnerIndexIndexSettingsFactory> WithSettings<T1, T2>(this CombinedResult<T1, IndexFactory, T2> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, InnerIndexIndexSettingsFactory> WithSettings<T1, T2>(this CombinedResult<T1, T2, IndexFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, T3, InnerIndexIndexSettingsFactory> WithSettings<T1, T2, T3>(this CombinedResult<IndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, T3, InnerIndexIndexSettingsFactory> WithSettings<T1, T2, T3>(this CombinedResult<T1, IndexFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, T3, InnerIndexIndexSettingsFactory> WithSettings<T1, T2, T3>(this CombinedResult<T1, T2, IndexFactory, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IndexFactory, InnerIndexIndexSettingsFactory> WithSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, IndexFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, T3, T4, InnerIndexIndexSettingsFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<IndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, T3, T4, InnerIndexIndexSettingsFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, IndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, T3, T4, InnerIndexIndexSettingsFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, IndexFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IndexFactory, T4, InnerIndexIndexSettingsFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IndexFactory, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IndexFactory, InnerIndexIndexSettingsFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IndexFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T5, subFactoryAction).T2);
}
