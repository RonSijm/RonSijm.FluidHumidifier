// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupInstancesDistributionFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.InstancesDistribution> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.InstancesDistribution>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.InstancesDistribution Create()
    {
        var instancesDistributionResult = CreateInstancesDistribution();
        factoryAction?.Invoke(instancesDistributionResult);

        return instancesDistributionResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.InstancesDistribution CreateInstancesDistribution()
    {
        var instancesDistributionResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.InstancesDistribution();

        return instancesDistributionResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupInstancesDistributionFactoryExtensions
{
}
