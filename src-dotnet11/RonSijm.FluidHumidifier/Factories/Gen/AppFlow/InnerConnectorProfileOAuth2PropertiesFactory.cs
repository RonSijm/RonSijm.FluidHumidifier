// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileOAuth2PropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties Create()
    {
        var oAuth2PropertiesResult = CreateOAuth2Properties();
        factoryAction?.Invoke(oAuth2PropertiesResult);

        return oAuth2PropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties CreateOAuth2Properties()
    {
        var oAuth2PropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties();

        return oAuth2PropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileOAuth2PropertiesFactoryExtensions
{
}
