// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignCommunicationLimitsConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimitsConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimitsConfig>
{

    internal InnerCampaignCommunicationLimitsFactory AllChannelsSubtypesFactory { get; set; }

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimitsConfig Create()
    {
        var communicationLimitsConfigResult = CreateCommunicationLimitsConfig();
        factoryAction?.Invoke(communicationLimitsConfigResult);

        return communicationLimitsConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimitsConfig CreateCommunicationLimitsConfig()
    {
        var communicationLimitsConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimitsConfig();

        return communicationLimitsConfigResult;
    }
    public override void CreateChildren(Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimitsConfig result)
    {
        base.CreateChildren(result);

        result.AllChannelsSubtypes ??= AllChannelsSubtypesFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignCommunicationLimitsConfigFactoryExtensions
{
    public static CombinedResult<InnerCampaignCommunicationLimitsConfigFactory, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes(this InnerCampaignCommunicationLimitsConfigFactory parentFactory, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null)
    {
        parentFactory.AllChannelsSubtypesFactory = new InnerCampaignCommunicationLimitsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AllChannelsSubtypesFactory);
    }

    public static CombinedResult<InnerCampaignCommunicationLimitsConfigFactory, T1, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1>(this CombinedResult<InnerCampaignCommunicationLimitsConfigFactory, T1> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignCommunicationLimitsConfigFactory, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1>(this CombinedResult<T1, InnerCampaignCommunicationLimitsConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignCommunicationLimitsConfigFactory, T1, T2, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2>(this CombinedResult<InnerCampaignCommunicationLimitsConfigFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignCommunicationLimitsConfigFactory, T2, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2>(this CombinedResult<T1, InnerCampaignCommunicationLimitsConfigFactory, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignCommunicationLimitsConfigFactory, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2>(this CombinedResult<T1, T2, InnerCampaignCommunicationLimitsConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignCommunicationLimitsConfigFactory, T1, T2, T3, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2, T3>(this CombinedResult<InnerCampaignCommunicationLimitsConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignCommunicationLimitsConfigFactory, T2, T3, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2, T3>(this CombinedResult<T1, InnerCampaignCommunicationLimitsConfigFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignCommunicationLimitsConfigFactory, T3, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignCommunicationLimitsConfigFactory, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignCommunicationLimitsConfigFactory, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignCommunicationLimitsConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignCommunicationLimitsConfigFactory, T1, T2, T3, T4, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2, T3, T4>(this CombinedResult<InnerCampaignCommunicationLimitsConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignCommunicationLimitsConfigFactory, T2, T3, T4, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignCommunicationLimitsConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignCommunicationLimitsConfigFactory, T3, T4, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignCommunicationLimitsConfigFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignCommunicationLimitsConfigFactory, T4, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignCommunicationLimitsConfigFactory, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignCommunicationLimitsConfigFactory, InnerCampaignCommunicationLimitsFactory> WithAllChannelsSubtypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignCommunicationLimitsConfigFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllChannelsSubtypes(combinedResult.T5, subFactoryAction));
}
