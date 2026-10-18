// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScalingPlans;

public class InnerScalingPlanCustomizedLoadMetricSpecificationFactory(Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.CustomizedLoadMetricSpecification> factoryAction = null) : SubResourceFactory<Humidifier.AutoScalingPlans.ScalingPlanTypes.CustomizedLoadMetricSpecification>
{

    protected override Humidifier.AutoScalingPlans.ScalingPlanTypes.CustomizedLoadMetricSpecification Create()
    {
        var customizedLoadMetricSpecificationResult = CreateCustomizedLoadMetricSpecification();
        factoryAction?.Invoke(customizedLoadMetricSpecificationResult);

        return customizedLoadMetricSpecificationResult;
    }

    private Humidifier.AutoScalingPlans.ScalingPlanTypes.CustomizedLoadMetricSpecification CreateCustomizedLoadMetricSpecification()
    {
        var customizedLoadMetricSpecificationResult = new Humidifier.AutoScalingPlans.ScalingPlanTypes.CustomizedLoadMetricSpecification();

        return customizedLoadMetricSpecificationResult;
    }

} // End Of Class

public static class InnerScalingPlanCustomizedLoadMetricSpecificationFactoryExtensions
{
}
