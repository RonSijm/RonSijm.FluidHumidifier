// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationAutoScaling;

public class InnerScalingPolicyPredefinedMetricSpecificationFactory(Action<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification>
{

    protected override Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification Create()
    {
        var predefinedMetricSpecificationResult = CreatePredefinedMetricSpecification();
        factoryAction?.Invoke(predefinedMetricSpecificationResult);

        return predefinedMetricSpecificationResult;
    }

    private Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification CreatePredefinedMetricSpecification()
    {
        var predefinedMetricSpecificationResult = new Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification();

        return predefinedMetricSpecificationResult;
    }

} // End Of Class

public static class InnerScalingPolicyPredefinedMetricSpecificationFactoryExtensions
{
}
