// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaigns;

public class InnerCampaignOutboundCallConfigFactory(Action<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig>
{

    internal InnerCampaignAnswerMachineDetectionConfigFactory AnswerMachineDetectionConfigFactory { get; set; }

    protected override Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig Create()
    {
        var outboundCallConfigResult = CreateOutboundCallConfig();
        factoryAction?.Invoke(outboundCallConfigResult);

        return outboundCallConfigResult;
    }

    private Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig CreateOutboundCallConfig()
    {
        var outboundCallConfigResult = new Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig();

        return outboundCallConfigResult;
    }
    public override void CreateChildren(Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig result)
    {
        base.CreateChildren(result);

        result.AnswerMachineDetectionConfig ??= AnswerMachineDetectionConfigFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignOutboundCallConfigFactoryExtensions
{
    public static CombinedResult<InnerCampaignOutboundCallConfigFactory, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig(this InnerCampaignOutboundCallConfigFactory parentFactory, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null)
    {
        parentFactory.AnswerMachineDetectionConfigFactory = new InnerCampaignAnswerMachineDetectionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AnswerMachineDetectionConfigFactory);
    }

    public static CombinedResult<InnerCampaignOutboundCallConfigFactory, T1, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1>(this CombinedResult<InnerCampaignOutboundCallConfigFactory, T1> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignOutboundCallConfigFactory, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1>(this CombinedResult<T1, InnerCampaignOutboundCallConfigFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignOutboundCallConfigFactory, T1, T2, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2>(this CombinedResult<InnerCampaignOutboundCallConfigFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignOutboundCallConfigFactory, T2, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2>(this CombinedResult<T1, InnerCampaignOutboundCallConfigFactory, T2> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignOutboundCallConfigFactory, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2>(this CombinedResult<T1, T2, InnerCampaignOutboundCallConfigFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignOutboundCallConfigFactory, T1, T2, T3, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3>(this CombinedResult<InnerCampaignOutboundCallConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignOutboundCallConfigFactory, T2, T3, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3>(this CombinedResult<T1, InnerCampaignOutboundCallConfigFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignOutboundCallConfigFactory, T3, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignOutboundCallConfigFactory, T3> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignOutboundCallConfigFactory, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignOutboundCallConfigFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignOutboundCallConfigFactory, T1, T2, T3, T4, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3, T4>(this CombinedResult<InnerCampaignOutboundCallConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignOutboundCallConfigFactory, T2, T3, T4, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignOutboundCallConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignOutboundCallConfigFactory, T3, T4, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignOutboundCallConfigFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignOutboundCallConfigFactory, T4, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignOutboundCallConfigFactory, T4> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignOutboundCallConfigFactory, InnerCampaignAnswerMachineDetectionConfigFactory> WithAnswerMachineDetectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignOutboundCallConfigFactory> combinedResult, Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnswerMachineDetectionConfig(combinedResult.T5, subFactoryAction));
}
