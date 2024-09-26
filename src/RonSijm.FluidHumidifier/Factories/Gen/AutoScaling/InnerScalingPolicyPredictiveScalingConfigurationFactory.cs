// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerScalingPolicyPredictiveScalingConfigurationFactory(Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingConfiguration>
{

    protected override Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingConfiguration Create()
    {
        var predictiveScalingConfigurationResult = CreatePredictiveScalingConfiguration();
        factoryAction?.Invoke(predictiveScalingConfigurationResult);

        return predictiveScalingConfigurationResult;
    }

    private Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingConfiguration CreatePredictiveScalingConfiguration()
    {
        var predictiveScalingConfigurationResult = new Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingConfiguration();

        return predictiveScalingConfigurationResult;
    }

} // End Of Class

public static class InnerScalingPolicyPredictiveScalingConfigurationFactoryExtensions
{
}
