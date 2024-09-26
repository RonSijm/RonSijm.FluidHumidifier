// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaigns;

public class InnerCampaignAgentlessDialerConfigFactory(Action<Humidifier.ConnectCampaigns.CampaignTypes.AgentlessDialerConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaigns.CampaignTypes.AgentlessDialerConfig>
{

    protected override Humidifier.ConnectCampaigns.CampaignTypes.AgentlessDialerConfig Create()
    {
        var agentlessDialerConfigResult = CreateAgentlessDialerConfig();
        factoryAction?.Invoke(agentlessDialerConfigResult);

        return agentlessDialerConfigResult;
    }

    private Humidifier.ConnectCampaigns.CampaignTypes.AgentlessDialerConfig CreateAgentlessDialerConfig()
    {
        var agentlessDialerConfigResult = new Humidifier.ConnectCampaigns.CampaignTypes.AgentlessDialerConfig();

        return agentlessDialerConfigResult;
    }

} // End Of Class

public static class InnerCampaignAgentlessDialerConfigFactoryExtensions
{
}
