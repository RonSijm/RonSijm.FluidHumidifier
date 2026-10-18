// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerAnomalyDetectorAnomalyDetectorConfigurationFactory(Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration>
{

    internal InnerAnomalyDetectorRandomCutForestConfigurationFactory RandomCutForestFactory { get; set; }

    protected override Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration Create()
    {
        var anomalyDetectorConfigurationResult = CreateAnomalyDetectorConfiguration();
        factoryAction?.Invoke(anomalyDetectorConfigurationResult);

        return anomalyDetectorConfigurationResult;
    }

    private Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration CreateAnomalyDetectorConfiguration()
    {
        var anomalyDetectorConfigurationResult = new Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration();

        return anomalyDetectorConfigurationResult;
    }
    public override void CreateChildren(Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration result)
    {
        base.CreateChildren(result);

        result.RandomCutForest ??= RandomCutForestFactory?.Build();
    }

} // End Of Class

public static class InnerAnomalyDetectorAnomalyDetectorConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest(this InnerAnomalyDetectorAnomalyDetectorConfigurationFactory parentFactory, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null)
    {
        parentFactory.RandomCutForestFactory = new InnerAnomalyDetectorRandomCutForestConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RandomCutForestFactory);
    }

    public static CombinedResult<InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T1, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1>(this CombinedResult<InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T1> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRandomCutForest(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1>(this CombinedResult<T1, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRandomCutForest(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T1, T2, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2>(this CombinedResult<InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T2, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2>(this CombinedResult<T1, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T2> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2>(this CombinedResult<T1, T2, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T1, T2, T3, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2, T3>(this CombinedResult<InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T2, T3, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2, T3>(this CombinedResult<T1, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T3, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T1, T2, T3, T4, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2, T3, T4>(this CombinedResult<InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T2, T3, T4, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T3, T4, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T4, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory, InnerAnomalyDetectorRandomCutForestConfigurationFactory> WithRandomCutForest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRandomCutForest(combinedResult.T5, subFactoryAction).T2);
}
