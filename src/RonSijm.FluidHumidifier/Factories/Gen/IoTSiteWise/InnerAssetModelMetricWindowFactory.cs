// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetModelMetricWindowFactory(Action<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow>
{

    internal InnerAssetModelTumblingWindowFactory TumblingFactory { get; set; }

    protected override Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow Create()
    {
        var metricWindowResult = CreateMetricWindow();
        factoryAction?.Invoke(metricWindowResult);

        return metricWindowResult;
    }

    private Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow CreateMetricWindow()
    {
        var metricWindowResult = new Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow();

        return metricWindowResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow result)
    {
        base.CreateChildren(result);

        result.Tumbling ??= TumblingFactory?.Build();
    }

} // End Of Class

public static class InnerAssetModelMetricWindowFactoryExtensions
{
    public static CombinedResult<InnerAssetModelMetricWindowFactory, InnerAssetModelTumblingWindowFactory> WithTumbling(this InnerAssetModelMetricWindowFactory parentFactory, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null)
    {
        parentFactory.TumblingFactory = new InnerAssetModelTumblingWindowFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TumblingFactory);
    }

    public static CombinedResult<InnerAssetModelMetricWindowFactory, T1, InnerAssetModelTumblingWindowFactory> WithTumbling<T1>(this CombinedResult<InnerAssetModelMetricWindowFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithTumbling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelMetricWindowFactory, InnerAssetModelTumblingWindowFactory> WithTumbling<T1>(this CombinedResult<T1, InnerAssetModelMetricWindowFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithTumbling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAssetModelMetricWindowFactory, T1, T2, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2>(this CombinedResult<InnerAssetModelMetricWindowFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelMetricWindowFactory, T2, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2>(this CombinedResult<T1, InnerAssetModelMetricWindowFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelMetricWindowFactory, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2>(this CombinedResult<T1, T2, InnerAssetModelMetricWindowFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAssetModelMetricWindowFactory, T1, T2, T3, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2, T3>(this CombinedResult<InnerAssetModelMetricWindowFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelMetricWindowFactory, T2, T3, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2, T3>(this CombinedResult<T1, InnerAssetModelMetricWindowFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelMetricWindowFactory, T3, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2, T3>(this CombinedResult<T1, T2, InnerAssetModelMetricWindowFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelMetricWindowFactory, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAssetModelMetricWindowFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAssetModelMetricWindowFactory, T1, T2, T3, T4, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2, T3, T4>(this CombinedResult<InnerAssetModelMetricWindowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelMetricWindowFactory, T2, T3, T4, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2, T3, T4>(this CombinedResult<T1, InnerAssetModelMetricWindowFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelMetricWindowFactory, T3, T4, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAssetModelMetricWindowFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelMetricWindowFactory, T4, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAssetModelMetricWindowFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAssetModelMetricWindowFactory, InnerAssetModelTumblingWindowFactory> WithTumbling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAssetModelMetricWindowFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTumbling(combinedResult.T5, subFactoryAction));
}
