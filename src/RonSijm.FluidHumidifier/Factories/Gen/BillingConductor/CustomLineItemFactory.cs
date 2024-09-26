// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class CustomLineItemFactory(string resourceName = null, Action<Humidifier.BillingConductor.CustomLineItem> factoryAction = null) : ResourceFactory<Humidifier.BillingConductor.CustomLineItem>(resourceName)
{

    internal InnerCustomLineItemBillingPeriodRangeFactory BillingPeriodRangeFactory { get; set; }

    internal InnerCustomLineItemCustomLineItemChargeDetailsFactory CustomLineItemChargeDetailsFactory { get; set; }

    protected override Humidifier.BillingConductor.CustomLineItem Create()
    {
        var customLineItemResult = CreateCustomLineItem();
        factoryAction?.Invoke(customLineItemResult);

        return customLineItemResult;
    }

    private Humidifier.BillingConductor.CustomLineItem CreateCustomLineItem()
    {
        var customLineItemResult = new Humidifier.BillingConductor.CustomLineItem
        {
            GivenName = InputResourceName,
        };

        return customLineItemResult;
    }
    public override void CreateChildren(Humidifier.BillingConductor.CustomLineItem result)
    {
        base.CreateChildren(result);

        result.BillingPeriodRange ??= BillingPeriodRangeFactory?.Build();
        result.CustomLineItemChargeDetails ??= CustomLineItemChargeDetailsFactory?.Build();
    }

} // End Of Class

public static class CustomLineItemFactoryExtensions
{
    public static CombinedResult<CustomLineItemFactory, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange(this CustomLineItemFactory parentFactory, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null)
    {
        parentFactory.BillingPeriodRangeFactory = new InnerCustomLineItemBillingPeriodRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BillingPeriodRangeFactory);
    }

    public static CombinedResult<CustomLineItemFactory, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails(this CustomLineItemFactory parentFactory, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null)
    {
        parentFactory.CustomLineItemChargeDetailsFactory = new InnerCustomLineItemCustomLineItemChargeDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomLineItemChargeDetailsFactory);
    }

    public static CombinedResult<CustomLineItemFactory, T1, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1>(this CombinedResult<CustomLineItemFactory, T1> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomLineItemFactory, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1>(this CombinedResult<T1, CustomLineItemFactory> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CustomLineItemFactory, T1, T2, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2>(this CombinedResult<CustomLineItemFactory, T1, T2> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomLineItemFactory, T2, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2>(this CombinedResult<T1, CustomLineItemFactory, T2> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomLineItemFactory, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2>(this CombinedResult<T1, T2, CustomLineItemFactory> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CustomLineItemFactory, T1, T2, T3, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2, T3>(this CombinedResult<CustomLineItemFactory, T1, T2, T3> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomLineItemFactory, T2, T3, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2, T3>(this CombinedResult<T1, CustomLineItemFactory, T2, T3> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomLineItemFactory, T3, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2, T3>(this CombinedResult<T1, T2, CustomLineItemFactory, T3> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomLineItemFactory, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, CustomLineItemFactory> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CustomLineItemFactory, T1, T2, T3, T4, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2, T3, T4>(this CombinedResult<CustomLineItemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomLineItemFactory, T2, T3, T4, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2, T3, T4>(this CombinedResult<T1, CustomLineItemFactory, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomLineItemFactory, T3, T4, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, CustomLineItemFactory, T3, T4> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomLineItemFactory, T4, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CustomLineItemFactory, T4> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CustomLineItemFactory, InnerCustomLineItemBillingPeriodRangeFactory> WithBillingPeriodRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CustomLineItemFactory> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBillingPeriodRange(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CustomLineItemFactory, T1, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1>(this CombinedResult<CustomLineItemFactory, T1> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomLineItemFactory, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1>(this CombinedResult<T1, CustomLineItemFactory> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CustomLineItemFactory, T1, T2, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2>(this CombinedResult<CustomLineItemFactory, T1, T2> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomLineItemFactory, T2, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2>(this CombinedResult<T1, CustomLineItemFactory, T2> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomLineItemFactory, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2>(this CombinedResult<T1, T2, CustomLineItemFactory> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CustomLineItemFactory, T1, T2, T3, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2, T3>(this CombinedResult<CustomLineItemFactory, T1, T2, T3> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomLineItemFactory, T2, T3, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2, T3>(this CombinedResult<T1, CustomLineItemFactory, T2, T3> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomLineItemFactory, T3, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2, T3>(this CombinedResult<T1, T2, CustomLineItemFactory, T3> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomLineItemFactory, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, CustomLineItemFactory> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CustomLineItemFactory, T1, T2, T3, T4, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2, T3, T4>(this CombinedResult<CustomLineItemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomLineItemFactory, T2, T3, T4, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2, T3, T4>(this CombinedResult<T1, CustomLineItemFactory, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomLineItemFactory, T3, T4, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, CustomLineItemFactory, T3, T4> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomLineItemFactory, T4, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CustomLineItemFactory, T4> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CustomLineItemFactory, InnerCustomLineItemCustomLineItemChargeDetailsFactory> WithCustomLineItemChargeDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CustomLineItemFactory> combinedResult, Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLineItemChargeDetails(combinedResult.T5, subFactoryAction));
}
