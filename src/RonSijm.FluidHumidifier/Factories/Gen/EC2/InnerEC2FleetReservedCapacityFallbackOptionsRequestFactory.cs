// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetReservedCapacityFallbackOptionsRequestFactory(Action<Humidifier.EC2.EC2FleetTypes.ReservedCapacityFallbackOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.ReservedCapacityFallbackOptionsRequest>
{

    protected override Humidifier.EC2.EC2FleetTypes.ReservedCapacityFallbackOptionsRequest Create()
    {
        var reservedCapacityFallbackOptionsRequestResult = CreateReservedCapacityFallbackOptionsRequest();
        factoryAction?.Invoke(reservedCapacityFallbackOptionsRequestResult);

        return reservedCapacityFallbackOptionsRequestResult;
    }

    private Humidifier.EC2.EC2FleetTypes.ReservedCapacityFallbackOptionsRequest CreateReservedCapacityFallbackOptionsRequest()
    {
        var reservedCapacityFallbackOptionsRequestResult = new Humidifier.EC2.EC2FleetTypes.ReservedCapacityFallbackOptionsRequest();

        return reservedCapacityFallbackOptionsRequestResult;
    }

} // End Of Class

public static class InnerEC2FleetReservedCapacityFallbackOptionsRequestFactoryExtensions
{
}
