// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class TrialComponentFactory(string resourceName = null, Action<Humidifier.SageMaker.TrialComponent> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.TrialComponent>(resourceName)
{

    internal List<InnerTrialComponentTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerTrialComponentTrialComponentStatusFactory StatusFactory { get; set; }

    internal InnerTrialComponentMetadataPropertiesFactory MetadataPropertiesFactory { get; set; }

    protected override Humidifier.SageMaker.TrialComponent Create()
    {
        var trialComponentResult = CreateTrialComponent();
        factoryAction?.Invoke(trialComponentResult);

        return trialComponentResult;
    }

    private Humidifier.SageMaker.TrialComponent CreateTrialComponent()
    {
        var trialComponentResult = new Humidifier.SageMaker.TrialComponent
        {
            GivenName = InputResourceName,
        };

        return trialComponentResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.TrialComponent result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.Status ??= StatusFactory?.Build();
        result.MetadataProperties ??= MetadataPropertiesFactory?.Build();
    }

} // End Of Class

public static class TrialComponentFactoryExtensions
{
    public static CombinedResult<TrialComponentFactory, InnerTrialComponentTagsItemsFactory> WithTags(this TrialComponentFactory parentFactory, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerTrialComponentTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TrialComponentFactory, InnerTrialComponentTrialComponentStatusFactory> WithStatus(this TrialComponentFactory parentFactory, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null)
    {
        parentFactory.StatusFactory = new InnerTrialComponentTrialComponentStatusFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StatusFactory);
    }

    public static CombinedResult<TrialComponentFactory, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties(this TrialComponentFactory parentFactory, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null)
    {
        parentFactory.MetadataPropertiesFactory = new InnerTrialComponentMetadataPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetadataPropertiesFactory);
    }

    public static CombinedResult<TrialComponentFactory, T1, InnerTrialComponentTagsItemsFactory> WithTags<T1>(this CombinedResult<TrialComponentFactory, T1> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, InnerTrialComponentTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, T2, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<TrialComponentFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, T2, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, TrialComponentFactory, T2> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrialComponentFactory, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, T2, T3, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<TrialComponentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, T2, T3, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, TrialComponentFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrialComponentFactory, T3, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, TrialComponentFactory, T3> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TrialComponentFactory, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, T2, T3, T4, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<TrialComponentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, T2, T3, T4, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, TrialComponentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrialComponentFactory, T3, T4, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrialComponentFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TrialComponentFactory, T4, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrialComponentFactory, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TrialComponentFactory, InnerTrialComponentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1>(this CombinedResult<TrialComponentFactory, T1> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatus(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1>(this CombinedResult<T1, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatus(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, T2, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2>(this CombinedResult<TrialComponentFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, T2, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2>(this CombinedResult<T1, TrialComponentFactory, T2> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrialComponentFactory, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2>(this CombinedResult<T1, T2, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, T2, T3, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2, T3>(this CombinedResult<TrialComponentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, T2, T3, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2, T3>(this CombinedResult<T1, TrialComponentFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrialComponentFactory, T3, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2, T3>(this CombinedResult<T1, T2, TrialComponentFactory, T3> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TrialComponentFactory, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, T2, T3, T4, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2, T3, T4>(this CombinedResult<TrialComponentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, T2, T3, T4, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2, T3, T4>(this CombinedResult<T1, TrialComponentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrialComponentFactory, T3, T4, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrialComponentFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TrialComponentFactory, T4, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrialComponentFactory, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TrialComponentFactory, InnerTrialComponentTrialComponentStatusFactory> WithStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatus(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1>(this CombinedResult<TrialComponentFactory, T1> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1>(this CombinedResult<T1, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, T2, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2>(this CombinedResult<TrialComponentFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, T2, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2>(this CombinedResult<T1, TrialComponentFactory, T2> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrialComponentFactory, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2>(this CombinedResult<T1, T2, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, T2, T3, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<TrialComponentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, T2, T3, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<T1, TrialComponentFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrialComponentFactory, T3, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<T1, T2, TrialComponentFactory, T3> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TrialComponentFactory, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TrialComponentFactory, T1, T2, T3, T4, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<TrialComponentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrialComponentFactory, T2, T3, T4, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, TrialComponentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrialComponentFactory, T3, T4, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrialComponentFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TrialComponentFactory, T4, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrialComponentFactory, T4> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TrialComponentFactory, InnerTrialComponentMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrialComponentFactory> combinedResult, Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T5, subFactoryAction).T2);
}
