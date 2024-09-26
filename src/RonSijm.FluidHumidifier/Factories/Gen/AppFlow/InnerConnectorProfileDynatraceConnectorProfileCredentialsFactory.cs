// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileDynatraceConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileCredentials Create()
    {
        var dynatraceConnectorProfileCredentialsResult = CreateDynatraceConnectorProfileCredentials();
        factoryAction?.Invoke(dynatraceConnectorProfileCredentialsResult);

        return dynatraceConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileCredentials CreateDynatraceConnectorProfileCredentials()
    {
        var dynatraceConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileCredentials();

        return dynatraceConnectorProfileCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileDynatraceConnectorProfileCredentialsFactoryExtensions
{
}
