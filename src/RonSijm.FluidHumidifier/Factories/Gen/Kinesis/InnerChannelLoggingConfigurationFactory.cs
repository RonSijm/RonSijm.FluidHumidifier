// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class InnerChannelLoggingConfigurationFactory(Action<Humidifier.Kinesis.ChannelTypes.LoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kinesis.ChannelTypes.LoggingConfiguration>
{

    internal InnerChannelCloudWatchLogsConfigurationFactory CloudWatchLogsFactory { get; set; }

    protected override Humidifier.Kinesis.ChannelTypes.LoggingConfiguration Create()
    {
        var loggingConfigurationResult = CreateLoggingConfiguration();
        factoryAction?.Invoke(loggingConfigurationResult);

        return loggingConfigurationResult;
    }

    private Humidifier.Kinesis.ChannelTypes.LoggingConfiguration CreateLoggingConfiguration()
    {
        var loggingConfigurationResult = new Humidifier.Kinesis.ChannelTypes.LoggingConfiguration();

        return loggingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Kinesis.ChannelTypes.LoggingConfiguration result)
    {
        base.CreateChildren(result);

        result.CloudWatchLogs ??= CloudWatchLogsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelLoggingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerChannelLoggingConfigurationFactory, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs(this InnerChannelLoggingConfigurationFactory parentFactory, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null)
    {
        parentFactory.CloudWatchLogsFactory = new InnerChannelCloudWatchLogsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchLogsFactory);
    }

    public static CombinedResult<InnerChannelLoggingConfigurationFactory, T1, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1>(this CombinedResult<InnerChannelLoggingConfigurationFactory, T1> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelLoggingConfigurationFactory, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1>(this CombinedResult<T1, InnerChannelLoggingConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelLoggingConfigurationFactory, T1, T2, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<InnerChannelLoggingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelLoggingConfigurationFactory, T2, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, InnerChannelLoggingConfigurationFactory, T2> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelLoggingConfigurationFactory, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, T2, InnerChannelLoggingConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelLoggingConfigurationFactory, T1, T2, T3, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<InnerChannelLoggingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelLoggingConfigurationFactory, T2, T3, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, InnerChannelLoggingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelLoggingConfigurationFactory, T3, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelLoggingConfigurationFactory, T3> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelLoggingConfigurationFactory, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelLoggingConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelLoggingConfigurationFactory, T1, T2, T3, T4, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<InnerChannelLoggingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelLoggingConfigurationFactory, T2, T3, T4, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelLoggingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelLoggingConfigurationFactory, T3, T4, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelLoggingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelLoggingConfigurationFactory, T4, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelLoggingConfigurationFactory, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelLoggingConfigurationFactory, InnerChannelCloudWatchLogsConfigurationFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelLoggingConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T5, subFactoryAction).T2);
}
