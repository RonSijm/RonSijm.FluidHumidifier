// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerBatchInferenceJobBatchInferenceJobOutputFactory(Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput>
{

    internal InnerBatchInferenceJobS3DataConfigFactory S3DataDestinationFactory { get; set; }

    protected override Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput Create()
    {
        var batchInferenceJobOutputResult = CreateBatchInferenceJobOutput();
        factoryAction?.Invoke(batchInferenceJobOutputResult);

        return batchInferenceJobOutputResult;
    }

    private Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput CreateBatchInferenceJobOutput()
    {
        var batchInferenceJobOutputResult = new Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput();

        return batchInferenceJobOutputResult;
    }
    public override void CreateChildren(Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput result)
    {
        base.CreateChildren(result);

        result.S3DataDestination ??= S3DataDestinationFactory?.Build();
    }

} // End Of Class

public static class InnerBatchInferenceJobBatchInferenceJobOutputFactoryExtensions
{
    public static CombinedResult<InnerBatchInferenceJobBatchInferenceJobOutputFactory, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination(this InnerBatchInferenceJobBatchInferenceJobOutputFactory parentFactory, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null)
    {
        parentFactory.S3DataDestinationFactory = new InnerBatchInferenceJobS3DataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataDestinationFactory);
    }

    public static CombinedResult<InnerBatchInferenceJobBatchInferenceJobOutputFactory, T1, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1>(this CombinedResult<InnerBatchInferenceJobBatchInferenceJobOutputFactory, T1> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobOutputFactory, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1>(this CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobOutputFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBatchInferenceJobBatchInferenceJobOutputFactory, T1, T2, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2>(this CombinedResult<InnerBatchInferenceJobBatchInferenceJobOutputFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T2, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2>(this CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T2> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobOutputFactory, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2>(this CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobOutputFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBatchInferenceJobBatchInferenceJobOutputFactory, T1, T2, T3, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<InnerBatchInferenceJobBatchInferenceJobOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T2, T3, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T3, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBatchInferenceJobBatchInferenceJobOutputFactory, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBatchInferenceJobBatchInferenceJobOutputFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBatchInferenceJobBatchInferenceJobOutputFactory, T1, T2, T3, T4, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<InnerBatchInferenceJobBatchInferenceJobOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T2, T3, T4, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T3, T4, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T4, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBatchInferenceJobBatchInferenceJobOutputFactory, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBatchInferenceJobBatchInferenceJobOutputFactory, InnerBatchInferenceJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBatchInferenceJobBatchInferenceJobOutputFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T5, subFactoryAction).T2);
}
