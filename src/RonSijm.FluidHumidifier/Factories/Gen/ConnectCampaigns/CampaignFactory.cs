// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaigns;

public class CampaignFactory(string resourceName = null, Action<Humidifier.ConnectCampaigns.Campaign> factoryAction = null) : ResourceFactory<Humidifier.ConnectCampaigns.Campaign>(resourceName)
{

    internal InnerCampaignOutboundCallConfigFactory OutboundCallConfigFactory { get; set; }

    internal InnerCampaignDialerConfigFactory DialerConfigFactory { get; set; }

    protected override Humidifier.ConnectCampaigns.Campaign Create()
    {
        var campaignResult = CreateCampaign();
        factoryAction?.Invoke(campaignResult);

        return campaignResult;
    }

    private Humidifier.ConnectCampaigns.Campaign CreateCampaign()
    {
        var campaignResult = new Humidifier.ConnectCampaigns.Campaign
        {
            GivenName = InputResourceName,
        };

        return campaignResult;
    }
    public override void CreateChildren(Humidifier.ConnectCampaigns.Campaign result)
    {
        base.CreateChildren(result);

        result.OutboundCallConfig ??= OutboundCallConfigFactory?.Build();
        result.DialerConfig ??= DialerConfigFactory?.Build();
    }

} // End Of Class

public static class CampaignFactoryExtensions
{
    public static CombinedResult<CampaignFactory, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig(this CampaignFactory parentFactory, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null)
    {
        parentFactory.OutboundCallConfigFactory = new InnerCampaignOutboundCallConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutboundCallConfigFactory);
    }

    public static CombinedResult<CampaignFactory, InnerCampaignDialerConfigFactory> WithDialerConfig(this CampaignFactory parentFactory, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null)
    {
        parentFactory.DialerConfigFactory = new InnerCampaignDialerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DialerConfigFactory);
    }

    public static CombinedResult<CampaignFactory, T1, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1>(this CombinedResult<CampaignFactory, T1> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CampaignFactory, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1>(this CombinedResult<T1, CampaignFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CampaignFactory, T1, T2, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2>(this CombinedResult<CampaignFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CampaignFactory, T2, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2>(this CombinedResult<T1, CampaignFactory, T2> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CampaignFactory, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2>(this CombinedResult<T1, T2, CampaignFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CampaignFactory, T1, T2, T3, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2, T3>(this CombinedResult<CampaignFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CampaignFactory, T2, T3, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2, T3>(this CombinedResult<T1, CampaignFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CampaignFactory, T3, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2, T3>(this CombinedResult<T1, T2, CampaignFactory, T3> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CampaignFactory, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, CampaignFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CampaignFactory, T1, T2, T3, T4, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2, T3, T4>(this CombinedResult<CampaignFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CampaignFactory, T2, T3, T4, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2, T3, T4>(this CombinedResult<T1, CampaignFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CampaignFactory, T3, T4, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, CampaignFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CampaignFactory, T4, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CampaignFactory, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CampaignFactory, InnerCampaignOutboundCallConfigFactory> WithOutboundCallConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CampaignFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CampaignFactory, T1, InnerCampaignDialerConfigFactory> WithDialerConfig<T1>(this CombinedResult<CampaignFactory, T1> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDialerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CampaignFactory, InnerCampaignDialerConfigFactory> WithDialerConfig<T1>(this CombinedResult<T1, CampaignFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDialerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CampaignFactory, T1, T2, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2>(this CombinedResult<CampaignFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CampaignFactory, T2, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2>(this CombinedResult<T1, CampaignFactory, T2> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CampaignFactory, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2>(this CombinedResult<T1, T2, CampaignFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CampaignFactory, T1, T2, T3, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2, T3>(this CombinedResult<CampaignFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CampaignFactory, T2, T3, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2, T3>(this CombinedResult<T1, CampaignFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CampaignFactory, T3, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2, T3>(this CombinedResult<T1, T2, CampaignFactory, T3> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CampaignFactory, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, CampaignFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CampaignFactory, T1, T2, T3, T4, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2, T3, T4>(this CombinedResult<CampaignFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CampaignFactory, T2, T3, T4, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2, T3, T4>(this CombinedResult<T1, CampaignFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CampaignFactory, T3, T4, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, CampaignFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CampaignFactory, T4, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CampaignFactory, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CampaignFactory, InnerCampaignDialerConfigFactory> WithDialerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CampaignFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDialerConfig(combinedResult.T5, subFactoryAction));
}
