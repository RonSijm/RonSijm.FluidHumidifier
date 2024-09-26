// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScalingPlans;

public class InnerScalingPlanPredefinedLoadMetricSpecificationFactory(Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.PredefinedLoadMetricSpecification> factoryAction = null) : SubResourceFactory<Humidifier.AutoScalingPlans.ScalingPlanTypes.PredefinedLoadMetricSpecification>
{

    protected override Humidifier.AutoScalingPlans.ScalingPlanTypes.PredefinedLoadMetricSpecification Create()
    {
        var predefinedLoadMetricSpecificationResult = CreatePredefinedLoadMetricSpecification();
        factoryAction?.Invoke(predefinedLoadMetricSpecificationResult);

        return predefinedLoadMetricSpecificationResult;
    }

    private Humidifier.AutoScalingPlans.ScalingPlanTypes.PredefinedLoadMetricSpecification CreatePredefinedLoadMetricSpecification()
    {
        var predefinedLoadMetricSpecificationResult = new Humidifier.AutoScalingPlans.ScalingPlanTypes.PredefinedLoadMetricSpecification();

        return predefinedLoadMetricSpecificationResult;
    }

} // End Of Class

public static class InnerScalingPlanPredefinedLoadMetricSpecificationFactoryExtensions
{
}
