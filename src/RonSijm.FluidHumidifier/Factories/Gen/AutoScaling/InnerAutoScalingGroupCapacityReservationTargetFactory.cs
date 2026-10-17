// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupCapacityReservationTargetFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget Create()
    {
        var capacityReservationTargetResult = CreateCapacityReservationTarget();
        factoryAction?.Invoke(capacityReservationTargetResult);

        return capacityReservationTargetResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget CreateCapacityReservationTarget()
    {
        var capacityReservationTargetResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget();

        return capacityReservationTargetResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupCapacityReservationTargetFactoryExtensions
{
}
