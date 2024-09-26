// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationAutoScaling;

public class InnerScalingPolicyStepScalingPolicyConfigurationFactory(Action<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.StepScalingPolicyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.StepScalingPolicyConfiguration>
{

    protected override Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.StepScalingPolicyConfiguration Create()
    {
        var stepScalingPolicyConfigurationResult = CreateStepScalingPolicyConfiguration();
        factoryAction?.Invoke(stepScalingPolicyConfigurationResult);

        return stepScalingPolicyConfigurationResult;
    }

    private Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.StepScalingPolicyConfiguration CreateStepScalingPolicyConfiguration()
    {
        var stepScalingPolicyConfigurationResult = new Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.StepScalingPolicyConfiguration();

        return stepScalingPolicyConfigurationResult;
    }

} // End Of Class

public static class InnerScalingPolicyStepScalingPolicyConfigurationFactoryExtensions
{
}
