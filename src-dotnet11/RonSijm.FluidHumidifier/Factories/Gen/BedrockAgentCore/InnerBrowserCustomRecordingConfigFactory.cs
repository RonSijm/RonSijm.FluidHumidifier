// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerBrowserCustomRecordingConfigFactory(Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.RecordingConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.BrowserCustomTypes.RecordingConfig>
{

    internal InnerBrowserCustomS3LocationFactory S3LocationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.BrowserCustomTypes.RecordingConfig Create()
    {
        var recordingConfigResult = CreateRecordingConfig();
        factoryAction?.Invoke(recordingConfigResult);

        return recordingConfigResult;
    }

    private Humidifier.BedrockAgentCore.BrowserCustomTypes.RecordingConfig CreateRecordingConfig()
    {
        var recordingConfigResult = new Humidifier.BedrockAgentCore.BrowserCustomTypes.RecordingConfig();

        return recordingConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.BrowserCustomTypes.RecordingConfig result)
    {
        base.CreateChildren(result);

        result.S3Location ??= S3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerBrowserCustomRecordingConfigFactoryExtensions
{
    public static CombinedResult<InnerBrowserCustomRecordingConfigFactory, InnerBrowserCustomS3LocationFactory> WithS3Location(this InnerBrowserCustomRecordingConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.S3LocationFactory = new InnerBrowserCustomS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LocationFactory);
    }

    public static CombinedResult<InnerBrowserCustomRecordingConfigFactory, T1, InnerBrowserCustomS3LocationFactory> WithS3Location<T1>(this CombinedResult<InnerBrowserCustomRecordingConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomRecordingConfigFactory, InnerBrowserCustomS3LocationFactory> WithS3Location<T1>(this CombinedResult<T1, InnerBrowserCustomRecordingConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomRecordingConfigFactory, T1, T2, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<InnerBrowserCustomRecordingConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomRecordingConfigFactory, T2, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, InnerBrowserCustomRecordingConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomRecordingConfigFactory, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, T2, InnerBrowserCustomRecordingConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomRecordingConfigFactory, T1, T2, T3, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<InnerBrowserCustomRecordingConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomRecordingConfigFactory, T2, T3, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, InnerBrowserCustomRecordingConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomRecordingConfigFactory, T3, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerBrowserCustomRecordingConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrowserCustomRecordingConfigFactory, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBrowserCustomRecordingConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomRecordingConfigFactory, T1, T2, T3, T4, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<InnerBrowserCustomRecordingConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomRecordingConfigFactory, T2, T3, T4, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerBrowserCustomRecordingConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomRecordingConfigFactory, T3, T4, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBrowserCustomRecordingConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrowserCustomRecordingConfigFactory, T4, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBrowserCustomRecordingConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBrowserCustomRecordingConfigFactory, InnerBrowserCustomS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBrowserCustomRecordingConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T5, subFactoryAction).T2);
}
