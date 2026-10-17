// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class AnomalyDetectorFactory(string resourceName = null, Action<Humidifier.APS.AnomalyDetector> factoryAction = null) : ResourceFactory<Humidifier.APS.AnomalyDetector>(resourceName)
{

    internal List<InnerAnomalyDetectorLabelFactory> LabelsFactories { get; set; } = [];

    internal InnerAnomalyDetectorAnomalyDetectorConfigurationFactory ConfigurationFactory { get; set; }

    internal InnerAnomalyDetectorMissingDataActionFactory MissingDataActionFactory { get; set; }

    protected override Humidifier.APS.AnomalyDetector Create()
    {
        var anomalyDetectorResult = CreateAnomalyDetector();
        factoryAction?.Invoke(anomalyDetectorResult);

        return anomalyDetectorResult;
    }

    private Humidifier.APS.AnomalyDetector CreateAnomalyDetector()
    {
        var anomalyDetectorResult = new Humidifier.APS.AnomalyDetector
        {
            GivenName = InputResourceName,
        };

        return anomalyDetectorResult;
    }
    public override void CreateChildren(Humidifier.APS.AnomalyDetector result)
    {
        base.CreateChildren(result);

        result.Labels = LabelsFactories.Any() ? LabelsFactories.Select(x => x.Build()).ToList() : null;
        result.Configuration ??= ConfigurationFactory?.Build();
        result.MissingDataAction ??= MissingDataActionFactory?.Build();
    }

} // End Of Class

public static class AnomalyDetectorFactoryExtensions
{
    public static CombinedResult<AnomalyDetectorFactory, InnerAnomalyDetectorLabelFactory> WithLabels(this AnomalyDetectorFactory parentFactory, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null)
    {
        var factory = new InnerAnomalyDetectorLabelFactory(subFactoryAction);
        parentFactory.LabelsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AnomalyDetectorFactory, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration(this AnomalyDetectorFactory parentFactory, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerAnomalyDetectorAnomalyDetectorConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<AnomalyDetectorFactory, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction(this AnomalyDetectorFactory parentFactory, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null)
    {
        parentFactory.MissingDataActionFactory = new InnerAnomalyDetectorMissingDataActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MissingDataActionFactory);
    }

    public static CombinedResult<AnomalyDetectorFactory, T1, InnerAnomalyDetectorLabelFactory> WithLabels<T1>(this CombinedResult<AnomalyDetectorFactory, T1> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, WithLabels(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, InnerAnomalyDetectorLabelFactory> WithLabels<T1>(this CombinedResult<T1, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, WithLabels(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2>(this CombinedResult<AnomalyDetectorFactory, T1, T2> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2>(this CombinedResult<T1, AnomalyDetectorFactory, T2> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2>(this CombinedResult<T1, T2, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, T3, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2, T3>(this CombinedResult<AnomalyDetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, T3, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2, T3>(this CombinedResult<T1, AnomalyDetectorFactory, T2, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, T3, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2, T3>(this CombinedResult<T1, T2, AnomalyDetectorFactory, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AnomalyDetectorFactory, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, T3, T4, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2, T3, T4>(this CombinedResult<AnomalyDetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, T3, T4, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2, T3, T4>(this CombinedResult<T1, AnomalyDetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, T3, T4, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnomalyDetectorFactory, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AnomalyDetectorFactory, T4, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnomalyDetectorFactory, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AnomalyDetectorFactory, InnerAnomalyDetectorLabelFactory> WithLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1>(this CombinedResult<AnomalyDetectorFactory, T1> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<AnomalyDetectorFactory, T1, T2> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, AnomalyDetectorFactory, T2> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, T3, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<AnomalyDetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, T3, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, AnomalyDetectorFactory, T2, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, T3, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AnomalyDetectorFactory, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AnomalyDetectorFactory, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, T3, T4, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<AnomalyDetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, T3, T4, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AnomalyDetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, T3, T4, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnomalyDetectorFactory, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AnomalyDetectorFactory, T4, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnomalyDetectorFactory, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AnomalyDetectorFactory, InnerAnomalyDetectorAnomalyDetectorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1>(this CombinedResult<AnomalyDetectorFactory, T1> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithMissingDataAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1>(this CombinedResult<T1, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithMissingDataAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2>(this CombinedResult<AnomalyDetectorFactory, T1, T2> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2>(this CombinedResult<T1, AnomalyDetectorFactory, T2> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2>(this CombinedResult<T1, T2, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, T3, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2, T3>(this CombinedResult<AnomalyDetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, T3, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2, T3>(this CombinedResult<T1, AnomalyDetectorFactory, T2, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, T3, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2, T3>(this CombinedResult<T1, T2, AnomalyDetectorFactory, T3> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AnomalyDetectorFactory, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, T3, T4, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2, T3, T4>(this CombinedResult<AnomalyDetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, T3, T4, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2, T3, T4>(this CombinedResult<T1, AnomalyDetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, T3, T4, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnomalyDetectorFactory, T3, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AnomalyDetectorFactory, T4, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnomalyDetectorFactory, T4> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AnomalyDetectorFactory, InnerAnomalyDetectorMissingDataActionFactory> WithMissingDataAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnomalyDetectorFactory> combinedResult, Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMissingDataAction(combinedResult.T5, subFactoryAction).T2);
}
