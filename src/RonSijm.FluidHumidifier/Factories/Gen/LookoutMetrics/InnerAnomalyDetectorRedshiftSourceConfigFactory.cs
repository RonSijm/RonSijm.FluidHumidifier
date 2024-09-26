// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorRedshiftSourceConfigFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.RedshiftSourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.RedshiftSourceConfig>
{

    internal InnerAnomalyDetectorVpcConfigurationFactory VpcConfigurationFactory { get; set; }

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.RedshiftSourceConfig Create()
    {
        var redshiftSourceConfigResult = CreateRedshiftSourceConfig();
        factoryAction?.Invoke(redshiftSourceConfigResult);

        return redshiftSourceConfigResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.RedshiftSourceConfig CreateRedshiftSourceConfig()
    {
        var redshiftSourceConfigResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.RedshiftSourceConfig();

        return redshiftSourceConfigResult;
    }
    public override void CreateChildren(Humidifier.LookoutMetrics.AnomalyDetectorTypes.RedshiftSourceConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfiguration ??= VpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerAnomalyDetectorRedshiftSourceConfigFactoryExtensions
{
    public static CombinedResult<InnerAnomalyDetectorRedshiftSourceConfigFactory, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration(this InnerAnomalyDetectorRedshiftSourceConfigFactory parentFactory, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcConfigurationFactory = new InnerAnomalyDetectorVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigurationFactory);
    }

    public static CombinedResult<InnerAnomalyDetectorRedshiftSourceConfigFactory, T1, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<InnerAnomalyDetectorRedshiftSourceConfigFactory, T1> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorRedshiftSourceConfigFactory, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<T1, InnerAnomalyDetectorRedshiftSourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorRedshiftSourceConfigFactory, T1, T2, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<InnerAnomalyDetectorRedshiftSourceConfigFactory, T1, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorRedshiftSourceConfigFactory, T2, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, InnerAnomalyDetectorRedshiftSourceConfigFactory, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorRedshiftSourceConfigFactory, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerAnomalyDetectorRedshiftSourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorRedshiftSourceConfigFactory, T1, T2, T3, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<InnerAnomalyDetectorRedshiftSourceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorRedshiftSourceConfigFactory, T2, T3, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerAnomalyDetectorRedshiftSourceConfigFactory, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorRedshiftSourceConfigFactory, T3, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnomalyDetectorRedshiftSourceConfigFactory, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorRedshiftSourceConfigFactory, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorRedshiftSourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorRedshiftSourceConfigFactory, T1, T2, T3, T4, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerAnomalyDetectorRedshiftSourceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorRedshiftSourceConfigFactory, T2, T3, T4, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnomalyDetectorRedshiftSourceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorRedshiftSourceConfigFactory, T3, T4, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnomalyDetectorRedshiftSourceConfigFactory, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorRedshiftSourceConfigFactory, T4, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorRedshiftSourceConfigFactory, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorRedshiftSourceConfigFactory, InnerAnomalyDetectorVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorRedshiftSourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T5, subFactoryAction));
}
