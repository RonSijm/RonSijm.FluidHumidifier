// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SupportApp;

public class SlackChannelConfigurationFactory(string resourceName = null, Action<Humidifier.SupportApp.SlackChannelConfiguration> factoryAction = null) : ResourceFactory<Humidifier.SupportApp.SlackChannelConfiguration>(resourceName)
{

    protected override Humidifier.SupportApp.SlackChannelConfiguration Create()
    {
        var slackChannelConfigurationResult = CreateSlackChannelConfiguration();
        factoryAction?.Invoke(slackChannelConfigurationResult);

        return slackChannelConfigurationResult;
    }

    private Humidifier.SupportApp.SlackChannelConfiguration CreateSlackChannelConfiguration()
    {
        var slackChannelConfigurationResult = new Humidifier.SupportApp.SlackChannelConfiguration
        {
            GivenName = InputResourceName,
        };

        return slackChannelConfigurationResult;
    }

} // End Of Class

public static class SlackChannelConfigurationFactoryExtensions
{
}
