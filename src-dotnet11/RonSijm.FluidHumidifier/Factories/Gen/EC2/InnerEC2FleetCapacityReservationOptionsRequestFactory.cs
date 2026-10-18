// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetCapacityReservationOptionsRequestFactory(Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest>
{

    protected override Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest Create()
    {
        var capacityReservationOptionsRequestResult = CreateCapacityReservationOptionsRequest();
        factoryAction?.Invoke(capacityReservationOptionsRequestResult);

        return capacityReservationOptionsRequestResult;
    }

    private Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest CreateCapacityReservationOptionsRequest()
    {
        var capacityReservationOptionsRequestResult = new Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest();

        return capacityReservationOptionsRequestResult;
    }

} // End Of Class

public static class InnerEC2FleetCapacityReservationOptionsRequestFactoryExtensions
{
}
