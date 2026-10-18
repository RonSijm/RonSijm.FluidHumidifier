// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class PublishingDestinationFactory(string resourceName = null, Action<Humidifier.GuardDuty.PublishingDestination> factoryAction = null) : ResourceFactory<Humidifier.GuardDuty.PublishingDestination>(resourceName)
{

    internal List<InnerPublishingDestinationTagItemFactory> TagsFactories { get; set; } = [];

    internal InnerPublishingDestinationCFNDestinationPropertiesFactory DestinationPropertiesFactory { get; set; }

    protected override Humidifier.GuardDuty.PublishingDestination Create()
    {
        var publishingDestinationResult = CreatePublishingDestination();
        factoryAction?.Invoke(publishingDestinationResult);

        return publishingDestinationResult;
    }

    private Humidifier.GuardDuty.PublishingDestination CreatePublishingDestination()
    {
        var publishingDestinationResult = new Humidifier.GuardDuty.PublishingDestination
        {
            GivenName = InputResourceName,
        };

        return publishingDestinationResult;
    }
    public override void CreateChildren(Humidifier.GuardDuty.PublishingDestination result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.DestinationProperties ??= DestinationPropertiesFactory?.Build();
    }

} // End Of Class

public static class PublishingDestinationFactoryExtensions
{
    public static CombinedResult<PublishingDestinationFactory, InnerPublishingDestinationTagItemFactory> WithTags(this PublishingDestinationFactory parentFactory, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null)
    {
        var factory = new InnerPublishingDestinationTagItemFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PublishingDestinationFactory, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties(this PublishingDestinationFactory parentFactory, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null)
    {
        parentFactory.DestinationPropertiesFactory = new InnerPublishingDestinationCFNDestinationPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationPropertiesFactory);
    }

    public static CombinedResult<PublishingDestinationFactory, T1, InnerPublishingDestinationTagItemFactory> WithTags<T1>(this CombinedResult<PublishingDestinationFactory, T1> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublishingDestinationFactory, InnerPublishingDestinationTagItemFactory> WithTags<T1>(this CombinedResult<T1, PublishingDestinationFactory> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PublishingDestinationFactory, T1, T2, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2>(this CombinedResult<PublishingDestinationFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublishingDestinationFactory, T2, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, PublishingDestinationFactory, T2> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PublishingDestinationFactory, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, PublishingDestinationFactory> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PublishingDestinationFactory, T1, T2, T3, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<PublishingDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublishingDestinationFactory, T2, T3, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, PublishingDestinationFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PublishingDestinationFactory, T3, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, PublishingDestinationFactory, T3> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PublishingDestinationFactory, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, PublishingDestinationFactory> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PublishingDestinationFactory, T1, T2, T3, T4, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<PublishingDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublishingDestinationFactory, T2, T3, T4, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, PublishingDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PublishingDestinationFactory, T3, T4, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, PublishingDestinationFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PublishingDestinationFactory, T4, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PublishingDestinationFactory, T4> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PublishingDestinationFactory, InnerPublishingDestinationTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PublishingDestinationFactory> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<PublishingDestinationFactory, T1, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1>(this CombinedResult<PublishingDestinationFactory, T1> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublishingDestinationFactory, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1>(this CombinedResult<T1, PublishingDestinationFactory> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PublishingDestinationFactory, T1, T2, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2>(this CombinedResult<PublishingDestinationFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublishingDestinationFactory, T2, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2>(this CombinedResult<T1, PublishingDestinationFactory, T2> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PublishingDestinationFactory, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2>(this CombinedResult<T1, T2, PublishingDestinationFactory> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PublishingDestinationFactory, T1, T2, T3, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2, T3>(this CombinedResult<PublishingDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublishingDestinationFactory, T2, T3, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2, T3>(this CombinedResult<T1, PublishingDestinationFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PublishingDestinationFactory, T3, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2, T3>(this CombinedResult<T1, T2, PublishingDestinationFactory, T3> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PublishingDestinationFactory, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, PublishingDestinationFactory> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PublishingDestinationFactory, T1, T2, T3, T4, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2, T3, T4>(this CombinedResult<PublishingDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublishingDestinationFactory, T2, T3, T4, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2, T3, T4>(this CombinedResult<T1, PublishingDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PublishingDestinationFactory, T3, T4, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, PublishingDestinationFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PublishingDestinationFactory, T4, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PublishingDestinationFactory, T4> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PublishingDestinationFactory, InnerPublishingDestinationCFNDestinationPropertiesFactory> WithDestinationProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PublishingDestinationFactory> combinedResult, Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationProperties(combinedResult.T5, subFactoryAction).T2);
}
