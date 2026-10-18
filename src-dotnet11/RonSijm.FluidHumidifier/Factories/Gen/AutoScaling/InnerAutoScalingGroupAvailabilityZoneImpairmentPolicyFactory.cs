// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupAvailabilityZoneImpairmentPolicyFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneImpairmentPolicy> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneImpairmentPolicy>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneImpairmentPolicy Create()
    {
        var availabilityZoneImpairmentPolicyResult = CreateAvailabilityZoneImpairmentPolicy();
        factoryAction?.Invoke(availabilityZoneImpairmentPolicyResult);

        return availabilityZoneImpairmentPolicyResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneImpairmentPolicy CreateAvailabilityZoneImpairmentPolicy()
    {
        var availabilityZoneImpairmentPolicyResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneImpairmentPolicy();

        return availabilityZoneImpairmentPolicyResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupAvailabilityZoneImpairmentPolicyFactoryExtensions
{
}
