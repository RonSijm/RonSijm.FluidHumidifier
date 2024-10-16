// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration Create()
    {
        var targetTrackingScalingPolicyConfigurationResult = CreateTargetTrackingScalingPolicyConfiguration();
        factoryAction?.Invoke(targetTrackingScalingPolicyConfigurationResult);

        return targetTrackingScalingPolicyConfigurationResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration CreateTargetTrackingScalingPolicyConfiguration()
    {
        var targetTrackingScalingPolicyConfigurationResult = new Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration();

        return targetTrackingScalingPolicyConfigurationResult;
    }

} // End Of Class

public static class InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactoryExtensions
{
}
