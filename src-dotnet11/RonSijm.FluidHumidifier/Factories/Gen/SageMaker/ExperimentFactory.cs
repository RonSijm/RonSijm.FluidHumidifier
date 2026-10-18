// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ExperimentFactory(string resourceName = null, Action<Humidifier.SageMaker.Experiment> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Experiment>(resourceName)
{

    internal List<InnerExperimentTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.SageMaker.Experiment Create()
    {
        var experimentResult = CreateExperiment();
        factoryAction?.Invoke(experimentResult);

        return experimentResult;
    }

    private Humidifier.SageMaker.Experiment CreateExperiment()
    {
        var experimentResult = new Humidifier.SageMaker.Experiment
        {
            GivenName = InputResourceName,
        };

        return experimentResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Experiment result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ExperimentFactoryExtensions
{
    public static CombinedResult<ExperimentFactory, InnerExperimentTagsItemsFactory> WithTags(this ExperimentFactory parentFactory, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerExperimentTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ExperimentFactory, T1, InnerExperimentTagsItemsFactory> WithTags<T1>(this CombinedResult<ExperimentFactory, T1> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentFactory, InnerExperimentTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, ExperimentFactory> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ExperimentFactory, T1, T2, InnerExperimentTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<ExperimentFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentFactory, T2, InnerExperimentTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, ExperimentFactory, T2> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentFactory, InnerExperimentTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ExperimentFactory> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ExperimentFactory, T1, T2, T3, InnerExperimentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<ExperimentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentFactory, T2, T3, InnerExperimentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ExperimentFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentFactory, T3, InnerExperimentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ExperimentFactory, T3> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExperimentFactory, InnerExperimentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExperimentFactory> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ExperimentFactory, T1, T2, T3, T4, InnerExperimentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ExperimentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentFactory, T2, T3, T4, InnerExperimentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ExperimentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentFactory, T3, T4, InnerExperimentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExperimentFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExperimentFactory, T4, InnerExperimentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExperimentFactory, T4> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ExperimentFactory, InnerExperimentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExperimentFactory> combinedResult, Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
