// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetModelMetricFactory(Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetModelTypes.Metric>
{

    internal InnerAssetModelMetricWindowFactory WindowFactory { get; set; }

    protected override Humidifier.IoTSiteWise.AssetModelTypes.Metric Create()
    {
        var metricResult = CreateMetric();
        factoryAction?.Invoke(metricResult);

        return metricResult;
    }

    private Humidifier.IoTSiteWise.AssetModelTypes.Metric CreateMetric()
    {
        var metricResult = new Humidifier.IoTSiteWise.AssetModelTypes.Metric();

        return metricResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.AssetModelTypes.Metric result)
    {
        base.CreateChildren(result);

        result.Window ??= WindowFactory?.Build();
    }

} // End Of Class

public static class InnerAssetModelMetricFactoryExtensions
{
    public static CombinedResult<InnerAssetModelMetricFactory, InnerAssetModelMetricWindowFactory> WithWindow(this InnerAssetModelMetricFactory parentFactory, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null)
    {
        parentFactory.WindowFactory = new InnerAssetModelMetricWindowFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WindowFactory);
    }

    public static CombinedResult<InnerAssetModelMetricFactory, T1, InnerAssetModelMetricWindowFactory> WithWindow<T1>(this CombinedResult<InnerAssetModelMetricFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelMetricFactory, InnerAssetModelMetricWindowFactory> WithWindow<T1>(this CombinedResult<T1, InnerAssetModelMetricFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAssetModelMetricFactory, T1, T2, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2>(this CombinedResult<InnerAssetModelMetricFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelMetricFactory, T2, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2>(this CombinedResult<T1, InnerAssetModelMetricFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelMetricFactory, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2>(this CombinedResult<T1, T2, InnerAssetModelMetricFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAssetModelMetricFactory, T1, T2, T3, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2, T3>(this CombinedResult<InnerAssetModelMetricFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelMetricFactory, T2, T3, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2, T3>(this CombinedResult<T1, InnerAssetModelMetricFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelMetricFactory, T3, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2, T3>(this CombinedResult<T1, T2, InnerAssetModelMetricFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelMetricFactory, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAssetModelMetricFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAssetModelMetricFactory, T1, T2, T3, T4, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2, T3, T4>(this CombinedResult<InnerAssetModelMetricFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelMetricFactory, T2, T3, T4, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2, T3, T4>(this CombinedResult<T1, InnerAssetModelMetricFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelMetricFactory, T3, T4, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAssetModelMetricFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelMetricFactory, T4, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAssetModelMetricFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAssetModelMetricFactory, InnerAssetModelMetricWindowFactory> WithWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAssetModelMetricFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindow(combinedResult.T5, subFactoryAction));
}
