// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class SentimentDetectionJobFactory(string resourceName = null, Action<Humidifier.Comprehend.SentimentDetectionJob> factoryAction = null) : ResourceFactory<Humidifier.Comprehend.SentimentDetectionJob>(resourceName)
{

    internal InnerSentimentDetectionJobInputDataConfigFactory InputDataConfigFactory { get; set; }

    protected override Humidifier.Comprehend.SentimentDetectionJob Create()
    {
        var sentimentDetectionJobResult = CreateSentimentDetectionJob();
        factoryAction?.Invoke(sentimentDetectionJobResult);

        return sentimentDetectionJobResult;
    }

    private Humidifier.Comprehend.SentimentDetectionJob CreateSentimentDetectionJob()
    {
        var sentimentDetectionJobResult = new Humidifier.Comprehend.SentimentDetectionJob
        {
            GivenName = InputResourceName,
        };

        return sentimentDetectionJobResult;
    }
    public override void CreateChildren(Humidifier.Comprehend.SentimentDetectionJob result)
    {
        base.CreateChildren(result);

        result.InputDataConfig ??= InputDataConfigFactory?.Build();
    }

} // End Of Class

public static class SentimentDetectionJobFactoryExtensions
{
    public static CombinedResult<SentimentDetectionJobFactory, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig(this SentimentDetectionJobFactory parentFactory, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null)
    {
        parentFactory.InputDataConfigFactory = new InnerSentimentDetectionJobInputDataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputDataConfigFactory);
    }

    public static CombinedResult<SentimentDetectionJobFactory, T1, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<SentimentDetectionJobFactory, T1> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SentimentDetectionJobFactory, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<T1, SentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SentimentDetectionJobFactory, T1, T2, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<SentimentDetectionJobFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SentimentDetectionJobFactory, T2, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, SentimentDetectionJobFactory, T2> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SentimentDetectionJobFactory, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, T2, SentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SentimentDetectionJobFactory, T1, T2, T3, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<SentimentDetectionJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SentimentDetectionJobFactory, T2, T3, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, SentimentDetectionJobFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SentimentDetectionJobFactory, T3, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, SentimentDetectionJobFactory, T3> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SentimentDetectionJobFactory, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, SentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SentimentDetectionJobFactory, T1, T2, T3, T4, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<SentimentDetectionJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SentimentDetectionJobFactory, T2, T3, T4, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, SentimentDetectionJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SentimentDetectionJobFactory, T3, T4, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, SentimentDetectionJobFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SentimentDetectionJobFactory, T4, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SentimentDetectionJobFactory, T4> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SentimentDetectionJobFactory, InnerSentimentDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SentimentDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T5, subFactoryAction).T2);
}
