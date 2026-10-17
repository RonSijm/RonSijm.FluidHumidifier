// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOnlineEvaluationConfigOutputConfigFactory(Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.OutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.OutputConfig>
{

    internal InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory CloudWatchConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.OutputConfig Create()
    {
        var outputConfigResult = CreateOutputConfig();
        factoryAction?.Invoke(outputConfigResult);

        return outputConfigResult;
    }

    private Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.OutputConfig CreateOutputConfig()
    {
        var outputConfigResult = new Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.OutputConfig();

        return outputConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.OutputConfig result)
    {
        base.CreateChildren(result);

        result.CloudWatchConfig ??= CloudWatchConfigFactory?.Build();
    }

} // End Of Class

public static class InnerOnlineEvaluationConfigOutputConfigFactoryExtensions
{
    public static CombinedResult<InnerOnlineEvaluationConfigOutputConfigFactory, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig(this InnerOnlineEvaluationConfigOutputConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null)
    {
        parentFactory.CloudWatchConfigFactory = new InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchConfigFactory);
    }

    public static CombinedResult<InnerOnlineEvaluationConfigOutputConfigFactory, T1, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1>(this CombinedResult<InnerOnlineEvaluationConfigOutputConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOnlineEvaluationConfigOutputConfigFactory, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1>(this CombinedResult<T1, InnerOnlineEvaluationConfigOutputConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOnlineEvaluationConfigOutputConfigFactory, T1, T2, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2>(this CombinedResult<InnerOnlineEvaluationConfigOutputConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOnlineEvaluationConfigOutputConfigFactory, T2, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2>(this CombinedResult<T1, InnerOnlineEvaluationConfigOutputConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOnlineEvaluationConfigOutputConfigFactory, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2>(this CombinedResult<T1, T2, InnerOnlineEvaluationConfigOutputConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOnlineEvaluationConfigOutputConfigFactory, T1, T2, T3, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2, T3>(this CombinedResult<InnerOnlineEvaluationConfigOutputConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOnlineEvaluationConfigOutputConfigFactory, T2, T3, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2, T3>(this CombinedResult<T1, InnerOnlineEvaluationConfigOutputConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOnlineEvaluationConfigOutputConfigFactory, T3, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerOnlineEvaluationConfigOutputConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOnlineEvaluationConfigOutputConfigFactory, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOnlineEvaluationConfigOutputConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOnlineEvaluationConfigOutputConfigFactory, T1, T2, T3, T4, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2, T3, T4>(this CombinedResult<InnerOnlineEvaluationConfigOutputConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOnlineEvaluationConfigOutputConfigFactory, T2, T3, T4, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerOnlineEvaluationConfigOutputConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOnlineEvaluationConfigOutputConfigFactory, T3, T4, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOnlineEvaluationConfigOutputConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOnlineEvaluationConfigOutputConfigFactory, T4, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOnlineEvaluationConfigOutputConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOnlineEvaluationConfigOutputConfigFactory, InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory> WithCloudWatchConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOnlineEvaluationConfigOutputConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchConfig(combinedResult.T5, subFactoryAction).T2);
}
