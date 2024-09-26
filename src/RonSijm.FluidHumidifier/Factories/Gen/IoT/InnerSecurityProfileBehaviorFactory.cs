// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerSecurityProfileBehaviorFactory(Action<Humidifier.IoT.SecurityProfileTypes.Behavior> factoryAction = null) : SubResourceFactory<Humidifier.IoT.SecurityProfileTypes.Behavior>
{

    internal InnerSecurityProfileBehaviorCriteriaFactory CriteriaFactory { get; set; }

    internal InnerSecurityProfileMetricDimensionFactory MetricDimensionFactory { get; set; }

    protected override Humidifier.IoT.SecurityProfileTypes.Behavior Create()
    {
        var behaviorResult = CreateBehavior();
        factoryAction?.Invoke(behaviorResult);

        return behaviorResult;
    }

    private Humidifier.IoT.SecurityProfileTypes.Behavior CreateBehavior()
    {
        var behaviorResult = new Humidifier.IoT.SecurityProfileTypes.Behavior();

        return behaviorResult;
    }
    public override void CreateChildren(Humidifier.IoT.SecurityProfileTypes.Behavior result)
    {
        base.CreateChildren(result);

        result.Criteria ??= CriteriaFactory?.Build();
        result.MetricDimension ??= MetricDimensionFactory?.Build();
    }

} // End Of Class

public static class InnerSecurityProfileBehaviorFactoryExtensions
{
    public static CombinedResult<InnerSecurityProfileBehaviorFactory, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria(this InnerSecurityProfileBehaviorFactory parentFactory, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null)
    {
        parentFactory.CriteriaFactory = new InnerSecurityProfileBehaviorCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CriteriaFactory);
    }

    public static CombinedResult<InnerSecurityProfileBehaviorFactory, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension(this InnerSecurityProfileBehaviorFactory parentFactory, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null)
    {
        parentFactory.MetricDimensionFactory = new InnerSecurityProfileMetricDimensionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetricDimensionFactory);
    }

    public static CombinedResult<InnerSecurityProfileBehaviorFactory, T1, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1>(this CombinedResult<InnerSecurityProfileBehaviorFactory, T1> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileBehaviorFactory, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1>(this CombinedResult<T1, InnerSecurityProfileBehaviorFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2>(this CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2>(this CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2>(this CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2, T3, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2, T3, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2, T3> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory, T3, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory, T3> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSecurityProfileBehaviorFactory, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSecurityProfileBehaviorFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2, T3, T4, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2, T3, T4, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory, T3, T4, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory, T3, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSecurityProfileBehaviorFactory, T4, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSecurityProfileBehaviorFactory, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSecurityProfileBehaviorFactory, InnerSecurityProfileBehaviorCriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSecurityProfileBehaviorFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerSecurityProfileBehaviorFactory, T1, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1>(this CombinedResult<InnerSecurityProfileBehaviorFactory, T1> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricDimension(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileBehaviorFactory, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1>(this CombinedResult<T1, InnerSecurityProfileBehaviorFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricDimension(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2>(this CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2>(this CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2>(this CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2, T3, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3>(this CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2, T3, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3>(this CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2, T3> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory, T3, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3>(this CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory, T3> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSecurityProfileBehaviorFactory, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSecurityProfileBehaviorFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2, T3, T4, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3, T4>(this CombinedResult<InnerSecurityProfileBehaviorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2, T3, T4, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3, T4>(this CombinedResult<T1, InnerSecurityProfileBehaviorFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory, T3, T4, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSecurityProfileBehaviorFactory, T3, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSecurityProfileBehaviorFactory, T4, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSecurityProfileBehaviorFactory, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSecurityProfileBehaviorFactory, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSecurityProfileBehaviorFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T5, subFactoryAction));
}
