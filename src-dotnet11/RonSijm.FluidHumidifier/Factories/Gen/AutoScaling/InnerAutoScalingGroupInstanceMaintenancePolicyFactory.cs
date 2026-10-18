// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupInstanceMaintenancePolicyFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceMaintenancePolicy> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceMaintenancePolicy>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceMaintenancePolicy Create()
    {
        var instanceMaintenancePolicyResult = CreateInstanceMaintenancePolicy();
        factoryAction?.Invoke(instanceMaintenancePolicyResult);

        return instanceMaintenancePolicyResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceMaintenancePolicy CreateInstanceMaintenancePolicy()
    {
        var instanceMaintenancePolicyResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceMaintenancePolicy();

        return instanceMaintenancePolicyResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupInstanceMaintenancePolicyFactoryExtensions
{
}
