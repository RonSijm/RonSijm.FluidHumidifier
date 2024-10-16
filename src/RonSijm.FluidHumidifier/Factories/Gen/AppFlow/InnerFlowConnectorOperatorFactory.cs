// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowConnectorOperatorFactory(Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.ConnectorOperator>
{

    protected override Humidifier.AppFlow.FlowTypes.ConnectorOperator Create()
    {
        var connectorOperatorResult = CreateConnectorOperator();
        factoryAction?.Invoke(connectorOperatorResult);

        return connectorOperatorResult;
    }

    private Humidifier.AppFlow.FlowTypes.ConnectorOperator CreateConnectorOperator()
    {
        var connectorOperatorResult = new Humidifier.AppFlow.FlowTypes.ConnectorOperator();

        return connectorOperatorResult;
    }

} // End Of Class

public static class InnerFlowConnectorOperatorFactoryExtensions
{
}
