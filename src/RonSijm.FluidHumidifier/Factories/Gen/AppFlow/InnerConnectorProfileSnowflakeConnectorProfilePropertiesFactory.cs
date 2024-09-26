// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileSnowflakeConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileProperties Create()
    {
        var snowflakeConnectorProfilePropertiesResult = CreateSnowflakeConnectorProfileProperties();
        factoryAction?.Invoke(snowflakeConnectorProfilePropertiesResult);

        return snowflakeConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileProperties CreateSnowflakeConnectorProfileProperties()
    {
        var snowflakeConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileProperties();

        return snowflakeConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileSnowflakeConnectorProfilePropertiesFactoryExtensions
{
}
