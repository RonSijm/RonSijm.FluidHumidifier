// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileSingularConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.SingularConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.SingularConnectorProfileCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.SingularConnectorProfileCredentials Create()
    {
        var singularConnectorProfileCredentialsResult = CreateSingularConnectorProfileCredentials();
        factoryAction?.Invoke(singularConnectorProfileCredentialsResult);

        return singularConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.SingularConnectorProfileCredentials CreateSingularConnectorProfileCredentials()
    {
        var singularConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.SingularConnectorProfileCredentials();

        return singularConnectorProfileCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileSingularConnectorProfileCredentialsFactoryExtensions
{
}
