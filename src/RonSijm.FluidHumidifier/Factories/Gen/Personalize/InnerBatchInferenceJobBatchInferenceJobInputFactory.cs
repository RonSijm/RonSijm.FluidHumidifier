// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerBatchInferenceJobBatchInferenceJobInputFactory(Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput>
{

    internal InnerBatchInferenceJobS3DataConfigFactory S3DataSourceFactory { get; set; }

    protected override Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput Create()
    {
        var batchInferenceJobInputResult = CreateBatchInferenceJobInput();
        factoryAction?.Invoke(batchInferenceJobInputResult);

        return batchInferenceJobInputResult;
    }

    private Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput CreateBatchInferenceJobInput()
    {
        var batchInferenceJobInputResult = new Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput();

        return batchInferenceJobInputResult;
    }
    public override void CreateChildren(Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput result)
    {
        base.CreateChildren(result);

        result.S3DataSource ??= S3DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerBatchInferenceJobBatchInferenceJobInputFactoryExtensions
{
    public static CombinedResult<InnerBatchInferenceJobBatchInferenceJobInputFactory, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource(this InnerBatchInferenceJobBatchInferenceJobInputFactory parentFactory, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null)
    {
        parentFactory.S3DataSourceFactory = new InnerBatchInferenceJobS3DataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataSourceFactory);
    }

    public static CombinedResult<InnerBatchInferenceJobBatchInferenceJobInputFactory, T1, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1>(this CombinedResult<InnerBatchInferenceJobBatchInferenceJobInputFactory, T1> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobInputFactory, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1>(this CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobInputFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBatchInferenceJobBatchInferenceJobInputFactory, T1, T2, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2>(this CombinedResult<InnerBatchInferenceJobBatchInferenceJobInputFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobInputFactory, T2, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobInputFactory, T2> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobInputFactory, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobInputFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBatchInferenceJobBatchInferenceJobInputFactory, T1, T2, T3, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<InnerBatchInferenceJobBatchInferenceJobInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobInputFactory, T2, T3, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobInputFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobInputFactory, T3, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobInputFactory, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBatchInferenceJobBatchInferenceJobInputFactory, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBatchInferenceJobBatchInferenceJobInputFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBatchInferenceJobBatchInferenceJobInputFactory, T1, T2, T3, T4, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<InnerBatchInferenceJobBatchInferenceJobInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobInputFactory, T2, T3, T4, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobInputFactory, T3, T4, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobInputFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBatchInferenceJobBatchInferenceJobInputFactory, T4, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBatchInferenceJobBatchInferenceJobInputFactory, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBatchInferenceJobBatchInferenceJobInputFactory, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBatchInferenceJobBatchInferenceJobInputFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T5, subFactoryAction).T2);
}
