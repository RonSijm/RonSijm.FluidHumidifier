// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignEventDimensionsFactory(Action<Humidifier.Pinpoint.CampaignTypes.EventDimensions> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.EventDimensions>
{

    internal InnerCampaignSetDimensionFactory EventTypeFactory { get; set; }

    protected override Humidifier.Pinpoint.CampaignTypes.EventDimensions Create()
    {
        var eventDimensionsResult = CreateEventDimensions();
        factoryAction?.Invoke(eventDimensionsResult);

        return eventDimensionsResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.EventDimensions CreateEventDimensions()
    {
        var eventDimensionsResult = new Humidifier.Pinpoint.CampaignTypes.EventDimensions();

        return eventDimensionsResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.CampaignTypes.EventDimensions result)
    {
        base.CreateChildren(result);

        result.EventType ??= EventTypeFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignEventDimensionsFactoryExtensions
{
    public static CombinedResult<InnerCampaignEventDimensionsFactory, InnerCampaignSetDimensionFactory> WithEventType(this InnerCampaignEventDimensionsFactory parentFactory, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null)
    {
        parentFactory.EventTypeFactory = new InnerCampaignSetDimensionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventTypeFactory);
    }

    public static CombinedResult<InnerCampaignEventDimensionsFactory, T1, InnerCampaignSetDimensionFactory> WithEventType<T1>(this CombinedResult<InnerCampaignEventDimensionsFactory, T1> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignEventDimensionsFactory, InnerCampaignSetDimensionFactory> WithEventType<T1>(this CombinedResult<T1, InnerCampaignEventDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignEventDimensionsFactory, T1, T2, InnerCampaignSetDimensionFactory> WithEventType<T1, T2>(this CombinedResult<InnerCampaignEventDimensionsFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignEventDimensionsFactory, T2, InnerCampaignSetDimensionFactory> WithEventType<T1, T2>(this CombinedResult<T1, InnerCampaignEventDimensionsFactory, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignEventDimensionsFactory, InnerCampaignSetDimensionFactory> WithEventType<T1, T2>(this CombinedResult<T1, T2, InnerCampaignEventDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignEventDimensionsFactory, T1, T2, T3, InnerCampaignSetDimensionFactory> WithEventType<T1, T2, T3>(this CombinedResult<InnerCampaignEventDimensionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignEventDimensionsFactory, T2, T3, InnerCampaignSetDimensionFactory> WithEventType<T1, T2, T3>(this CombinedResult<T1, InnerCampaignEventDimensionsFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignEventDimensionsFactory, T3, InnerCampaignSetDimensionFactory> WithEventType<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignEventDimensionsFactory, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignEventDimensionsFactory, InnerCampaignSetDimensionFactory> WithEventType<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignEventDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignEventDimensionsFactory, T1, T2, T3, T4, InnerCampaignSetDimensionFactory> WithEventType<T1, T2, T3, T4>(this CombinedResult<InnerCampaignEventDimensionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignEventDimensionsFactory, T2, T3, T4, InnerCampaignSetDimensionFactory> WithEventType<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignEventDimensionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignEventDimensionsFactory, T3, T4, InnerCampaignSetDimensionFactory> WithEventType<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignEventDimensionsFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignEventDimensionsFactory, T4, InnerCampaignSetDimensionFactory> WithEventType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignEventDimensionsFactory, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignEventDimensionsFactory, InnerCampaignSetDimensionFactory> WithEventType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignEventDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T5, subFactoryAction));
}
