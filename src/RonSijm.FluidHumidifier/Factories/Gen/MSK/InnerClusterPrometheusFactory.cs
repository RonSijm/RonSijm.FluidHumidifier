// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterPrometheusFactory(Action<Humidifier.MSK.ClusterTypes.Prometheus> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.Prometheus>
{

    internal InnerClusterJmxExporterFactory JmxExporterFactory { get; set; }

    internal InnerClusterNodeExporterFactory NodeExporterFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.Prometheus Create()
    {
        var prometheusResult = CreatePrometheus();
        factoryAction?.Invoke(prometheusResult);

        return prometheusResult;
    }

    private Humidifier.MSK.ClusterTypes.Prometheus CreatePrometheus()
    {
        var prometheusResult = new Humidifier.MSK.ClusterTypes.Prometheus();

        return prometheusResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.Prometheus result)
    {
        base.CreateChildren(result);

        result.JmxExporter ??= JmxExporterFactory?.Build();
        result.NodeExporter ??= NodeExporterFactory?.Build();
    }

} // End Of Class

public static class InnerClusterPrometheusFactoryExtensions
{
    public static CombinedResult<InnerClusterPrometheusFactory, InnerClusterJmxExporterFactory> WithJmxExporter(this InnerClusterPrometheusFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null)
    {
        parentFactory.JmxExporterFactory = new InnerClusterJmxExporterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JmxExporterFactory);
    }

    public static CombinedResult<InnerClusterPrometheusFactory, InnerClusterNodeExporterFactory> WithNodeExporter(this InnerClusterPrometheusFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null)
    {
        parentFactory.NodeExporterFactory = new InnerClusterNodeExporterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NodeExporterFactory);
    }

    public static CombinedResult<InnerClusterPrometheusFactory, T1, InnerClusterJmxExporterFactory> WithJmxExporter<T1>(this CombinedResult<InnerClusterPrometheusFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, WithJmxExporter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterPrometheusFactory, InnerClusterJmxExporterFactory> WithJmxExporter<T1>(this CombinedResult<T1, InnerClusterPrometheusFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, WithJmxExporter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterPrometheusFactory, T1, T2, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2>(this CombinedResult<InnerClusterPrometheusFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterPrometheusFactory, T2, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2>(this CombinedResult<T1, InnerClusterPrometheusFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterPrometheusFactory, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2>(this CombinedResult<T1, T2, InnerClusterPrometheusFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterPrometheusFactory, T1, T2, T3, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2, T3>(this CombinedResult<InnerClusterPrometheusFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterPrometheusFactory, T2, T3, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2, T3>(this CombinedResult<T1, InnerClusterPrometheusFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterPrometheusFactory, T3, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterPrometheusFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterPrometheusFactory, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterPrometheusFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterPrometheusFactory, T1, T2, T3, T4, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2, T3, T4>(this CombinedResult<InnerClusterPrometheusFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterPrometheusFactory, T2, T3, T4, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterPrometheusFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterPrometheusFactory, T3, T4, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterPrometheusFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterPrometheusFactory, T4, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterPrometheusFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterPrometheusFactory, InnerClusterJmxExporterFactory> WithJmxExporter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterPrometheusFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.JmxExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJmxExporter(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterPrometheusFactory, T1, InnerClusterNodeExporterFactory> WithNodeExporter<T1>(this CombinedResult<InnerClusterPrometheusFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeExporter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterPrometheusFactory, InnerClusterNodeExporterFactory> WithNodeExporter<T1>(this CombinedResult<T1, InnerClusterPrometheusFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeExporter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterPrometheusFactory, T1, T2, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2>(this CombinedResult<InnerClusterPrometheusFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterPrometheusFactory, T2, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2>(this CombinedResult<T1, InnerClusterPrometheusFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterPrometheusFactory, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2>(this CombinedResult<T1, T2, InnerClusterPrometheusFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterPrometheusFactory, T1, T2, T3, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2, T3>(this CombinedResult<InnerClusterPrometheusFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterPrometheusFactory, T2, T3, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2, T3>(this CombinedResult<T1, InnerClusterPrometheusFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterPrometheusFactory, T3, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterPrometheusFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterPrometheusFactory, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterPrometheusFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterPrometheusFactory, T1, T2, T3, T4, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2, T3, T4>(this CombinedResult<InnerClusterPrometheusFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterPrometheusFactory, T2, T3, T4, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterPrometheusFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterPrometheusFactory, T3, T4, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterPrometheusFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterPrometheusFactory, T4, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterPrometheusFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterPrometheusFactory, InnerClusterNodeExporterFactory> WithNodeExporter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterPrometheusFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.NodeExporter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeExporter(combinedResult.T5, subFactoryAction));
}
