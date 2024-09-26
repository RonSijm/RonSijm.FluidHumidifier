// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerScalingPolicyPredefinedMetricSpecificationFactory(Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification>
{

    protected override Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification Create()
    {
        var predefinedMetricSpecificationResult = CreatePredefinedMetricSpecification();
        factoryAction?.Invoke(predefinedMetricSpecificationResult);

        return predefinedMetricSpecificationResult;
    }

    private Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification CreatePredefinedMetricSpecification()
    {
        var predefinedMetricSpecificationResult = new Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification();

        return predefinedMetricSpecificationResult;
    }

} // End Of Class

public static class InnerScalingPolicyPredefinedMetricSpecificationFactoryExtensions
{
}
