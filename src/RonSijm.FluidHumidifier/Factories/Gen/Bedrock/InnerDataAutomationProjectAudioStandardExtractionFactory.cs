// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectAudioStandardExtractionFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardExtraction> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardExtraction>
{

    internal InnerDataAutomationProjectAudioExtractionCategoryFactory CategoryFactory { get; set; }

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardExtraction Create()
    {
        var audioStandardExtractionResult = CreateAudioStandardExtraction();
        factoryAction?.Invoke(audioStandardExtractionResult);

        return audioStandardExtractionResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardExtraction CreateAudioStandardExtraction()
    {
        var audioStandardExtractionResult = new Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardExtraction();

        return audioStandardExtractionResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardExtraction result)
    {
        base.CreateChildren(result);

        result.Category ??= CategoryFactory?.Build();
    }

} // End Of Class

public static class InnerDataAutomationProjectAudioStandardExtractionFactoryExtensions
{
    public static CombinedResult<InnerDataAutomationProjectAudioStandardExtractionFactory, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory(this InnerDataAutomationProjectAudioStandardExtractionFactory parentFactory, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null)
    {
        parentFactory.CategoryFactory = new InnerDataAutomationProjectAudioExtractionCategoryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CategoryFactory);
    }

    public static CombinedResult<InnerDataAutomationProjectAudioStandardExtractionFactory, T1, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1>(this CombinedResult<InnerDataAutomationProjectAudioStandardExtractionFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, WithCategory(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioStandardExtractionFactory, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1>(this CombinedResult<T1, InnerDataAutomationProjectAudioStandardExtractionFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, WithCategory(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectAudioStandardExtractionFactory, T1, T2, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2>(this CombinedResult<InnerDataAutomationProjectAudioStandardExtractionFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioStandardExtractionFactory, T2, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2>(this CombinedResult<T1, InnerDataAutomationProjectAudioStandardExtractionFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectAudioStandardExtractionFactory, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2>(this CombinedResult<T1, T2, InnerDataAutomationProjectAudioStandardExtractionFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectAudioStandardExtractionFactory, T1, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2, T3>(this CombinedResult<InnerDataAutomationProjectAudioStandardExtractionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioStandardExtractionFactory, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2, T3>(this CombinedResult<T1, InnerDataAutomationProjectAudioStandardExtractionFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectAudioStandardExtractionFactory, T3, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataAutomationProjectAudioStandardExtractionFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioStandardExtractionFactory, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioStandardExtractionFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectAudioStandardExtractionFactory, T1, T2, T3, T4, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2, T3, T4>(this CombinedResult<InnerDataAutomationProjectAudioStandardExtractionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioStandardExtractionFactory, T2, T3, T4, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataAutomationProjectAudioStandardExtractionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectAudioStandardExtractionFactory, T3, T4, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataAutomationProjectAudioStandardExtractionFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioStandardExtractionFactory, T4, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioStandardExtractionFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataAutomationProjectAudioStandardExtractionFactory, InnerDataAutomationProjectAudioExtractionCategoryFactory> WithCategory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataAutomationProjectAudioStandardExtractionFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCategory(combinedResult.T5, subFactoryAction).T2);
}
