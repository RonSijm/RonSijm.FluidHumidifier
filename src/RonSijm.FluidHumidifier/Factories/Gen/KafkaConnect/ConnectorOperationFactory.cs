// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class ConnectorOperationFactory(string resourceName = null, Action<Humidifier.KafkaConnect.ConnectorOperation> factoryAction = null) : ResourceFactory<Humidifier.KafkaConnect.ConnectorOperation>(resourceName)
{

    protected override Humidifier.KafkaConnect.ConnectorOperation Create()
    {
        var connectorOperationResult = CreateConnectorOperation();
        factoryAction?.Invoke(connectorOperationResult);

        return connectorOperationResult;
    }

    private Humidifier.KafkaConnect.ConnectorOperation CreateConnectorOperation()
    {
        var connectorOperationResult = new Humidifier.KafkaConnect.ConnectorOperation
        {
            GivenName = InputResourceName,
        };

        return connectorOperationResult;
    }

} // End Of Class

public static class ConnectorOperationFactoryExtensions
{
}
