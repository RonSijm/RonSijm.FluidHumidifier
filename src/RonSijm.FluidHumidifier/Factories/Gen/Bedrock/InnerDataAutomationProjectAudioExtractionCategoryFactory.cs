// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectAudioExtractionCategoryFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory>
{

    internal InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory TypeConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory Create()
    {
        var audioExtractionCategoryResult = CreateAudioExtractionCategory();
        factoryAction?.Invoke(audioExtractionCategoryResult);

        return audioExtractionCategoryResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory CreateAudioExtractionCategory()
    {
        var audioExtractionCategoryResult = new Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory();

        return audioExtractionCategoryResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory result)
    {
        base.CreateChildren(result);

        result.TypeConfiguration ??= TypeConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataAutomationProjectAudioExtractionCategoryFactoryExtensions
{
    public static CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryFactory, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration(this InnerDataAutomationProjectAudioExtractionCategoryFactory parentFactory, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null)
    {
        parentFactory.TypeConfigurationFactory = new InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TypeConfigurationFactory);
    }

    public static CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryFactory, T1, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1>(this CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryFactory, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1>(this CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryFactory, T1, T2, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2>(this CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryFactory, T2, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2>(this CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryFactory, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryFactory, T1, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2, T3>(this CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryFactory, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryFactory, T3, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryFactory, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryFactory, T1, T2, T3, T4, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataAutomationProjectAudioExtractionCategoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryFactory, T2, T3, T4, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataAutomationProjectAudioExtractionCategoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryFactory, T3, T4, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataAutomationProjectAudioExtractionCategoryFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryFactory, T4, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataAutomationProjectAudioExtractionCategoryFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataAutomationProjectAudioExtractionCategoryFactory, InnerDataAutomationProjectAudioExtractionCategoryTypeConfigurationFactory> WithTypeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataAutomationProjectAudioExtractionCategoryFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTypeConfiguration(combinedResult.T5, subFactoryAction).T2);
}
