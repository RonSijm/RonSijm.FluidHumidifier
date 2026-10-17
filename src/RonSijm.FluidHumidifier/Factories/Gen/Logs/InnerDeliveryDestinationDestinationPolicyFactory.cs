// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerDeliveryDestinationDestinationPolicyFactory(Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> factoryAction = null) : SubResourceFactory<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy>
{

    protected override Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy Create()
    {
        var destinationPolicyResult = CreateDestinationPolicy();
        factoryAction?.Invoke(destinationPolicyResult);

        return destinationPolicyResult;
    }

    private Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy CreateDestinationPolicy()
    {
        var destinationPolicyResult = new Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy();

        return destinationPolicyResult;
    }

} // End Of Class

public static class InnerDeliveryDestinationDestinationPolicyFactoryExtensions
{
}
