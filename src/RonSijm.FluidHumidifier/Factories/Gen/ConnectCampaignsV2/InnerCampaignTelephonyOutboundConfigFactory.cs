// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignTelephonyOutboundConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundConfig>
{

    internal InnerCampaignAnswerMachineDetectionConfigFactory AnswerMachineDetectionConfigFactory { get; set; }

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundConfig Create()
    {
        var telephonyOutboundConfigResult = CreateTelephonyOutboundConfig();
        factoryAction?.Invoke(telephonyOutboundConfigResult);

        return telephonyOutboundConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundConfig CreateTelephonyOutboundConfig()
    {
        var telephonyOutboundConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundConfig();

        return telephonyOutboundConfigResult;
    }
    public override void CreateChildren(Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundConfig result)
    {
        base.CreateChildren(result);

        result.AnswerMachineDetectionConfig ??= AnswerMachineDetectionConfigFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignTelephonyOutboundConfigFactoryExtensions
{
    public static CombinedResult<InnerCampaignTelephonyOutboundConfigFactory, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig(this InnerCampaignTelephonyOutboundConfigFactory parentFactory, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null)
    {
        parentFactory.AnswerMachineDetectionConfigFactory = new InnerCampaignAnswerMachineDetectionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AnswerMachineDetectionConfigFactory);
    }

    public static CombinedResult<InnerCampaignTelephonyOutboundConfigFactory, T1, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1>(this CombinedResult<InnerCampaignTelephonyOutboundConfigFactory, T1> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundConfigFactory, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1>(this CombinedResult<T1, InnerCampaignTelephonyOutboundConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignTelephonyOutboundConfigFactory, T1, T2, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2>(this CombinedResult<InnerCampaignTelephonyOutboundConfigFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundConfigFactory, T2, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2>(this CombinedResult<T1, InnerCampaignTelephonyOutboundConfigFactory, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTelephonyOutboundConfigFactory, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2>(this CombinedResult<T1, T2, InnerCampaignTelephonyOutboundConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignTelephonyOutboundConfigFactory, T1, T2, T3, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3>(this CombinedResult<InnerCampaignTelephonyOutboundConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundConfigFactory, T2, T3, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3>(this CombinedResult<T1, InnerCampaignTelephonyOutboundConfigFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTelephonyOutboundConfigFactory, T3, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignTelephonyOutboundConfigFactory, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundConfigFactory, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignTelephonyOutboundConfigFactory, T1, T2, T3, T4, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3, T4>(this CombinedResult<InnerCampaignTelephonyOutboundConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTelephonyOutboundConfigFactory, T2, T3, T4, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignTelephonyOutboundConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTelephonyOutboundConfigFactory, T3, T4, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignTelephonyOutboundConfigFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundConfigFactory, T4, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignTelephonyOutboundConfigFactory, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignTelephonyOutboundConfigFactory, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignTelephonyOutboundConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T5, subFactoryAction));
}
