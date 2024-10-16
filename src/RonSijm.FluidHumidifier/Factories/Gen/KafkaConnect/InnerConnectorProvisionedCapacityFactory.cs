// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorProvisionedCapacityFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity Create()
    {
        var provisionedCapacityResult = CreateProvisionedCapacity();
        factoryAction?.Invoke(provisionedCapacityResult);

        return provisionedCapacityResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity CreateProvisionedCapacity()
    {
        var provisionedCapacityResult = new Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity();

        return provisionedCapacityResult;
    }

} // End Of Class

public static class InnerConnectorProvisionedCapacityFactoryExtensions
{
}
