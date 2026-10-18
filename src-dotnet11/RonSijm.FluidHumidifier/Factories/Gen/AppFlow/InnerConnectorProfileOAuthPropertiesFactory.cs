// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileOAuthPropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties Create()
    {
        var oAuthPropertiesResult = CreateOAuthProperties();
        factoryAction?.Invoke(oAuthPropertiesResult);

        return oAuthPropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties CreateOAuthProperties()
    {
        var oAuthPropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties();

        return oAuthPropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileOAuthPropertiesFactoryExtensions
{
}
