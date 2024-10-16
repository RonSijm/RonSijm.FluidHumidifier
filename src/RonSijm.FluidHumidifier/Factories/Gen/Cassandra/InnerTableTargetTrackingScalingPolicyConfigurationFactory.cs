// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableTargetTrackingScalingPolicyConfigurationFactory(Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration>
{

    protected override Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration Create()
    {
        var targetTrackingScalingPolicyConfigurationResult = CreateTargetTrackingScalingPolicyConfiguration();
        factoryAction?.Invoke(targetTrackingScalingPolicyConfigurationResult);

        return targetTrackingScalingPolicyConfigurationResult;
    }

    private Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration CreateTargetTrackingScalingPolicyConfiguration()
    {
        var targetTrackingScalingPolicyConfigurationResult = new Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration();

        return targetTrackingScalingPolicyConfigurationResult;
    }

} // End Of Class

public static class InnerTableTargetTrackingScalingPolicyConfigurationFactoryExtensions
{
}
