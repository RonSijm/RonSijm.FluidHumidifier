// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignSourceFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.Source>
{

    internal InnerCampaignEventTriggerFactory EventTriggerFactory { get; set; }

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.Source();

        return sourceResult;
    }
    public override void CreateChildren(Humidifier.ConnectCampaignsV2.CampaignTypes.Source result)
    {
        base.CreateChildren(result);

        result.EventTrigger ??= EventTriggerFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignSourceFactoryExtensions
{
    public static CombinedResult<InnerCampaignSourceFactory, InnerCampaignEventTriggerFactory> WithEventTrigger(this InnerCampaignSourceFactory parentFactory, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null)
    {
        parentFactory.EventTriggerFactory = new InnerCampaignEventTriggerFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventTriggerFactory);
    }

    public static CombinedResult<InnerCampaignSourceFactory, T1, InnerCampaignEventTriggerFactory> WithEventTrigger<T1>(this CombinedResult<InnerCampaignSourceFactory, T1> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventTrigger(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSourceFactory, InnerCampaignEventTriggerFactory> WithEventTrigger<T1>(this CombinedResult<T1, InnerCampaignSourceFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventTrigger(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignSourceFactory, T1, T2, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2>(this CombinedResult<InnerCampaignSourceFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSourceFactory, T2, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2>(this CombinedResult<T1, InnerCampaignSourceFactory, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSourceFactory, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2>(this CombinedResult<T1, T2, InnerCampaignSourceFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignSourceFactory, T1, T2, T3, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2, T3>(this CombinedResult<InnerCampaignSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSourceFactory, T2, T3, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2, T3>(this CombinedResult<T1, InnerCampaignSourceFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSourceFactory, T3, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignSourceFactory, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignSourceFactory, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignSourceFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignSourceFactory, T1, T2, T3, T4, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2, T3, T4>(this CombinedResult<InnerCampaignSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSourceFactory, T2, T3, T4, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSourceFactory, T3, T4, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignSourceFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignSourceFactory, T4, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignSourceFactory, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignSourceFactory, InnerCampaignEventTriggerFactory> WithEventTrigger<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignSourceFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTrigger(combinedResult.T5, subFactoryAction));
}
