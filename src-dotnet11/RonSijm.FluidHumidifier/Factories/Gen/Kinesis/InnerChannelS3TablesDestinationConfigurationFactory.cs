// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class InnerChannelS3TablesDestinationConfigurationFactory(Action<Humidifier.Kinesis.ChannelTypes.S3TablesDestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kinesis.ChannelTypes.S3TablesDestinationConfiguration>
{

    internal InnerChannelDeadLetterQueueS3ConfigurationFactory DeadLetterQueueS3ConfigurationFactory { get; set; }

    protected override Humidifier.Kinesis.ChannelTypes.S3TablesDestinationConfiguration Create()
    {
        var s3TablesDestinationConfigurationResult = CreateS3TablesDestinationConfiguration();
        factoryAction?.Invoke(s3TablesDestinationConfigurationResult);

        return s3TablesDestinationConfigurationResult;
    }

    private Humidifier.Kinesis.ChannelTypes.S3TablesDestinationConfiguration CreateS3TablesDestinationConfiguration()
    {
        var s3TablesDestinationConfigurationResult = new Humidifier.Kinesis.ChannelTypes.S3TablesDestinationConfiguration();

        return s3TablesDestinationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Kinesis.ChannelTypes.S3TablesDestinationConfiguration result)
    {
        base.CreateChildren(result);

        result.DeadLetterQueueS3Configuration ??= DeadLetterQueueS3ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerChannelS3TablesDestinationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerChannelS3TablesDestinationConfigurationFactory, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration(this InnerChannelS3TablesDestinationConfigurationFactory parentFactory, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null)
    {
        parentFactory.DeadLetterQueueS3ConfigurationFactory = new InnerChannelDeadLetterQueueS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeadLetterQueueS3ConfigurationFactory);
    }

    public static CombinedResult<InnerChannelS3TablesDestinationConfigurationFactory, T1, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1>(this CombinedResult<InnerChannelS3TablesDestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3TablesDestinationConfigurationFactory, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1>(this CombinedResult<T1, InnerChannelS3TablesDestinationConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelS3TablesDestinationConfigurationFactory, T1, T2, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2>(this CombinedResult<InnerChannelS3TablesDestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3TablesDestinationConfigurationFactory, T2, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2>(this CombinedResult<T1, InnerChannelS3TablesDestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelS3TablesDestinationConfigurationFactory, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2>(this CombinedResult<T1, T2, InnerChannelS3TablesDestinationConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelS3TablesDestinationConfigurationFactory, T1, T2, T3, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2, T3>(this CombinedResult<InnerChannelS3TablesDestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3TablesDestinationConfigurationFactory, T2, T3, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2, T3>(this CombinedResult<T1, InnerChannelS3TablesDestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelS3TablesDestinationConfigurationFactory, T3, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelS3TablesDestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelS3TablesDestinationConfigurationFactory, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelS3TablesDestinationConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelS3TablesDestinationConfigurationFactory, T1, T2, T3, T4, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2, T3, T4>(this CombinedResult<InnerChannelS3TablesDestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3TablesDestinationConfigurationFactory, T2, T3, T4, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelS3TablesDestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelS3TablesDestinationConfigurationFactory, T3, T4, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelS3TablesDestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelS3TablesDestinationConfigurationFactory, T4, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelS3TablesDestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelS3TablesDestinationConfigurationFactory, InnerChannelDeadLetterQueueS3ConfigurationFactory> WithDeadLetterQueueS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelS3TablesDestinationConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3Configuration(combinedResult.T5, subFactoryAction).T2);
}
