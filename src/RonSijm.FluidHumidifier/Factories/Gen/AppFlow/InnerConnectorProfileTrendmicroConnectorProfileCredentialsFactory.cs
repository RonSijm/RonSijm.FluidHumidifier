// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileTrendmicroConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.TrendmicroConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.TrendmicroConnectorProfileCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.TrendmicroConnectorProfileCredentials Create()
    {
        var trendmicroConnectorProfileCredentialsResult = CreateTrendmicroConnectorProfileCredentials();
        factoryAction?.Invoke(trendmicroConnectorProfileCredentialsResult);

        return trendmicroConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.TrendmicroConnectorProfileCredentials CreateTrendmicroConnectorProfileCredentials()
    {
        var trendmicroConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.TrendmicroConnectorProfileCredentials();

        return trendmicroConnectorProfileCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileTrendmicroConnectorProfileCredentialsFactoryExtensions
{
}
