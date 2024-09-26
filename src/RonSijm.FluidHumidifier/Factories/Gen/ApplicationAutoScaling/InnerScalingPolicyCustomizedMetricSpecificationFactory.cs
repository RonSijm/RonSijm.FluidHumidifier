// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationAutoScaling;

public class InnerScalingPolicyCustomizedMetricSpecificationFactory(Action<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification>
{

    protected override Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification Create()
    {
        var customizedMetricSpecificationResult = CreateCustomizedMetricSpecification();
        factoryAction?.Invoke(customizedMetricSpecificationResult);

        return customizedMetricSpecificationResult;
    }

    private Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification CreateCustomizedMetricSpecification()
    {
        var customizedMetricSpecificationResult = new Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification();

        return customizedMetricSpecificationResult;
    }

} // End Of Class

public static class InnerScalingPolicyCustomizedMetricSpecificationFactoryExtensions
{
}
