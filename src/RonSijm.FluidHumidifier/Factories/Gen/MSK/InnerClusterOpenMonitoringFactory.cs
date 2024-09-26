// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterOpenMonitoringFactory(Action<Humidifier.MSK.ClusterTypes.OpenMonitoring> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.OpenMonitoring>
{

    internal InnerClusterPrometheusFactory PrometheusFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.OpenMonitoring Create()
    {
        var openMonitoringResult = CreateOpenMonitoring();
        factoryAction?.Invoke(openMonitoringResult);

        return openMonitoringResult;
    }

    private Humidifier.MSK.ClusterTypes.OpenMonitoring CreateOpenMonitoring()
    {
        var openMonitoringResult = new Humidifier.MSK.ClusterTypes.OpenMonitoring();

        return openMonitoringResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.OpenMonitoring result)
    {
        base.CreateChildren(result);

        result.Prometheus ??= PrometheusFactory?.Build();
    }

} // End Of Class

public static class InnerClusterOpenMonitoringFactoryExtensions
{
    public static CombinedResult<InnerClusterOpenMonitoringFactory, InnerClusterPrometheusFactory> WithPrometheus(this InnerClusterOpenMonitoringFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null)
    {
        parentFactory.PrometheusFactory = new InnerClusterPrometheusFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrometheusFactory);
    }

    public static CombinedResult<InnerClusterOpenMonitoringFactory, T1, InnerClusterPrometheusFactory> WithPrometheus<T1>(this CombinedResult<InnerClusterOpenMonitoringFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrometheus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOpenMonitoringFactory, InnerClusterPrometheusFactory> WithPrometheus<T1>(this CombinedResult<T1, InnerClusterOpenMonitoringFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrometheus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterOpenMonitoringFactory, T1, T2, InnerClusterPrometheusFactory> WithPrometheus<T1, T2>(this CombinedResult<InnerClusterOpenMonitoringFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOpenMonitoringFactory, T2, InnerClusterPrometheusFactory> WithPrometheus<T1, T2>(this CombinedResult<T1, InnerClusterOpenMonitoringFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOpenMonitoringFactory, InnerClusterPrometheusFactory> WithPrometheus<T1, T2>(this CombinedResult<T1, T2, InnerClusterOpenMonitoringFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterOpenMonitoringFactory, T1, T2, T3, InnerClusterPrometheusFactory> WithPrometheus<T1, T2, T3>(this CombinedResult<InnerClusterOpenMonitoringFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOpenMonitoringFactory, T2, T3, InnerClusterPrometheusFactory> WithPrometheus<T1, T2, T3>(this CombinedResult<T1, InnerClusterOpenMonitoringFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOpenMonitoringFactory, T3, InnerClusterPrometheusFactory> WithPrometheus<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterOpenMonitoringFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterOpenMonitoringFactory, InnerClusterPrometheusFactory> WithPrometheus<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterOpenMonitoringFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterOpenMonitoringFactory, T1, T2, T3, T4, InnerClusterPrometheusFactory> WithPrometheus<T1, T2, T3, T4>(this CombinedResult<InnerClusterOpenMonitoringFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOpenMonitoringFactory, T2, T3, T4, InnerClusterPrometheusFactory> WithPrometheus<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterOpenMonitoringFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOpenMonitoringFactory, T3, T4, InnerClusterPrometheusFactory> WithPrometheus<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterOpenMonitoringFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterOpenMonitoringFactory, T4, InnerClusterPrometheusFactory> WithPrometheus<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterOpenMonitoringFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterOpenMonitoringFactory, InnerClusterPrometheusFactory> WithPrometheus<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterOpenMonitoringFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Prometheus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrometheus(combinedResult.T5, subFactoryAction));
}
