// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chatbot;

public class MicrosoftTeamsChannelConfigurationFactory(string resourceName = null, Action<Humidifier.Chatbot.MicrosoftTeamsChannelConfiguration> factoryAction = null) : ResourceFactory<Humidifier.Chatbot.MicrosoftTeamsChannelConfiguration>(resourceName)
{

    protected override Humidifier.Chatbot.MicrosoftTeamsChannelConfiguration Create()
    {
        var microsoftTeamsChannelConfigurationResult = CreateMicrosoftTeamsChannelConfiguration();
        factoryAction?.Invoke(microsoftTeamsChannelConfigurationResult);

        return microsoftTeamsChannelConfigurationResult;
    }

    private Humidifier.Chatbot.MicrosoftTeamsChannelConfiguration CreateMicrosoftTeamsChannelConfiguration()
    {
        var microsoftTeamsChannelConfigurationResult = new Humidifier.Chatbot.MicrosoftTeamsChannelConfiguration
        {
            GivenName = InputResourceName,
        };

        return microsoftTeamsChannelConfigurationResult;
    }

} // End Of Class

public static class MicrosoftTeamsChannelConfigurationFactoryExtensions
{
}
