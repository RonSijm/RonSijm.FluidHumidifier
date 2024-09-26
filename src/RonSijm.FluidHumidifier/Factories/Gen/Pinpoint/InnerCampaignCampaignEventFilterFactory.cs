// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignCampaignEventFilterFactory(Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter>
{

    internal InnerCampaignEventDimensionsFactory DimensionsFactory { get; set; }

    protected override Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter Create()
    {
        var campaignEventFilterResult = CreateCampaignEventFilter();
        factoryAction?.Invoke(campaignEventFilterResult);

        return campaignEventFilterResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter CreateCampaignEventFilter()
    {
        var campaignEventFilterResult = new Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter();

        return campaignEventFilterResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter result)
    {
        base.CreateChildren(result);

        result.Dimensions ??= DimensionsFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignCampaignEventFilterFactoryExtensions
{
    public static CombinedResult<InnerCampaignCampaignEventFilterFactory, InnerCampaignEventDimensionsFactory> WithDimensions(this InnerCampaignCampaignEventFilterFactory parentFactory, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null)
    {
        parentFactory.DimensionsFactory = new InnerCampaignEventDimensionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DimensionsFactory);
    }

    public static CombinedResult<InnerCampaignCampaignEventFilterFactory, T1, InnerCampaignEventDimensionsFactory> WithDimensions<T1>(this CombinedResult<InnerCampaignCampaignEventFilterFactory, T1> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignCampaignEventFilterFactory, InnerCampaignEventDimensionsFactory> WithDimensions<T1>(this CombinedResult<T1, InnerCampaignCampaignEventFilterFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignCampaignEventFilterFactory, T1, T2, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2>(this CombinedResult<InnerCampaignCampaignEventFilterFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignCampaignEventFilterFactory, T2, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2>(this CombinedResult<T1, InnerCampaignCampaignEventFilterFactory, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignCampaignEventFilterFactory, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2>(this CombinedResult<T1, T2, InnerCampaignCampaignEventFilterFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignCampaignEventFilterFactory, T1, T2, T3, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2, T3>(this CombinedResult<InnerCampaignCampaignEventFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignCampaignEventFilterFactory, T2, T3, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2, T3>(this CombinedResult<T1, InnerCampaignCampaignEventFilterFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignCampaignEventFilterFactory, T3, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignCampaignEventFilterFactory, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignCampaignEventFilterFactory, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignCampaignEventFilterFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignCampaignEventFilterFactory, T1, T2, T3, T4, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<InnerCampaignCampaignEventFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignCampaignEventFilterFactory, T2, T3, T4, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignCampaignEventFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignCampaignEventFilterFactory, T3, T4, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignCampaignEventFilterFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignCampaignEventFilterFactory, T4, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignCampaignEventFilterFactory, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignCampaignEventFilterFactory, InnerCampaignEventDimensionsFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignCampaignEventFilterFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T5, subFactoryAction));
}
