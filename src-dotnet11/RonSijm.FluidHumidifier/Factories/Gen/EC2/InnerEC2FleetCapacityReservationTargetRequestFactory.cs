// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetCapacityReservationTargetRequestFactory(Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationTargetRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.CapacityReservationTargetRequest>
{

    protected override Humidifier.EC2.EC2FleetTypes.CapacityReservationTargetRequest Create()
    {
        var capacityReservationTargetRequestResult = CreateCapacityReservationTargetRequest();
        factoryAction?.Invoke(capacityReservationTargetRequestResult);

        return capacityReservationTargetRequestResult;
    }

    private Humidifier.EC2.EC2FleetTypes.CapacityReservationTargetRequest CreateCapacityReservationTargetRequest()
    {
        var capacityReservationTargetRequestResult = new Humidifier.EC2.EC2FleetTypes.CapacityReservationTargetRequest();

        return capacityReservationTargetRequestResult;
    }

} // End Of Class

public static class InnerEC2FleetCapacityReservationTargetRequestFactoryExtensions
{
}
