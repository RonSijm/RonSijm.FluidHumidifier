// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerBatchSegmentJobBatchSegmentJobInputFactory(Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput>
{

    internal InnerBatchSegmentJobS3DataConfigFactory S3DataSourceFactory { get; set; }

    protected override Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput Create()
    {
        var batchSegmentJobInputResult = CreateBatchSegmentJobInput();
        factoryAction?.Invoke(batchSegmentJobInputResult);

        return batchSegmentJobInputResult;
    }

    private Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput CreateBatchSegmentJobInput()
    {
        var batchSegmentJobInputResult = new Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput();

        return batchSegmentJobInputResult;
    }
    public override void CreateChildren(Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput result)
    {
        base.CreateChildren(result);

        result.S3DataSource ??= S3DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerBatchSegmentJobBatchSegmentJobInputFactoryExtensions
{
    public static CombinedResult<InnerBatchSegmentJobBatchSegmentJobInputFactory, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource(this InnerBatchSegmentJobBatchSegmentJobInputFactory parentFactory, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null)
    {
        parentFactory.S3DataSourceFactory = new InnerBatchSegmentJobS3DataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataSourceFactory);
    }

    public static CombinedResult<InnerBatchSegmentJobBatchSegmentJobInputFactory, T1, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1>(this CombinedResult<InnerBatchSegmentJobBatchSegmentJobInputFactory, T1> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobInputFactory, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1>(this CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobInputFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBatchSegmentJobBatchSegmentJobInputFactory, T1, T2, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2>(this CombinedResult<InnerBatchSegmentJobBatchSegmentJobInputFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobInputFactory, T2, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobInputFactory, T2> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobInputFactory, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobInputFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBatchSegmentJobBatchSegmentJobInputFactory, T1, T2, T3, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<InnerBatchSegmentJobBatchSegmentJobInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobInputFactory, T2, T3, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobInputFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobInputFactory, T3, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobInputFactory, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBatchSegmentJobBatchSegmentJobInputFactory, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBatchSegmentJobBatchSegmentJobInputFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBatchSegmentJobBatchSegmentJobInputFactory, T1, T2, T3, T4, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<InnerBatchSegmentJobBatchSegmentJobInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobInputFactory, T2, T3, T4, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobInputFactory, T3, T4, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobInputFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBatchSegmentJobBatchSegmentJobInputFactory, T4, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBatchSegmentJobBatchSegmentJobInputFactory, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBatchSegmentJobBatchSegmentJobInputFactory, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBatchSegmentJobBatchSegmentJobInputFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T5, subFactoryAction).T2);
}
