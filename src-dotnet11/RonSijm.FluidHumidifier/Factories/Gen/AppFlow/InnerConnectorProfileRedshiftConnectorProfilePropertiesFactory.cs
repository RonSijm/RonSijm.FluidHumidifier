// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileRedshiftConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileProperties Create()
    {
        var redshiftConnectorProfilePropertiesResult = CreateRedshiftConnectorProfileProperties();
        factoryAction?.Invoke(redshiftConnectorProfilePropertiesResult);

        return redshiftConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileProperties CreateRedshiftConnectorProfileProperties()
    {
        var redshiftConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileProperties();

        return redshiftConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileRedshiftConnectorProfilePropertiesFactoryExtensions
{
}
