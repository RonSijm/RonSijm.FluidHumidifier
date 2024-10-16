// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorRDSSourceConfigFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.RDSSourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.RDSSourceConfig>
{

    internal InnerAnomalyDetectorVpcConfigurationFactory VpcConfigurationFactory { get; set; }

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.RDSSourceConfig Create()
    {
        var rDSSourceConfigResult = CreateRDSSourceConfig();
        factoryAction?.Invoke(rDSSourceConfigResult);

        return rDSSourceConfigResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.RDSSourceConfig CreateRDSSourceConfig()
    {
        var rDSSourceConfigResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.RDSSourceConfig();

        return rDSSourceConfigResult;
    }
    public override void CreateChildren(Humidifier.LookoutMetrics.AnomalyDetectorTypes.RDSSourceConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfiguration ??= VpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerAnomalyDetectorRDSSourceConfigFactoryExtensions
{
    public static CombinedResult<InnerAnomalyDetectorRDSSourceConfigFactory, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration(this InnerAnomalyDetectorRDSSourceConfigFactory parentFactory, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcConfigurationFactory = new InnerAnomalyDetectorVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigurationFactory);
    }

    public static CombinedResult<InnerAnomalyDetectorRDSSourceConfigFactory, T1, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<InnerAnomalyDetectorRDSSourceConfigFactory, T1> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorRDSSourceConfigFactory, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<T1, InnerAnomalyDetectorRDSSourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorRDSSourceConfigFactory, T1, T2, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<InnerAnomalyDetectorRDSSourceConfigFactory, T1, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorRDSSourceConfigFactory, T2, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, InnerAnomalyDetectorRDSSourceConfigFactory, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorRDSSourceConfigFactory, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerAnomalyDetectorRDSSourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorRDSSourceConfigFactory, T1, T2, T3, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<InnerAnomalyDetectorRDSSourceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorRDSSourceConfigFactory, T2, T3, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerAnomalyDetectorRDSSourceConfigFactory, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorRDSSourceConfigFactory, T3, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnomalyDetectorRDSSourceConfigFactory, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorRDSSourceConfigFactory, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorRDSSourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorRDSSourceConfigFactory, T1, T2, T3, T4, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerAnomalyDetectorRDSSourceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorRDSSourceConfigFactory, T2, T3, T4, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnomalyDetectorRDSSourceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorRDSSourceConfigFactory, T3, T4, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnomalyDetectorRDSSourceConfigFactory, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorRDSSourceConfigFactory, T4, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorRDSSourceConfigFactory, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorRDSSourceConfigFactory, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorRDSSourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T5, subFactoryAction));
}
