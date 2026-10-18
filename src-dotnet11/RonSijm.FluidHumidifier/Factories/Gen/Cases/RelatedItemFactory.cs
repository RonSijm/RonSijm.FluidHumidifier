// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class RelatedItemFactory(string resourceName = null, Action<Humidifier.Cases.RelatedItem> factoryAction = null) : ResourceFactory<Humidifier.Cases.RelatedItem>(resourceName)
{

    internal InnerRelatedItemRelatedItemContentFactory ContentFactory { get; set; }

    protected override Humidifier.Cases.RelatedItem Create()
    {
        var relatedItemResult = CreateRelatedItem();
        factoryAction?.Invoke(relatedItemResult);

        return relatedItemResult;
    }

    private Humidifier.Cases.RelatedItem CreateRelatedItem()
    {
        var relatedItemResult = new Humidifier.Cases.RelatedItem
        {
            GivenName = InputResourceName,
        };

        return relatedItemResult;
    }
    public override void CreateChildren(Humidifier.Cases.RelatedItem result)
    {
        base.CreateChildren(result);

        result.Content ??= ContentFactory?.Build();
    }

} // End Of Class

public static class RelatedItemFactoryExtensions
{
    public static CombinedResult<RelatedItemFactory, InnerRelatedItemRelatedItemContentFactory> WithContent(this RelatedItemFactory parentFactory, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null)
    {
        parentFactory.ContentFactory = new InnerRelatedItemRelatedItemContentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContentFactory);
    }

    public static CombinedResult<RelatedItemFactory, T1, InnerRelatedItemRelatedItemContentFactory> WithContent<T1>(this CombinedResult<RelatedItemFactory, T1> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RelatedItemFactory, InnerRelatedItemRelatedItemContentFactory> WithContent<T1>(this CombinedResult<T1, RelatedItemFactory> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RelatedItemFactory, T1, T2, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2>(this CombinedResult<RelatedItemFactory, T1, T2> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RelatedItemFactory, T2, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2>(this CombinedResult<T1, RelatedItemFactory, T2> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RelatedItemFactory, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2>(this CombinedResult<T1, T2, RelatedItemFactory> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RelatedItemFactory, T1, T2, T3, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2, T3>(this CombinedResult<RelatedItemFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RelatedItemFactory, T2, T3, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, RelatedItemFactory, T2, T3> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RelatedItemFactory, T3, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, RelatedItemFactory, T3> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RelatedItemFactory, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, T3, RelatedItemFactory> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RelatedItemFactory, T1, T2, T3, T4, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<RelatedItemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RelatedItemFactory, T2, T3, T4, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, RelatedItemFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RelatedItemFactory, T3, T4, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, RelatedItemFactory, T3, T4> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RelatedItemFactory, T4, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RelatedItemFactory, T4> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RelatedItemFactory, InnerRelatedItemRelatedItemContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RelatedItemFactory> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T5, subFactoryAction).T2);
}
