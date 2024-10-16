// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerScalingPolicyTargetTrackingConfigurationFactory(Action<Humidifier.AutoScaling.ScalingPolicyTypes.TargetTrackingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.ScalingPolicyTypes.TargetTrackingConfiguration>
{

    internal InnerScalingPolicyCustomizedMetricSpecificationFactory CustomizedMetricSpecificationFactory { get; set; }

    internal InnerScalingPolicyPredefinedMetricSpecificationFactory PredefinedMetricSpecificationFactory { get; set; }

    protected override Humidifier.AutoScaling.ScalingPolicyTypes.TargetTrackingConfiguration Create()
    {
        var targetTrackingConfigurationResult = CreateTargetTrackingConfiguration();
        factoryAction?.Invoke(targetTrackingConfigurationResult);

        return targetTrackingConfigurationResult;
    }

    private Humidifier.AutoScaling.ScalingPolicyTypes.TargetTrackingConfiguration CreateTargetTrackingConfiguration()
    {
        var targetTrackingConfigurationResult = new Humidifier.AutoScaling.ScalingPolicyTypes.TargetTrackingConfiguration();

        return targetTrackingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AutoScaling.ScalingPolicyTypes.TargetTrackingConfiguration result)
    {
        base.CreateChildren(result);

        result.CustomizedMetricSpecification ??= CustomizedMetricSpecificationFactory?.Build();
        result.PredefinedMetricSpecification ??= PredefinedMetricSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerScalingPolicyTargetTrackingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification(this InnerScalingPolicyTargetTrackingConfigurationFactory parentFactory, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null)
    {
        parentFactory.CustomizedMetricSpecificationFactory = new InnerScalingPolicyCustomizedMetricSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomizedMetricSpecificationFactory);
    }

    public static CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification(this InnerScalingPolicyTargetTrackingConfigurationFactory parentFactory, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null)
    {
        parentFactory.PredefinedMetricSpecificationFactory = new InnerScalingPolicyPredefinedMetricSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PredefinedMetricSpecificationFactory);
    }

    public static CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1>(this CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1>(this CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2>(this CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2>(this CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2>(this CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2, T3, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2, T3>(this CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2, T3, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2, T3>(this CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory, T3, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory, T3> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScalingPolicyTargetTrackingConfigurationFactory, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScalingPolicyTargetTrackingConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2, T3, T4, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2, T3, T4>(this CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2, T3, T4, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory, T3, T4, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScalingPolicyTargetTrackingConfigurationFactory, T4, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScalingPolicyTargetTrackingConfigurationFactory, T4> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScalingPolicyTargetTrackingConfigurationFactory, InnerScalingPolicyCustomizedMetricSpecificationFactory> WithCustomizedMetricSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScalingPolicyTargetTrackingConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomizedMetricSpecification(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1>(this CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1>(this CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2>(this CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2>(this CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2>(this CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2, T3, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2, T3>(this CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2, T3, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2, T3>(this CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory, T3, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory, T3> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScalingPolicyTargetTrackingConfigurationFactory, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScalingPolicyTargetTrackingConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2, T3, T4, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2, T3, T4>(this CombinedResult<InnerScalingPolicyTargetTrackingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2, T3, T4, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerScalingPolicyTargetTrackingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory, T3, T4, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScalingPolicyTargetTrackingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScalingPolicyTargetTrackingConfigurationFactory, T4, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScalingPolicyTargetTrackingConfigurationFactory, T4> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScalingPolicyTargetTrackingConfigurationFactory, InnerScalingPolicyPredefinedMetricSpecificationFactory> WithPredefinedMetricSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScalingPolicyTargetTrackingConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredefinedMetricSpecification(combinedResult.T5, subFactoryAction));
}
