// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorVpcFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.Vpc>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.Vpc Create()
    {
        var vpcResult = CreateVpc();
        factoryAction?.Invoke(vpcResult);

        return vpcResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.Vpc CreateVpc()
    {
        var vpcResult = new Humidifier.KafkaConnect.ConnectorTypes.Vpc();

        return vpcResult;
    }

} // End Of Class

public static class InnerConnectorVpcFactoryExtensions
{
}
