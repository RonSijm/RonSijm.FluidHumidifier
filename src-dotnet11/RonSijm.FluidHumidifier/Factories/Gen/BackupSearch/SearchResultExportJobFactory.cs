// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupSearch;

public class SearchResultExportJobFactory(string resourceName = null, Action<Humidifier.BackupSearch.SearchResultExportJob> factoryAction = null) : ResourceFactory<Humidifier.BackupSearch.SearchResultExportJob>(resourceName)
{

    internal List<InnerSearchResultExportJobTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerSearchResultExportJobExportSpecificationFactory ExportSpecificationFactory { get; set; }

    protected override Humidifier.BackupSearch.SearchResultExportJob Create()
    {
        var searchResultExportJobResult = CreateSearchResultExportJob();
        factoryAction?.Invoke(searchResultExportJobResult);

        return searchResultExportJobResult;
    }

    private Humidifier.BackupSearch.SearchResultExportJob CreateSearchResultExportJob()
    {
        var searchResultExportJobResult = new Humidifier.BackupSearch.SearchResultExportJob
        {
            GivenName = InputResourceName,
        };

        return searchResultExportJobResult;
    }
    public override void CreateChildren(Humidifier.BackupSearch.SearchResultExportJob result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.ExportSpecification ??= ExportSpecificationFactory?.Build();
    }

} // End Of Class

public static class SearchResultExportJobFactoryExtensions
{
    public static CombinedResult<SearchResultExportJobFactory, InnerSearchResultExportJobTagsItemsFactory> WithTags(this SearchResultExportJobFactory parentFactory, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerSearchResultExportJobTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SearchResultExportJobFactory, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification(this SearchResultExportJobFactory parentFactory, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null)
    {
        parentFactory.ExportSpecificationFactory = new InnerSearchResultExportJobExportSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExportSpecificationFactory);
    }

    public static CombinedResult<SearchResultExportJobFactory, T1, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1>(this CombinedResult<SearchResultExportJobFactory, T1> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchResultExportJobFactory, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, SearchResultExportJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SearchResultExportJobFactory, T1, T2, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<SearchResultExportJobFactory, T1, T2> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchResultExportJobFactory, T2, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, SearchResultExportJobFactory, T2> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchResultExportJobFactory, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, SearchResultExportJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SearchResultExportJobFactory, T1, T2, T3, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<SearchResultExportJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchResultExportJobFactory, T2, T3, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, SearchResultExportJobFactory, T2, T3> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchResultExportJobFactory, T3, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, SearchResultExportJobFactory, T3> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SearchResultExportJobFactory, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, SearchResultExportJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SearchResultExportJobFactory, T1, T2, T3, T4, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<SearchResultExportJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchResultExportJobFactory, T2, T3, T4, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, SearchResultExportJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchResultExportJobFactory, T3, T4, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, SearchResultExportJobFactory, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SearchResultExportJobFactory, T4, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SearchResultExportJobFactory, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SearchResultExportJobFactory, InnerSearchResultExportJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SearchResultExportJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SearchResultExportJobFactory, T1, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1>(this CombinedResult<SearchResultExportJobFactory, T1> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchResultExportJobFactory, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1>(this CombinedResult<T1, SearchResultExportJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SearchResultExportJobFactory, T1, T2, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2>(this CombinedResult<SearchResultExportJobFactory, T1, T2> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchResultExportJobFactory, T2, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2>(this CombinedResult<T1, SearchResultExportJobFactory, T2> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchResultExportJobFactory, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2>(this CombinedResult<T1, T2, SearchResultExportJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SearchResultExportJobFactory, T1, T2, T3, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2, T3>(this CombinedResult<SearchResultExportJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchResultExportJobFactory, T2, T3, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2, T3>(this CombinedResult<T1, SearchResultExportJobFactory, T2, T3> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchResultExportJobFactory, T3, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2, T3>(this CombinedResult<T1, T2, SearchResultExportJobFactory, T3> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SearchResultExportJobFactory, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, SearchResultExportJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SearchResultExportJobFactory, T1, T2, T3, T4, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2, T3, T4>(this CombinedResult<SearchResultExportJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchResultExportJobFactory, T2, T3, T4, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2, T3, T4>(this CombinedResult<T1, SearchResultExportJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchResultExportJobFactory, T3, T4, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, SearchResultExportJobFactory, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SearchResultExportJobFactory, T4, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SearchResultExportJobFactory, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SearchResultExportJobFactory, InnerSearchResultExportJobExportSpecificationFactory> WithExportSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SearchResultExportJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportSpecification(combinedResult.T5, subFactoryAction).T2);
}
