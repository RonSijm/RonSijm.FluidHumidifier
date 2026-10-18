// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOnlineEvaluationConfigDataSourceConfigFactory(Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.DataSourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.DataSourceConfig>
{

    internal InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory CloudWatchLogsFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.DataSourceConfig Create()
    {
        var dataSourceConfigResult = CreateDataSourceConfig();
        factoryAction?.Invoke(dataSourceConfigResult);

        return dataSourceConfigResult;
    }

    private Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.DataSourceConfig CreateDataSourceConfig()
    {
        var dataSourceConfigResult = new Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.DataSourceConfig();

        return dataSourceConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.DataSourceConfig result)
    {
        base.CreateChildren(result);

        result.CloudWatchLogs ??= CloudWatchLogsFactory?.Build();
    }

} // End Of Class

public static class InnerOnlineEvaluationConfigDataSourceConfigFactoryExtensions
{
    public static CombinedResult<InnerOnlineEvaluationConfigDataSourceConfigFactory, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs(this InnerOnlineEvaluationConfigDataSourceConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null)
    {
        parentFactory.CloudWatchLogsFactory = new InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchLogsFactory);
    }

    public static CombinedResult<InnerOnlineEvaluationConfigDataSourceConfigFactory, T1, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1>(this CombinedResult<InnerOnlineEvaluationConfigDataSourceConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOnlineEvaluationConfigDataSourceConfigFactory, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1>(this CombinedResult<T1, InnerOnlineEvaluationConfigDataSourceConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOnlineEvaluationConfigDataSourceConfigFactory, T1, T2, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<InnerOnlineEvaluationConfigDataSourceConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOnlineEvaluationConfigDataSourceConfigFactory, T2, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, InnerOnlineEvaluationConfigDataSourceConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOnlineEvaluationConfigDataSourceConfigFactory, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, T2, InnerOnlineEvaluationConfigDataSourceConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOnlineEvaluationConfigDataSourceConfigFactory, T1, T2, T3, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<InnerOnlineEvaluationConfigDataSourceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOnlineEvaluationConfigDataSourceConfigFactory, T2, T3, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, InnerOnlineEvaluationConfigDataSourceConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOnlineEvaluationConfigDataSourceConfigFactory, T3, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerOnlineEvaluationConfigDataSourceConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOnlineEvaluationConfigDataSourceConfigFactory, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOnlineEvaluationConfigDataSourceConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOnlineEvaluationConfigDataSourceConfigFactory, T1, T2, T3, T4, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<InnerOnlineEvaluationConfigDataSourceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOnlineEvaluationConfigDataSourceConfigFactory, T2, T3, T4, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerOnlineEvaluationConfigDataSourceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOnlineEvaluationConfigDataSourceConfigFactory, T3, T4, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOnlineEvaluationConfigDataSourceConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOnlineEvaluationConfigDataSourceConfigFactory, T4, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOnlineEvaluationConfigDataSourceConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOnlineEvaluationConfigDataSourceConfigFactory, InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOnlineEvaluationConfigDataSourceConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T5, subFactoryAction).T2);
}
