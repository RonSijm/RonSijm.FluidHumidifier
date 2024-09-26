// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateCapacityReservationTargetFactory(Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget Create()
    {
        var capacityReservationTargetResult = CreateCapacityReservationTarget();
        factoryAction?.Invoke(capacityReservationTargetResult);

        return capacityReservationTargetResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget CreateCapacityReservationTarget()
    {
        var capacityReservationTargetResult = new Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget();

        return capacityReservationTargetResult;
    }

} // End Of Class

public static class InnerLaunchTemplateCapacityReservationTargetFactoryExtensions
{
}
