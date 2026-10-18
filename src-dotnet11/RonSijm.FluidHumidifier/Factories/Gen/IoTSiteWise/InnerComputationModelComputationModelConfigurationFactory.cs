// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerComputationModelComputationModelConfigurationFactory(Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration>
{

    internal InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory AnomalyDetectionFactory { get; set; }

    protected override Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration Create()
    {
        var computationModelConfigurationResult = CreateComputationModelConfiguration();
        factoryAction?.Invoke(computationModelConfigurationResult);

        return computationModelConfigurationResult;
    }

    private Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration CreateComputationModelConfiguration()
    {
        var computationModelConfigurationResult = new Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration();

        return computationModelConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration result)
    {
        base.CreateChildren(result);

        result.AnomalyDetection ??= AnomalyDetectionFactory?.Build();
    }

} // End Of Class

public static class InnerComputationModelComputationModelConfigurationFactoryExtensions
{
    public static CombinedResult<InnerComputationModelComputationModelConfigurationFactory, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection(this InnerComputationModelComputationModelConfigurationFactory parentFactory, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null)
    {
        parentFactory.AnomalyDetectionFactory = new InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AnomalyDetectionFactory);
    }

    public static CombinedResult<InnerComputationModelComputationModelConfigurationFactory, T1, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1>(this CombinedResult<InnerComputationModelComputationModelConfigurationFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputationModelComputationModelConfigurationFactory, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1>(this CombinedResult<T1, InnerComputationModelComputationModelConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerComputationModelComputationModelConfigurationFactory, T1, T2, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2>(this CombinedResult<InnerComputationModelComputationModelConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputationModelComputationModelConfigurationFactory, T2, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2>(this CombinedResult<T1, InnerComputationModelComputationModelConfigurationFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputationModelComputationModelConfigurationFactory, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2>(this CombinedResult<T1, T2, InnerComputationModelComputationModelConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerComputationModelComputationModelConfigurationFactory, T1, T2, T3, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2, T3>(this CombinedResult<InnerComputationModelComputationModelConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputationModelComputationModelConfigurationFactory, T2, T3, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2, T3>(this CombinedResult<T1, InnerComputationModelComputationModelConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputationModelComputationModelConfigurationFactory, T3, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2, T3>(this CombinedResult<T1, T2, InnerComputationModelComputationModelConfigurationFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerComputationModelComputationModelConfigurationFactory, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerComputationModelComputationModelConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerComputationModelComputationModelConfigurationFactory, T1, T2, T3, T4, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2, T3, T4>(this CombinedResult<InnerComputationModelComputationModelConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputationModelComputationModelConfigurationFactory, T2, T3, T4, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2, T3, T4>(this CombinedResult<T1, InnerComputationModelComputationModelConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputationModelComputationModelConfigurationFactory, T3, T4, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerComputationModelComputationModelConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerComputationModelComputationModelConfigurationFactory, T4, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerComputationModelComputationModelConfigurationFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerComputationModelComputationModelConfigurationFactory, InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory> WithAnomalyDetection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerComputationModelComputationModelConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetection(combinedResult.T5, subFactoryAction).T2);
}
