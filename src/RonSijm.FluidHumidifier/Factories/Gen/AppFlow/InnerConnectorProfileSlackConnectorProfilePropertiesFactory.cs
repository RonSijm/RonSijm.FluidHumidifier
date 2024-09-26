// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileSlackConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.SlackConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.SlackConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.SlackConnectorProfileProperties Create()
    {
        var slackConnectorProfilePropertiesResult = CreateSlackConnectorProfileProperties();
        factoryAction?.Invoke(slackConnectorProfilePropertiesResult);

        return slackConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.SlackConnectorProfileProperties CreateSlackConnectorProfileProperties()
    {
        var slackConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.SlackConnectorProfileProperties();

        return slackConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileSlackConnectorProfilePropertiesFactoryExtensions
{
}
