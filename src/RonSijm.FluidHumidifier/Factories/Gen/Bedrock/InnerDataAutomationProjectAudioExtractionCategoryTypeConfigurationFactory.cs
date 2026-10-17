// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration>
{

    internal InnerDataAutomationProjectTranscriptConfigurationFactory TranscriptFactory { get; set; }

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration Create()
    {
        var audioExtractionCategoryTypeConfigurationResult = CreateAudioExtractionCategoryTypeConfiguration();
        factoryAction?.Invoke(audioExtractionCategoryTypeConfigurationResult);

        return audioExtractionCategoryTypeConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration CreateAudioExtractionCategoryTypeConfiguration()
    {
        var audioExtractionCategoryTypeConfigurationResult = new Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration();

        return audioExtractionCategoryTypeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration result)
    {
        base.CreateChildren(result);

        result.Transcript ??= TranscriptFactory?.Build();
    }

} // End Of Class

public static class InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript(this InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null)
    {
        parentFactory.TranscriptFactory = new InnerDataAutomationProjectTranscriptConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TranscriptFactory);
    }

    public static CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T1, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1>(this CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTranscript(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1>(this CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTranscript(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T1, T2, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2>(this CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T2, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2>(this CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2>(this CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T1, T2, T3, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2, T3>(this CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T2, T3, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2, T3>(this CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T3, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T1, T2, T3, T4, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2, T3, T4>(this CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T2, T3, T4, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T3, T4, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T4, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory, InnerDataAutomationProjectTranscriptConfigurationFactory> WithTranscript<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTranscript(combinedResult.T5, subFactoryAction).T2);
}
