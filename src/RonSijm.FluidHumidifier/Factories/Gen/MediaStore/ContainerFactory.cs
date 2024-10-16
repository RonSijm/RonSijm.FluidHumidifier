// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaStore;

public class ContainerFactory(string resourceName = null, Action<Humidifier.MediaStore.Container> factoryAction = null) : ResourceFactory<Humidifier.MediaStore.Container>(resourceName)
{

    internal List<InnerContainerCorsRuleFactory> CorsPolicyFactories { get; set; } = [];

    internal InnerContainerMetricPolicyFactory MetricPolicyFactory { get; set; }

    protected override Humidifier.MediaStore.Container Create()
    {
        var containerResult = CreateContainer();
        factoryAction?.Invoke(containerResult);

        return containerResult;
    }

    private Humidifier.MediaStore.Container CreateContainer()
    {
        var containerResult = new Humidifier.MediaStore.Container
        {
            GivenName = InputResourceName,
        };

        return containerResult;
    }
    public override void CreateChildren(Humidifier.MediaStore.Container result)
    {
        base.CreateChildren(result);

        result.CorsPolicy = CorsPolicyFactories.Any() ? CorsPolicyFactories.Select(x => x.Build()).ToList() : null;
        result.MetricPolicy ??= MetricPolicyFactory?.Build();
    }

} // End Of Class

public static class ContainerFactoryExtensions
{
    public static CombinedResult<ContainerFactory, InnerContainerCorsRuleFactory> WithCorsPolicy(this ContainerFactory parentFactory, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null)
    {
        var factory = new InnerContainerCorsRuleFactory(subFactoryAction);
        parentFactory.CorsPolicyFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ContainerFactory, InnerContainerMetricPolicyFactory> WithMetricPolicy(this ContainerFactory parentFactory, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null)
    {
        parentFactory.MetricPolicyFactory = new InnerContainerMetricPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetricPolicyFactory);
    }

    public static CombinedResult<ContainerFactory, T1, InnerContainerCorsRuleFactory> WithCorsPolicy<T1>(this CombinedResult<ContainerFactory, T1> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithCorsPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, InnerContainerCorsRuleFactory> WithCorsPolicy<T1>(this CombinedResult<T1, ContainerFactory> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithCorsPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2>(this CombinedResult<ContainerFactory, T1, T2> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2>(this CombinedResult<T1, ContainerFactory, T2> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2>(this CombinedResult<T1, T2, ContainerFactory> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, T3, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2, T3>(this CombinedResult<ContainerFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, T3, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2, T3>(this CombinedResult<T1, ContainerFactory, T2, T3> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, T3, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2, T3>(this CombinedResult<T1, T2, ContainerFactory, T3> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerFactory, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContainerFactory> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, T3, T4, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2, T3, T4>(this CombinedResult<ContainerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, T3, T4, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2, T3, T4>(this CombinedResult<T1, ContainerFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, T3, T4, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContainerFactory, T3, T4> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerFactory, T4, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContainerFactory, T4> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ContainerFactory, InnerContainerCorsRuleFactory> WithCorsPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContainerFactory> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.CorsRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCorsPolicy(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1>(this CombinedResult<ContainerFactory, T1> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1>(this CombinedResult<T1, ContainerFactory> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2>(this CombinedResult<ContainerFactory, T1, T2> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2>(this CombinedResult<T1, ContainerFactory, T2> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2>(this CombinedResult<T1, T2, ContainerFactory> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, T3, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2, T3>(this CombinedResult<ContainerFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, T3, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2, T3>(this CombinedResult<T1, ContainerFactory, T2, T3> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, T3, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2, T3>(this CombinedResult<T1, T2, ContainerFactory, T3> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerFactory, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContainerFactory> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, T3, T4, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2, T3, T4>(this CombinedResult<ContainerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, T3, T4, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2, T3, T4>(this CombinedResult<T1, ContainerFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, T3, T4, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContainerFactory, T3, T4> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerFactory, T4, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContainerFactory, T4> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ContainerFactory, InnerContainerMetricPolicyFactory> WithMetricPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContainerFactory> combinedResult, Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricPolicy(combinedResult.T5, subFactoryAction));
}
