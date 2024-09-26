// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerInfluxDBInstanceLogDeliveryConfigurationFactory(Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration>
{

    internal InnerInfluxDBInstanceS3ConfigurationFactory S3ConfigurationFactory { get; set; }

    protected override Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration Create()
    {
        var logDeliveryConfigurationResult = CreateLogDeliveryConfiguration();
        factoryAction?.Invoke(logDeliveryConfigurationResult);

        return logDeliveryConfigurationResult;
    }

    private Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration CreateLogDeliveryConfiguration()
    {
        var logDeliveryConfigurationResult = new Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration();

        return logDeliveryConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration result)
    {
        base.CreateChildren(result);

        result.S3Configuration ??= S3ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerInfluxDBInstanceLogDeliveryConfigurationFactoryExtensions
{
    public static CombinedResult<InnerInfluxDBInstanceLogDeliveryConfigurationFactory, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration(this InnerInfluxDBInstanceLogDeliveryConfigurationFactory parentFactory, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null)
    {
        parentFactory.S3ConfigurationFactory = new InnerInfluxDBInstanceS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ConfigurationFactory);
    }

    public static CombinedResult<InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T1, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T1> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<T1, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T1, T2, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T2, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, T2, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T1, T2, T3, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T2, T3, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T3, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T1, T2, T3, T4, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T2, T3, T4, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T3, T4, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T4, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInfluxDBInstanceLogDeliveryConfigurationFactory, InnerInfluxDBInstanceS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T5, subFactoryAction));
}
