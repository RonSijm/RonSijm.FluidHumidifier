// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignEntryLimitsConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EntryLimitsConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.EntryLimitsConfig>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.EntryLimitsConfig Create()
    {
        var entryLimitsConfigResult = CreateEntryLimitsConfig();
        factoryAction?.Invoke(entryLimitsConfigResult);

        return entryLimitsConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.EntryLimitsConfig CreateEntryLimitsConfig()
    {
        var entryLimitsConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.EntryLimitsConfig();

        return entryLimitsConfigResult;
    }

} // End Of Class

public static class InnerCampaignEntryLimitsConfigFactoryExtensions
{
}
