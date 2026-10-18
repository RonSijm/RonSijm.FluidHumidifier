// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class CustomDetectionRuleAssociationFactory(string resourceName = null, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociation> factoryAction = null) : ResourceFactory<Humidifier.GuardDuty.CustomDetectionRuleAssociation>(resourceName)
{

    internal List<InnerCustomDetectionRuleAssociationTagItemFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.GuardDuty.CustomDetectionRuleAssociation Create()
    {
        var customDetectionRuleAssociationResult = CreateCustomDetectionRuleAssociation();
        factoryAction?.Invoke(customDetectionRuleAssociationResult);

        return customDetectionRuleAssociationResult;
    }

    private Humidifier.GuardDuty.CustomDetectionRuleAssociation CreateCustomDetectionRuleAssociation()
    {
        var customDetectionRuleAssociationResult = new Humidifier.GuardDuty.CustomDetectionRuleAssociation
        {
            GivenName = InputResourceName,
        };

        return customDetectionRuleAssociationResult;
    }
    public override void CreateChildren(Humidifier.GuardDuty.CustomDetectionRuleAssociation result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CustomDetectionRuleAssociationFactoryExtensions
{
    public static CombinedResult<CustomDetectionRuleAssociationFactory, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags(this CustomDetectionRuleAssociationFactory parentFactory, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null)
    {
        var factory = new InnerCustomDetectionRuleAssociationTagItemFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CustomDetectionRuleAssociationFactory, T1, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1>(this CombinedResult<CustomDetectionRuleAssociationFactory, T1> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CustomDetectionRuleAssociationFactory, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1>(this CombinedResult<T1, CustomDetectionRuleAssociationFactory> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CustomDetectionRuleAssociationFactory, T1, T2, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2>(this CombinedResult<CustomDetectionRuleAssociationFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CustomDetectionRuleAssociationFactory, T2, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, CustomDetectionRuleAssociationFactory, T2> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CustomDetectionRuleAssociationFactory, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, CustomDetectionRuleAssociationFactory> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CustomDetectionRuleAssociationFactory, T1, T2, T3, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<CustomDetectionRuleAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CustomDetectionRuleAssociationFactory, T2, T3, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, CustomDetectionRuleAssociationFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CustomDetectionRuleAssociationFactory, T3, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, CustomDetectionRuleAssociationFactory, T3> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CustomDetectionRuleAssociationFactory, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, CustomDetectionRuleAssociationFactory> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CustomDetectionRuleAssociationFactory, T1, T2, T3, T4, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<CustomDetectionRuleAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CustomDetectionRuleAssociationFactory, T2, T3, T4, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, CustomDetectionRuleAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CustomDetectionRuleAssociationFactory, T3, T4, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, CustomDetectionRuleAssociationFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CustomDetectionRuleAssociationFactory, T4, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CustomDetectionRuleAssociationFactory, T4> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CustomDetectionRuleAssociationFactory, InnerCustomDetectionRuleAssociationTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CustomDetectionRuleAssociationFactory> combinedResult, Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
