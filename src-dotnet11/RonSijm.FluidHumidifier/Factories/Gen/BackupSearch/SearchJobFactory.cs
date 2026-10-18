// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupSearch;

public class SearchJobFactory(string resourceName = null, Action<Humidifier.BackupSearch.SearchJob> factoryAction = null) : ResourceFactory<Humidifier.BackupSearch.SearchJob>(resourceName)
{

    internal List<InnerSearchJobTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerSearchJobSearchScopeFactory SearchScopeFactory { get; set; }

    protected override Humidifier.BackupSearch.SearchJob Create()
    {
        var searchJobResult = CreateSearchJob();
        factoryAction?.Invoke(searchJobResult);

        return searchJobResult;
    }

    private Humidifier.BackupSearch.SearchJob CreateSearchJob()
    {
        var searchJobResult = new Humidifier.BackupSearch.SearchJob
        {
            GivenName = InputResourceName,
        };

        return searchJobResult;
    }
    public override void CreateChildren(Humidifier.BackupSearch.SearchJob result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.SearchScope ??= SearchScopeFactory?.Build();
    }

} // End Of Class

public static class SearchJobFactoryExtensions
{
    public static CombinedResult<SearchJobFactory, InnerSearchJobTagsItemsFactory> WithTags(this SearchJobFactory parentFactory, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerSearchJobTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SearchJobFactory, InnerSearchJobSearchScopeFactory> WithSearchScope(this SearchJobFactory parentFactory, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null)
    {
        parentFactory.SearchScopeFactory = new InnerSearchJobSearchScopeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SearchScopeFactory);
    }

    public static CombinedResult<SearchJobFactory, T1, InnerSearchJobTagsItemsFactory> WithTags<T1>(this CombinedResult<SearchJobFactory, T1> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchJobFactory, InnerSearchJobTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, SearchJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SearchJobFactory, T1, T2, InnerSearchJobTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<SearchJobFactory, T1, T2> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchJobFactory, T2, InnerSearchJobTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, SearchJobFactory, T2> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchJobFactory, InnerSearchJobTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, SearchJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SearchJobFactory, T1, T2, T3, InnerSearchJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<SearchJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchJobFactory, T2, T3, InnerSearchJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, SearchJobFactory, T2, T3> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchJobFactory, T3, InnerSearchJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, SearchJobFactory, T3> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SearchJobFactory, InnerSearchJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, SearchJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SearchJobFactory, T1, T2, T3, T4, InnerSearchJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<SearchJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchJobFactory, T2, T3, T4, InnerSearchJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, SearchJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchJobFactory, T3, T4, InnerSearchJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, SearchJobFactory, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SearchJobFactory, T4, InnerSearchJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SearchJobFactory, T4> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SearchJobFactory, InnerSearchJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SearchJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SearchJobFactory, T1, InnerSearchJobSearchScopeFactory> WithSearchScope<T1>(this CombinedResult<SearchJobFactory, T1> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, WithSearchScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchJobFactory, InnerSearchJobSearchScopeFactory> WithSearchScope<T1>(this CombinedResult<T1, SearchJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, WithSearchScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SearchJobFactory, T1, T2, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2>(this CombinedResult<SearchJobFactory, T1, T2> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchJobFactory, T2, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2>(this CombinedResult<T1, SearchJobFactory, T2> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchJobFactory, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2>(this CombinedResult<T1, T2, SearchJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SearchJobFactory, T1, T2, T3, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2, T3>(this CombinedResult<SearchJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchJobFactory, T2, T3, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2, T3>(this CombinedResult<T1, SearchJobFactory, T2, T3> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchJobFactory, T3, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2, T3>(this CombinedResult<T1, T2, SearchJobFactory, T3> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SearchJobFactory, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2, T3>(this CombinedResult<T1, T2, T3, SearchJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SearchJobFactory, T1, T2, T3, T4, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2, T3, T4>(this CombinedResult<SearchJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SearchJobFactory, T2, T3, T4, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2, T3, T4>(this CombinedResult<T1, SearchJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SearchJobFactory, T3, T4, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, SearchJobFactory, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SearchJobFactory, T4, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SearchJobFactory, T4> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SearchJobFactory, InnerSearchJobSearchScopeFactory> WithSearchScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SearchJobFactory> combinedResult, Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSearchScope(combinedResult.T5, subFactoryAction).T2);
}
