// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerBatchSegmentJobBatchSegmentJobOutputFactory(Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput>
{

    internal InnerBatchSegmentJobS3DataConfigFactory S3DataDestinationFactory { get; set; }

    protected override Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput Create()
    {
        var batchSegmentJobOutputResult = CreateBatchSegmentJobOutput();
        factoryAction?.Invoke(batchSegmentJobOutputResult);

        return batchSegmentJobOutputResult;
    }

    private Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput CreateBatchSegmentJobOutput()
    {
        var batchSegmentJobOutputResult = new Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput();

        return batchSegmentJobOutputResult;
    }
    public override void CreateChildren(Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput result)
    {
        base.CreateChildren(result);

        result.S3DataDestination ??= S3DataDestinationFactory?.Build();
    }

} // End Of Class

public static class InnerBatchSegmentJobBatchSegmentJobOutputFactoryExtensions
{
    public static CombinedResult<InnerBatchSegmentJobBatchSegmentJobOutputFactory, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination(this InnerBatchSegmentJobBatchSegmentJobOutputFactory parentFactory, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null)
    {
        parentFactory.S3DataDestinationFactory = new InnerBatchSegmentJobS3DataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataDestinationFactory);
    }

    public static CombinedResult<InnerBatchSegmentJobBatchSegmentJobOutputFactory, T1, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1>(this CombinedResult<InnerBatchSegmentJobBatchSegmentJobOutputFactory, T1> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobOutputFactory, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1>(this CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobOutputFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBatchSegmentJobBatchSegmentJobOutputFactory, T1, T2, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2>(this CombinedResult<InnerBatchSegmentJobBatchSegmentJobOutputFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T2, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2>(this CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T2> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobOutputFactory, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2>(this CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobOutputFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBatchSegmentJobBatchSegmentJobOutputFactory, T1, T2, T3, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<InnerBatchSegmentJobBatchSegmentJobOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T2, T3, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T3, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBatchSegmentJobBatchSegmentJobOutputFactory, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBatchSegmentJobBatchSegmentJobOutputFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBatchSegmentJobBatchSegmentJobOutputFactory, T1, T2, T3, T4, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<InnerBatchSegmentJobBatchSegmentJobOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T2, T3, T4, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T3, T4, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T4, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBatchSegmentJobBatchSegmentJobOutputFactory, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBatchSegmentJobBatchSegmentJobOutputFactory, InnerBatchSegmentJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBatchSegmentJobBatchSegmentJobOutputFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T5, subFactoryAction).T2);
}
