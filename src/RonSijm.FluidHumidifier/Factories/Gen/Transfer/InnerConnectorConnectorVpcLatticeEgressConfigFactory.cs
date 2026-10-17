// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerConnectorConnectorVpcLatticeEgressConfigFactory(Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig>
{

    protected override Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig Create()
    {
        var connectorVpcLatticeEgressConfigResult = CreateConnectorVpcLatticeEgressConfig();
        factoryAction?.Invoke(connectorVpcLatticeEgressConfigResult);

        return connectorVpcLatticeEgressConfigResult;
    }

    private Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig CreateConnectorVpcLatticeEgressConfig()
    {
        var connectorVpcLatticeEgressConfigResult = new Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig();

        return connectorVpcLatticeEgressConfigResult;
    }

} // End Of Class

public static class InnerConnectorConnectorVpcLatticeEgressConfigFactoryExtensions
{
}
