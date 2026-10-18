// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class ResourceMetricsConfigurationFactory(string resourceName = null, Action<Humidifier.CloudWatch.ResourceMetricsConfiguration> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.ResourceMetricsConfiguration>(resourceName)
{

    internal List<InnerResourceMetricsConfigurationResourceMetricSelectionFactory> MetricSelectionsFactories { get; set; } = [];

    protected override Humidifier.CloudWatch.ResourceMetricsConfiguration Create()
    {
        var resourceMetricsConfigurationResult = CreateResourceMetricsConfiguration();
        factoryAction?.Invoke(resourceMetricsConfigurationResult);

        return resourceMetricsConfigurationResult;
    }

    private Humidifier.CloudWatch.ResourceMetricsConfiguration CreateResourceMetricsConfiguration()
    {
        var resourceMetricsConfigurationResult = new Humidifier.CloudWatch.ResourceMetricsConfiguration
        {
            GivenName = InputResourceName,
        };

        return resourceMetricsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.ResourceMetricsConfiguration result)
    {
        base.CreateChildren(result);

        result.MetricSelections = MetricSelectionsFactories.Any() ? MetricSelectionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ResourceMetricsConfigurationFactoryExtensions
{
    public static CombinedResult<ResourceMetricsConfigurationFactory, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections(this ResourceMetricsConfigurationFactory parentFactory, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null)
    {
        var factory = new InnerResourceMetricsConfigurationResourceMetricSelectionFactory(subFactoryAction);
        parentFactory.MetricSelectionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ResourceMetricsConfigurationFactory, T1, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1>(this CombinedResult<ResourceMetricsConfigurationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricSelections(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceMetricsConfigurationFactory, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1>(this CombinedResult<T1, ResourceMetricsConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricSelections(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ResourceMetricsConfigurationFactory, T1, T2, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2>(this CombinedResult<ResourceMetricsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceMetricsConfigurationFactory, T2, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2>(this CombinedResult<T1, ResourceMetricsConfigurationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ResourceMetricsConfigurationFactory, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2>(this CombinedResult<T1, T2, ResourceMetricsConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ResourceMetricsConfigurationFactory, T1, T2, T3, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2, T3>(this CombinedResult<ResourceMetricsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceMetricsConfigurationFactory, T2, T3, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2, T3>(this CombinedResult<T1, ResourceMetricsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ResourceMetricsConfigurationFactory, T3, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2, T3>(this CombinedResult<T1, T2, ResourceMetricsConfigurationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ResourceMetricsConfigurationFactory, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceMetricsConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ResourceMetricsConfigurationFactory, T1, T2, T3, T4, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2, T3, T4>(this CombinedResult<ResourceMetricsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceMetricsConfigurationFactory, T2, T3, T4, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2, T3, T4>(this CombinedResult<T1, ResourceMetricsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ResourceMetricsConfigurationFactory, T3, T4, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceMetricsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ResourceMetricsConfigurationFactory, T4, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceMetricsConfigurationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ResourceMetricsConfigurationFactory, InnerResourceMetricsConfigurationResourceMetricSelectionFactory> WithMetricSelections<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceMetricsConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSelections(combinedResult.T5, subFactoryAction).T2);
}
