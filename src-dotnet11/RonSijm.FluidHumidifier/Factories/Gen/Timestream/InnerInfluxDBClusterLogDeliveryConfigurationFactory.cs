// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerInfluxDBClusterLogDeliveryConfigurationFactory(Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration>
{

    internal InnerInfluxDBClusterS3ConfigurationFactory S3ConfigurationFactory { get; set; }

    protected override Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration Create()
    {
        var logDeliveryConfigurationResult = CreateLogDeliveryConfiguration();
        factoryAction?.Invoke(logDeliveryConfigurationResult);

        return logDeliveryConfigurationResult;
    }

    private Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration CreateLogDeliveryConfiguration()
    {
        var logDeliveryConfigurationResult = new Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration();

        return logDeliveryConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration result)
    {
        base.CreateChildren(result);

        result.S3Configuration ??= S3ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerInfluxDBClusterLogDeliveryConfigurationFactoryExtensions
{
    public static CombinedResult<InnerInfluxDBClusterLogDeliveryConfigurationFactory, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration(this InnerInfluxDBClusterLogDeliveryConfigurationFactory parentFactory, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null)
    {
        parentFactory.S3ConfigurationFactory = new InnerInfluxDBClusterS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ConfigurationFactory);
    }

    public static CombinedResult<InnerInfluxDBClusterLogDeliveryConfigurationFactory, T1, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<InnerInfluxDBClusterLogDeliveryConfigurationFactory, T1> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInfluxDBClusterLogDeliveryConfigurationFactory, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<T1, InnerInfluxDBClusterLogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInfluxDBClusterLogDeliveryConfigurationFactory, T1, T2, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<InnerInfluxDBClusterLogDeliveryConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T2, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInfluxDBClusterLogDeliveryConfigurationFactory, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, T2, InnerInfluxDBClusterLogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInfluxDBClusterLogDeliveryConfigurationFactory, T1, T2, T3, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<InnerInfluxDBClusterLogDeliveryConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T2, T3, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T3, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInfluxDBClusterLogDeliveryConfigurationFactory, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInfluxDBClusterLogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInfluxDBClusterLogDeliveryConfigurationFactory, T1, T2, T3, T4, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<InnerInfluxDBClusterLogDeliveryConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T2, T3, T4, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T3, T4, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T4, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInfluxDBClusterLogDeliveryConfigurationFactory, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInfluxDBClusterLogDeliveryConfigurationFactory, InnerInfluxDBClusterS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInfluxDBClusterLogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T5, subFactoryAction).T2);
}
