// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignPreviewConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PreviewConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.PreviewConfig>
{

    internal InnerCampaignTimeoutConfigFactory TimeoutConfigFactory { get; set; }

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.PreviewConfig Create()
    {
        var previewConfigResult = CreatePreviewConfig();
        factoryAction?.Invoke(previewConfigResult);

        return previewConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.PreviewConfig CreatePreviewConfig()
    {
        var previewConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.PreviewConfig();

        return previewConfigResult;
    }
    public override void CreateChildren(Humidifier.ConnectCampaignsV2.CampaignTypes.PreviewConfig result)
    {
        base.CreateChildren(result);

        result.TimeoutConfig ??= TimeoutConfigFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignPreviewConfigFactoryExtensions
{
    public static CombinedResult<InnerCampaignPreviewConfigFactory, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig(this InnerCampaignPreviewConfigFactory parentFactory, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null)
    {
        parentFactory.TimeoutConfigFactory = new InnerCampaignTimeoutConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimeoutConfigFactory);
    }

    public static CombinedResult<InnerCampaignPreviewConfigFactory, T1, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1>(this CombinedResult<InnerCampaignPreviewConfigFactory, T1> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCampaignPreviewConfigFactory, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1>(this CombinedResult<T1, InnerCampaignPreviewConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCampaignPreviewConfigFactory, T1, T2, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2>(this CombinedResult<InnerCampaignPreviewConfigFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCampaignPreviewConfigFactory, T2, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2>(this CombinedResult<T1, InnerCampaignPreviewConfigFactory, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCampaignPreviewConfigFactory, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2>(this CombinedResult<T1, T2, InnerCampaignPreviewConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCampaignPreviewConfigFactory, T1, T2, T3, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3>(this CombinedResult<InnerCampaignPreviewConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCampaignPreviewConfigFactory, T2, T3, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3>(this CombinedResult<T1, InnerCampaignPreviewConfigFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCampaignPreviewConfigFactory, T3, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignPreviewConfigFactory, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCampaignPreviewConfigFactory, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignPreviewConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCampaignPreviewConfigFactory, T1, T2, T3, T4, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3, T4>(this CombinedResult<InnerCampaignPreviewConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCampaignPreviewConfigFactory, T2, T3, T4, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignPreviewConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCampaignPreviewConfigFactory, T3, T4, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignPreviewConfigFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCampaignPreviewConfigFactory, T4, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignPreviewConfigFactory, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignPreviewConfigFactory, InnerCampaignTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignPreviewConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T5, subFactoryAction).T2);
}
