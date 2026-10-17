// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class LanguageModelFactory(string resourceName = null, Action<Humidifier.Transcribe.LanguageModel> factoryAction = null) : ResourceFactory<Humidifier.Transcribe.LanguageModel>(resourceName)
{

    internal InnerLanguageModelInputDataConfigFactory InputDataConfigFactory { get; set; }

    protected override Humidifier.Transcribe.LanguageModel Create()
    {
        var languageModelResult = CreateLanguageModel();
        factoryAction?.Invoke(languageModelResult);

        return languageModelResult;
    }

    private Humidifier.Transcribe.LanguageModel CreateLanguageModel()
    {
        var languageModelResult = new Humidifier.Transcribe.LanguageModel
        {
            GivenName = InputResourceName,
        };

        return languageModelResult;
    }
    public override void CreateChildren(Humidifier.Transcribe.LanguageModel result)
    {
        base.CreateChildren(result);

        result.InputDataConfig ??= InputDataConfigFactory?.Build();
    }

} // End Of Class

public static class LanguageModelFactoryExtensions
{
    public static CombinedResult<LanguageModelFactory, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig(this LanguageModelFactory parentFactory, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null)
    {
        parentFactory.InputDataConfigFactory = new InnerLanguageModelInputDataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputDataConfigFactory);
    }

    public static CombinedResult<LanguageModelFactory, T1, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<LanguageModelFactory, T1> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LanguageModelFactory, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<T1, LanguageModelFactory> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LanguageModelFactory, T1, T2, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<LanguageModelFactory, T1, T2> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LanguageModelFactory, T2, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, LanguageModelFactory, T2> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LanguageModelFactory, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, T2, LanguageModelFactory> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LanguageModelFactory, T1, T2, T3, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<LanguageModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LanguageModelFactory, T2, T3, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, LanguageModelFactory, T2, T3> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LanguageModelFactory, T3, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, LanguageModelFactory, T3> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LanguageModelFactory, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, LanguageModelFactory> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LanguageModelFactory, T1, T2, T3, T4, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<LanguageModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LanguageModelFactory, T2, T3, T4, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, LanguageModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LanguageModelFactory, T3, T4, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, LanguageModelFactory, T3, T4> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LanguageModelFactory, T4, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LanguageModelFactory, T4> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LanguageModelFactory, InnerLanguageModelInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LanguageModelFactory> combinedResult, Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T5, subFactoryAction).T2);
}
