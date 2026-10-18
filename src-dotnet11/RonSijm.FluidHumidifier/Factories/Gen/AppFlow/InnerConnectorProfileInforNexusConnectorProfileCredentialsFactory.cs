// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileInforNexusConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileCredentials Create()
    {
        var inforNexusConnectorProfileCredentialsResult = CreateInforNexusConnectorProfileCredentials();
        factoryAction?.Invoke(inforNexusConnectorProfileCredentialsResult);

        return inforNexusConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileCredentials CreateInforNexusConnectorProfileCredentials()
    {
        var inforNexusConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileCredentials();

        return inforNexusConnectorProfileCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileInforNexusConnectorProfileCredentialsFactoryExtensions
{
}
