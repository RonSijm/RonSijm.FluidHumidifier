// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class RecommenderFilterFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.RecommenderFilter> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.RecommenderFilter>(resourceName)
{

    internal List<InnerRecommenderFilterTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.CustomerProfiles.RecommenderFilter Create()
    {
        var recommenderFilterResult = CreateRecommenderFilter();
        factoryAction?.Invoke(recommenderFilterResult);

        return recommenderFilterResult;
    }

    private Humidifier.CustomerProfiles.RecommenderFilter CreateRecommenderFilter()
    {
        var recommenderFilterResult = new Humidifier.CustomerProfiles.RecommenderFilter
        {
            GivenName = InputResourceName,
        };

        return recommenderFilterResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.RecommenderFilter result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RecommenderFilterFactoryExtensions
{
    public static CombinedResult<RecommenderFilterFactory, InnerRecommenderFilterTagsItemsFactory> WithTags(this RecommenderFilterFactory parentFactory, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerRecommenderFilterTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RecommenderFilterFactory, T1, InnerRecommenderFilterTagsItemsFactory> WithTags<T1>(this CombinedResult<RecommenderFilterFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderFilterFactory, InnerRecommenderFilterTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, RecommenderFilterFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RecommenderFilterFactory, T1, T2, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<RecommenderFilterFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderFilterFactory, T2, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, RecommenderFilterFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RecommenderFilterFactory, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, RecommenderFilterFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RecommenderFilterFactory, T1, T2, T3, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<RecommenderFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderFilterFactory, T2, T3, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, RecommenderFilterFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RecommenderFilterFactory, T3, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, RecommenderFilterFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RecommenderFilterFactory, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, RecommenderFilterFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RecommenderFilterFactory, T1, T2, T3, T4, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<RecommenderFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderFilterFactory, T2, T3, T4, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, RecommenderFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RecommenderFilterFactory, T3, T4, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, RecommenderFilterFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RecommenderFilterFactory, T4, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RecommenderFilterFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RecommenderFilterFactory, InnerRecommenderFilterTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RecommenderFilterFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
