// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class DominantLanguageDetectionJobFactory(string resourceName = null, Action<Humidifier.Comprehend.DominantLanguageDetectionJob> factoryAction = null) : ResourceFactory<Humidifier.Comprehend.DominantLanguageDetectionJob>(resourceName)
{

    internal InnerDominantLanguageDetectionJobInputDataConfigFactory InputDataConfigFactory { get; set; }

    protected override Humidifier.Comprehend.DominantLanguageDetectionJob Create()
    {
        var dominantLanguageDetectionJobResult = CreateDominantLanguageDetectionJob();
        factoryAction?.Invoke(dominantLanguageDetectionJobResult);

        return dominantLanguageDetectionJobResult;
    }

    private Humidifier.Comprehend.DominantLanguageDetectionJob CreateDominantLanguageDetectionJob()
    {
        var dominantLanguageDetectionJobResult = new Humidifier.Comprehend.DominantLanguageDetectionJob
        {
            GivenName = InputResourceName,
        };

        return dominantLanguageDetectionJobResult;
    }
    public override void CreateChildren(Humidifier.Comprehend.DominantLanguageDetectionJob result)
    {
        base.CreateChildren(result);

        result.InputDataConfig ??= InputDataConfigFactory?.Build();
    }

} // End Of Class

public static class DominantLanguageDetectionJobFactoryExtensions
{
    public static CombinedResult<DominantLanguageDetectionJobFactory, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig(this DominantLanguageDetectionJobFactory parentFactory, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null)
    {
        parentFactory.InputDataConfigFactory = new InnerDominantLanguageDetectionJobInputDataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputDataConfigFactory);
    }

    public static CombinedResult<DominantLanguageDetectionJobFactory, T1, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<DominantLanguageDetectionJobFactory, T1> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DominantLanguageDetectionJobFactory, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<T1, DominantLanguageDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DominantLanguageDetectionJobFactory, T1, T2, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<DominantLanguageDetectionJobFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DominantLanguageDetectionJobFactory, T2, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, DominantLanguageDetectionJobFactory, T2> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DominantLanguageDetectionJobFactory, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, T2, DominantLanguageDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DominantLanguageDetectionJobFactory, T1, T2, T3, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<DominantLanguageDetectionJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DominantLanguageDetectionJobFactory, T2, T3, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, DominantLanguageDetectionJobFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DominantLanguageDetectionJobFactory, T3, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, DominantLanguageDetectionJobFactory, T3> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DominantLanguageDetectionJobFactory, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, DominantLanguageDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DominantLanguageDetectionJobFactory, T1, T2, T3, T4, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<DominantLanguageDetectionJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DominantLanguageDetectionJobFactory, T2, T3, T4, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, DominantLanguageDetectionJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DominantLanguageDetectionJobFactory, T3, T4, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, DominantLanguageDetectionJobFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DominantLanguageDetectionJobFactory, T4, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DominantLanguageDetectionJobFactory, T4> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DominantLanguageDetectionJobFactory, InnerDominantLanguageDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DominantLanguageDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T5, subFactoryAction).T2);
}
