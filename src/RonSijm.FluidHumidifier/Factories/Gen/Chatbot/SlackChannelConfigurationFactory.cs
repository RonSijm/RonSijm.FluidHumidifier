// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chatbot;

public class SlackChannelConfigurationFactory(string resourceName = null, Action<Humidifier.Chatbot.SlackChannelConfiguration> factoryAction = null) : ResourceFactory<Humidifier.Chatbot.SlackChannelConfiguration>(resourceName)
{

    protected override Humidifier.Chatbot.SlackChannelConfiguration Create()
    {
        var slackChannelConfigurationResult = CreateSlackChannelConfiguration();
        factoryAction?.Invoke(slackChannelConfigurationResult);

        return slackChannelConfigurationResult;
    }

    private Humidifier.Chatbot.SlackChannelConfiguration CreateSlackChannelConfiguration()
    {
        var slackChannelConfigurationResult = new Humidifier.Chatbot.SlackChannelConfiguration
        {
            GivenName = InputResourceName,
        };

        return slackChannelConfigurationResult;
    }

} // End Of Class

public static class SlackChannelConfigurationFactoryExtensions
{
}
