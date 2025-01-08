// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignCommunicationLimitsFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits Create()
    {
        var communicationLimitsResult = CreateCommunicationLimits();
        factoryAction?.Invoke(communicationLimitsResult);

        return communicationLimitsResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits CreateCommunicationLimits()
    {
        var communicationLimitsResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits();

        return communicationLimitsResult;
    }

} // End Of Class

public static class InnerCampaignCommunicationLimitsFactoryExtensions
{
}
