// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectLogsConfigFactory(Action<Humidifier.CodeBuild.ProjectTypes.LogsConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.LogsConfig>
{

    internal InnerProjectCloudWatchLogsConfigFactory CloudWatchLogsFactory { get; set; }

    internal InnerProjectS3LogsConfigFactory S3LogsFactory { get; set; }

    protected override Humidifier.CodeBuild.ProjectTypes.LogsConfig Create()
    {
        var logsConfigResult = CreateLogsConfig();
        factoryAction?.Invoke(logsConfigResult);

        return logsConfigResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.LogsConfig CreateLogsConfig()
    {
        var logsConfigResult = new Humidifier.CodeBuild.ProjectTypes.LogsConfig();

        return logsConfigResult;
    }
    public override void CreateChildren(Humidifier.CodeBuild.ProjectTypes.LogsConfig result)
    {
        base.CreateChildren(result);

        result.CloudWatchLogs ??= CloudWatchLogsFactory?.Build();
        result.S3Logs ??= S3LogsFactory?.Build();
    }

} // End Of Class

public static class InnerProjectLogsConfigFactoryExtensions
{
    public static CombinedResult<InnerProjectLogsConfigFactory, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs(this InnerProjectLogsConfigFactory parentFactory, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null)
    {
        parentFactory.CloudWatchLogsFactory = new InnerProjectCloudWatchLogsConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchLogsFactory);
    }

    public static CombinedResult<InnerProjectLogsConfigFactory, InnerProjectS3LogsConfigFactory> WithS3Logs(this InnerProjectLogsConfigFactory parentFactory, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null)
    {
        parentFactory.S3LogsFactory = new InnerProjectS3LogsConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LogsFactory);
    }

    public static CombinedResult<InnerProjectLogsConfigFactory, T1, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1>(this CombinedResult<InnerProjectLogsConfigFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectLogsConfigFactory, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1>(this CombinedResult<T1, InnerProjectLogsConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProjectLogsConfigFactory, T1, T2, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<InnerProjectLogsConfigFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectLogsConfigFactory, T2, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, InnerProjectLogsConfigFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectLogsConfigFactory, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, T2, InnerProjectLogsConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProjectLogsConfigFactory, T1, T2, T3, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<InnerProjectLogsConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectLogsConfigFactory, T2, T3, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, InnerProjectLogsConfigFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectLogsConfigFactory, T3, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectLogsConfigFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectLogsConfigFactory, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectLogsConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProjectLogsConfigFactory, T1, T2, T3, T4, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<InnerProjectLogsConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectLogsConfigFactory, T2, T3, T4, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectLogsConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectLogsConfigFactory, T3, T4, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectLogsConfigFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectLogsConfigFactory, T4, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectLogsConfigFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProjectLogsConfigFactory, InnerProjectCloudWatchLogsConfigFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectLogsConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerProjectLogsConfigFactory, T1, InnerProjectS3LogsConfigFactory> WithS3Logs<T1>(this CombinedResult<InnerProjectLogsConfigFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Logs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectLogsConfigFactory, InnerProjectS3LogsConfigFactory> WithS3Logs<T1>(this CombinedResult<T1, InnerProjectLogsConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Logs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProjectLogsConfigFactory, T1, T2, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2>(this CombinedResult<InnerProjectLogsConfigFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectLogsConfigFactory, T2, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2>(this CombinedResult<T1, InnerProjectLogsConfigFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectLogsConfigFactory, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2>(this CombinedResult<T1, T2, InnerProjectLogsConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProjectLogsConfigFactory, T1, T2, T3, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2, T3>(this CombinedResult<InnerProjectLogsConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectLogsConfigFactory, T2, T3, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2, T3>(this CombinedResult<T1, InnerProjectLogsConfigFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectLogsConfigFactory, T3, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectLogsConfigFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectLogsConfigFactory, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectLogsConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProjectLogsConfigFactory, T1, T2, T3, T4, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2, T3, T4>(this CombinedResult<InnerProjectLogsConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectLogsConfigFactory, T2, T3, T4, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectLogsConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectLogsConfigFactory, T3, T4, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectLogsConfigFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectLogsConfigFactory, T4, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectLogsConfigFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProjectLogsConfigFactory, InnerProjectS3LogsConfigFactory> WithS3Logs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectLogsConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T5, subFactoryAction));
}
