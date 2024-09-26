// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetS3DestinationConfigurationFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.S3DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.S3DestinationConfiguration>
{

    internal InnerDatasetGlueConfigurationFactory GlueConfigurationFactory { get; set; }

    protected override Humidifier.IoTAnalytics.DatasetTypes.S3DestinationConfiguration Create()
    {
        var s3DestinationConfigurationResult = CreateS3DestinationConfiguration();
        factoryAction?.Invoke(s3DestinationConfigurationResult);

        return s3DestinationConfigurationResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.S3DestinationConfiguration CreateS3DestinationConfiguration()
    {
        var s3DestinationConfigurationResult = new Humidifier.IoTAnalytics.DatasetTypes.S3DestinationConfiguration();

        return s3DestinationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.DatasetTypes.S3DestinationConfiguration result)
    {
        base.CreateChildren(result);

        result.GlueConfiguration ??= GlueConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetS3DestinationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDatasetS3DestinationConfigurationFactory, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration(this InnerDatasetS3DestinationConfigurationFactory parentFactory, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null)
    {
        parentFactory.GlueConfigurationFactory = new InnerDatasetGlueConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GlueConfigurationFactory);
    }

    public static CombinedResult<InnerDatasetS3DestinationConfigurationFactory, T1, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1>(this CombinedResult<InnerDatasetS3DestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetS3DestinationConfigurationFactory, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1>(this CombinedResult<T1, InnerDatasetS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetS3DestinationConfigurationFactory, T1, T2, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2>(this CombinedResult<InnerDatasetS3DestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetS3DestinationConfigurationFactory, T2, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2>(this CombinedResult<T1, InnerDatasetS3DestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetS3DestinationConfigurationFactory, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDatasetS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetS3DestinationConfigurationFactory, T1, T2, T3, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2, T3>(this CombinedResult<InnerDatasetS3DestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetS3DestinationConfigurationFactory, T2, T3, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDatasetS3DestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetS3DestinationConfigurationFactory, T3, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetS3DestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetS3DestinationConfigurationFactory, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetS3DestinationConfigurationFactory, T1, T2, T3, T4, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDatasetS3DestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetS3DestinationConfigurationFactory, T2, T3, T4, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetS3DestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetS3DestinationConfigurationFactory, T3, T4, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetS3DestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetS3DestinationConfigurationFactory, T4, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetS3DestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetS3DestinationConfigurationFactory, InnerDatasetGlueConfigurationFactory> WithGlueConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConfiguration(combinedResult.T5, subFactoryAction));
}
