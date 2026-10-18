// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class TargetedSentimentDetectionJobFactory(string resourceName = null, Action<Humidifier.Comprehend.TargetedSentimentDetectionJob> factoryAction = null) : ResourceFactory<Humidifier.Comprehend.TargetedSentimentDetectionJob>(resourceName)
{

    internal List<InnerTargetedSentimentDetectionJobTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerTargetedSentimentDetectionJobInputDataConfigFactory InputDataConfigFactory { get; set; }

    protected override Humidifier.Comprehend.TargetedSentimentDetectionJob Create()
    {
        var targetedSentimentDetectionJobResult = CreateTargetedSentimentDetectionJob();
        factoryAction?.Invoke(targetedSentimentDetectionJobResult);

        return targetedSentimentDetectionJobResult;
    }

    private Humidifier.Comprehend.TargetedSentimentDetectionJob CreateTargetedSentimentDetectionJob()
    {
        var targetedSentimentDetectionJobResult = new Humidifier.Comprehend.TargetedSentimentDetectionJob
        {
            GivenName = InputResourceName,
        };

        return targetedSentimentDetectionJobResult;
    }
    public override void CreateChildren(Humidifier.Comprehend.TargetedSentimentDetectionJob result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.InputDataConfig ??= InputDataConfigFactory?.Build();
    }

} // End Of Class

public static class TargetedSentimentDetectionJobFactoryExtensions
{
    public static CombinedResult<TargetedSentimentDetectionJobFactory, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags(this TargetedSentimentDetectionJobFactory parentFactory, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerTargetedSentimentDetectionJobTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TargetedSentimentDetectionJobFactory, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig(this TargetedSentimentDetectionJobFactory parentFactory, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null)
    {
        parentFactory.InputDataConfigFactory = new InnerTargetedSentimentDetectionJobInputDataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputDataConfigFactory);
    }

    public static CombinedResult<TargetedSentimentDetectionJobFactory, T1, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1>(this CombinedResult<TargetedSentimentDetectionJobFactory, T1> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TargetedSentimentDetectionJobFactory, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, TargetedSentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2, T3, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2, T3, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory, T3, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory, T3> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TargetedSentimentDetectionJobFactory, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, TargetedSentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2, T3, T4, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2, T3, T4, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory, T3, T4, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TargetedSentimentDetectionJobFactory, T4, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TargetedSentimentDetectionJobFactory, T4> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TargetedSentimentDetectionJobFactory, InnerTargetedSentimentDetectionJobTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TargetedSentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TargetedSentimentDetectionJobFactory, T1, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<TargetedSentimentDetectionJobFactory, T1> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TargetedSentimentDetectionJobFactory, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<T1, TargetedSentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2, T3, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2, T3, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory, T3, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory, T3> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TargetedSentimentDetectionJobFactory, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, TargetedSentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2, T3, T4, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<TargetedSentimentDetectionJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2, T3, T4, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, TargetedSentimentDetectionJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory, T3, T4, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, TargetedSentimentDetectionJobFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TargetedSentimentDetectionJobFactory, T4, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TargetedSentimentDetectionJobFactory, T4> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TargetedSentimentDetectionJobFactory, InnerTargetedSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TargetedSentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T5, subFactoryAction).T2);
}
