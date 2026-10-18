// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SupportApp;

public class SlackWorkspaceConfigurationFactory(string resourceName = null, Action<Humidifier.SupportApp.SlackWorkspaceConfiguration> factoryAction = null) : ResourceFactory<Humidifier.SupportApp.SlackWorkspaceConfiguration>(resourceName)
{

    protected override Humidifier.SupportApp.SlackWorkspaceConfiguration Create()
    {
        var slackWorkspaceConfigurationResult = CreateSlackWorkspaceConfiguration();
        factoryAction?.Invoke(slackWorkspaceConfigurationResult);

        return slackWorkspaceConfigurationResult;
    }

    private Humidifier.SupportApp.SlackWorkspaceConfiguration CreateSlackWorkspaceConfiguration()
    {
        var slackWorkspaceConfigurationResult = new Humidifier.SupportApp.SlackWorkspaceConfiguration
        {
            GivenName = InputResourceName,
        };

        return slackWorkspaceConfigurationResult;
    }

} // End Of Class

public static class SlackWorkspaceConfigurationFactoryExtensions
{
}
