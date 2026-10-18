// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class RecommenderSchemaFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.RecommenderSchema> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.RecommenderSchema>(resourceName)
{

    internal List<InnerRecommenderSchemaTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.CustomerProfiles.RecommenderSchema Create()
    {
        var recommenderSchemaResult = CreateRecommenderSchema();
        factoryAction?.Invoke(recommenderSchemaResult);

        return recommenderSchemaResult;
    }

    private Humidifier.CustomerProfiles.RecommenderSchema CreateRecommenderSchema()
    {
        var recommenderSchemaResult = new Humidifier.CustomerProfiles.RecommenderSchema
        {
            GivenName = InputResourceName,
        };

        return recommenderSchemaResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.RecommenderSchema result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RecommenderSchemaFactoryExtensions
{
    public static CombinedResult<RecommenderSchemaFactory, InnerRecommenderSchemaTagsItemsFactory> WithTags(this RecommenderSchemaFactory parentFactory, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerRecommenderSchemaTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RecommenderSchemaFactory, T1, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1>(this CombinedResult<RecommenderSchemaFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderSchemaFactory, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, RecommenderSchemaFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RecommenderSchemaFactory, T1, T2, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<RecommenderSchemaFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderSchemaFactory, T2, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, RecommenderSchemaFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RecommenderSchemaFactory, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, RecommenderSchemaFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RecommenderSchemaFactory, T1, T2, T3, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<RecommenderSchemaFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderSchemaFactory, T2, T3, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, RecommenderSchemaFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RecommenderSchemaFactory, T3, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, RecommenderSchemaFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RecommenderSchemaFactory, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, RecommenderSchemaFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RecommenderSchemaFactory, T1, T2, T3, T4, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<RecommenderSchemaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderSchemaFactory, T2, T3, T4, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, RecommenderSchemaFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RecommenderSchemaFactory, T3, T4, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, RecommenderSchemaFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RecommenderSchemaFactory, T4, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RecommenderSchemaFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RecommenderSchemaFactory, InnerRecommenderSchemaTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RecommenderSchemaFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
