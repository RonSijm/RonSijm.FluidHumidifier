// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignTelephonyOutboundModeFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundMode> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundMode>
{

    internal InnerCampaignProgressiveConfigFactory ProgressiveConfigFactory { get; set; }

    internal InnerCampaignPredictiveConfigFactory PredictiveConfigFactory { get; set; }

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundMode Create()
    {
        var telephonyOutboundModeResult = CreateTelephonyOutboundMode();
        factoryAction?.Invoke(telephonyOutboundModeResult);

        return telephonyOutboundModeResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundMode CreateTelephonyOutboundMode()
    {
        var telephonyOutboundModeResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundMode();

        return telephonyOutboundModeResult;
    }
    public override void CreateChildren(Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundMode result)
    {
        base.CreateChildren(result);

        result.ProgressiveConfig ??= ProgressiveConfigFactory?.Build();
        result.PredictiveConfig ??= PredictiveConfigFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignTelephonyOutboundModeFactoryExtensions
{
    public static CombinedResult<InnerCampaignTelephonyOutboundModeFactory, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig(this InnerCampaignTelephonyOutboundModeFactory parentFactory, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null)
    {
        parentFactory.ProgressiveConfigFactory = new InnerCampaignProgressiveConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProgressiveConfigFactory);
    }

    public static CombinedResult<InnerCampaignTelephonyOutboundModeFactory, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig(this InnerCampaignTelephonyOutboundModeFactory parentFactory, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null)
    {
        parentFactory.PredictiveConfigFactory = new InnerCampaignPredictiveConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PredictiveConfigFactory);
    }

    public static CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1>(this CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1>(this CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2>(this CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2>(this CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2>(this CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2, T3, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2, T3>(this CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2, T3, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2, T3>(this CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory, T3, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundModeFactory, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundModeFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2, T3, T4, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2, T3, T4>(this CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2, T3, T4, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory, T3, T4, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundModeFactory, T4, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundModeFactory, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignTelephonyOutboundModeFactory, InnerCampaignProgressiveConfigFactory> WithProgressiveConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignTelephonyOutboundModeFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProgressiveConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1>(this CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1>(this CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2>(this CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2>(this CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2>(this CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2, T3, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2, T3>(this CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2, T3, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2, T3>(this CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory, T3, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundModeFactory, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundModeFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2, T3, T4, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2, T3, T4>(this CombinedResult<InnerCampaignTelephonyOutboundModeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2, T3, T4, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignTelephonyOutboundModeFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory, T3, T4, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignTelephonyOutboundModeFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundModeFactory, T4, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundModeFactory, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignTelephonyOutboundModeFactory, InnerCampaignPredictiveConfigFactory> WithPredictiveConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignTelephonyOutboundModeFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredictiveConfig(combinedResult.T5, subFactoryAction));
}
