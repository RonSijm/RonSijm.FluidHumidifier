// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileRedshiftConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileCredentials Create()
    {
        var redshiftConnectorProfileCredentialsResult = CreateRedshiftConnectorProfileCredentials();
        factoryAction?.Invoke(redshiftConnectorProfileCredentialsResult);

        return redshiftConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileCredentials CreateRedshiftConnectorProfileCredentials()
    {
        var redshiftConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileCredentials();

        return redshiftConnectorProfileCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileRedshiftConnectorProfileCredentialsFactoryExtensions
{
}
