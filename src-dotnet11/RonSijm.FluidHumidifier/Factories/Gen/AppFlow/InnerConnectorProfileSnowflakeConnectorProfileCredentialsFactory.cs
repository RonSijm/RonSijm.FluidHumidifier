// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileSnowflakeConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileCredentials Create()
    {
        var snowflakeConnectorProfileCredentialsResult = CreateSnowflakeConnectorProfileCredentials();
        factoryAction?.Invoke(snowflakeConnectorProfileCredentialsResult);

        return snowflakeConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileCredentials CreateSnowflakeConnectorProfileCredentials()
    {
        var snowflakeConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileCredentials();

        return snowflakeConnectorProfileCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileSnowflakeConnectorProfileCredentialsFactoryExtensions
{
}
