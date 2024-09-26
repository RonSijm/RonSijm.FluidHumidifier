// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerScalingPolicyCustomizedMetricSpecificationFactory(Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification>
{

    protected override Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification Create()
    {
        var customizedMetricSpecificationResult = CreateCustomizedMetricSpecification();
        factoryAction?.Invoke(customizedMetricSpecificationResult);

        return customizedMetricSpecificationResult;
    }

    private Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification CreateCustomizedMetricSpecification()
    {
        var customizedMetricSpecificationResult = new Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification();

        return customizedMetricSpecificationResult;
    }

} // End Of Class

public static class InnerScalingPolicyCustomizedMetricSpecificationFactoryExtensions
{
}
