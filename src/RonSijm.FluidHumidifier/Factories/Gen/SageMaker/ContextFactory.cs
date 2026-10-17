// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ContextFactory(string resourceName = null, Action<Humidifier.SageMaker.Context> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Context>(resourceName)
{

    internal List<InnerContextTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerContextSourceFactory SourceFactory { get; set; }

    protected override Humidifier.SageMaker.Context Create()
    {
        var contextResult = CreateContext();
        factoryAction?.Invoke(contextResult);

        return contextResult;
    }

    private Humidifier.SageMaker.Context CreateContext()
    {
        var contextResult = new Humidifier.SageMaker.Context
        {
            GivenName = InputResourceName,
        };

        return contextResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Context result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class ContextFactoryExtensions
{
    public static CombinedResult<ContextFactory, InnerContextTagsItemsFactory> WithTags(this ContextFactory parentFactory, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerContextTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ContextFactory, InnerContextSourceFactory> WithSource(this ContextFactory parentFactory, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerContextSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<ContextFactory, T1, InnerContextTagsItemsFactory> WithTags<T1>(this CombinedResult<ContextFactory, T1> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContextFactory, InnerContextTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, ContextFactory> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ContextFactory, T1, T2, InnerContextTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<ContextFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContextFactory, T2, InnerContextTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, ContextFactory, T2> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContextFactory, InnerContextTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ContextFactory> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ContextFactory, T1, T2, T3, InnerContextTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<ContextFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContextFactory, T2, T3, InnerContextTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ContextFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContextFactory, T3, InnerContextTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ContextFactory, T3> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ContextFactory, InnerContextTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContextFactory> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ContextFactory, T1, T2, T3, T4, InnerContextTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ContextFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContextFactory, T2, T3, T4, InnerContextTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ContextFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContextFactory, T3, T4, InnerContextTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContextFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ContextFactory, T4, InnerContextTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContextFactory, T4> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ContextFactory, InnerContextTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContextFactory> combinedResult, Action<Humidifier.SageMaker.ContextTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ContextFactory, T1, InnerContextSourceFactory> WithSource<T1>(this CombinedResult<ContextFactory, T1> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContextFactory, InnerContextSourceFactory> WithSource<T1>(this CombinedResult<T1, ContextFactory> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ContextFactory, T1, T2, InnerContextSourceFactory> WithSource<T1, T2>(this CombinedResult<ContextFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContextFactory, T2, InnerContextSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, ContextFactory, T2> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContextFactory, InnerContextSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, ContextFactory> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ContextFactory, T1, T2, T3, InnerContextSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<ContextFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContextFactory, T2, T3, InnerContextSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, ContextFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContextFactory, T3, InnerContextSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, ContextFactory, T3> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ContextFactory, InnerContextSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContextFactory> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ContextFactory, T1, T2, T3, T4, InnerContextSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<ContextFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContextFactory, T2, T3, T4, InnerContextSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, ContextFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContextFactory, T3, T4, InnerContextSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContextFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ContextFactory, T4, InnerContextSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContextFactory, T4> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ContextFactory, InnerContextSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContextFactory> combinedResult, Action<Humidifier.SageMaker.ContextTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
