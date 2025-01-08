// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationAutoScaling;

public class InnerScalingPolicyPredictiveScalingPolicyConfigurationFactory(Action<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingPolicyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingPolicyConfiguration>
{

    protected override Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingPolicyConfiguration Create()
    {
        var predictiveScalingPolicyConfigurationResult = CreatePredictiveScalingPolicyConfiguration();
        factoryAction?.Invoke(predictiveScalingPolicyConfigurationResult);

        return predictiveScalingPolicyConfigurationResult;
    }

    private Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingPolicyConfiguration CreatePredictiveScalingPolicyConfiguration()
    {
        var predictiveScalingPolicyConfigurationResult = new Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingPolicyConfiguration();

        return predictiveScalingPolicyConfigurationResult;
    }

} // End Of Class

public static class InnerScalingPolicyPredictiveScalingPolicyConfigurationFactoryExtensions
{
}
