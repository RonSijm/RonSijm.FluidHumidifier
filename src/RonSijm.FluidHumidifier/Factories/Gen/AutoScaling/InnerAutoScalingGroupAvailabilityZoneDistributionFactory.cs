// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupAvailabilityZoneDistributionFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneDistribution> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneDistribution>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneDistribution Create()
    {
        var availabilityZoneDistributionResult = CreateAvailabilityZoneDistribution();
        factoryAction?.Invoke(availabilityZoneDistributionResult);

        return availabilityZoneDistributionResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneDistribution CreateAvailabilityZoneDistribution()
    {
        var availabilityZoneDistributionResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneDistribution();

        return availabilityZoneDistributionResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupAvailabilityZoneDistributionFactoryExtensions
{
}
