// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class BatchSegmentJobFactory(string resourceName = null, Action<Humidifier.Personalize.BatchSegmentJob> factoryAction = null) : ResourceFactory<Humidifier.Personalize.BatchSegmentJob>(resourceName)
{

    internal InnerBatchSegmentJobBatchSegmentJobInputFactory JobInputFactory { get; set; }

    internal InnerBatchSegmentJobBatchSegmentJobOutputFactory JobOutputFactory { get; set; }

    protected override Humidifier.Personalize.BatchSegmentJob Create()
    {
        var batchSegmentJobResult = CreateBatchSegmentJob();
        factoryAction?.Invoke(batchSegmentJobResult);

        return batchSegmentJobResult;
    }

    private Humidifier.Personalize.BatchSegmentJob CreateBatchSegmentJob()
    {
        var batchSegmentJobResult = new Humidifier.Personalize.BatchSegmentJob
        {
            GivenName = InputResourceName,
        };

        return batchSegmentJobResult;
    }
    public override void CreateChildren(Humidifier.Personalize.BatchSegmentJob result)
    {
        base.CreateChildren(result);

        result.JobInput ??= JobInputFactory?.Build();
        result.JobOutput ??= JobOutputFactory?.Build();
    }

} // End Of Class

public static class BatchSegmentJobFactoryExtensions
{
    public static CombinedResult<BatchSegmentJobFactory, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput(this BatchSegmentJobFactory parentFactory, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null)
    {
        parentFactory.JobInputFactory = new InnerBatchSegmentJobBatchSegmentJobInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobInputFactory);
    }

    public static CombinedResult<BatchSegmentJobFactory, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput(this BatchSegmentJobFactory parentFactory, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null)
    {
        parentFactory.JobOutputFactory = new InnerBatchSegmentJobBatchSegmentJobOutputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobOutputFactory);
    }

    public static CombinedResult<BatchSegmentJobFactory, T1, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1>(this CombinedResult<BatchSegmentJobFactory, T1> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchSegmentJobFactory, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1>(this CombinedResult<T1, BatchSegmentJobFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<BatchSegmentJobFactory, T1, T2, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2>(this CombinedResult<BatchSegmentJobFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchSegmentJobFactory, T2, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2>(this CombinedResult<T1, BatchSegmentJobFactory, T2> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchSegmentJobFactory, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2>(this CombinedResult<T1, T2, BatchSegmentJobFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<BatchSegmentJobFactory, T1, T2, T3, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2, T3>(this CombinedResult<BatchSegmentJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchSegmentJobFactory, T2, T3, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2, T3>(this CombinedResult<T1, BatchSegmentJobFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchSegmentJobFactory, T3, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2, T3>(this CombinedResult<T1, T2, BatchSegmentJobFactory, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BatchSegmentJobFactory, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, BatchSegmentJobFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<BatchSegmentJobFactory, T1, T2, T3, T4, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2, T3, T4>(this CombinedResult<BatchSegmentJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchSegmentJobFactory, T2, T3, T4, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2, T3, T4>(this CombinedResult<T1, BatchSegmentJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchSegmentJobFactory, T3, T4, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, BatchSegmentJobFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BatchSegmentJobFactory, T4, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BatchSegmentJobFactory, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, BatchSegmentJobFactory, InnerBatchSegmentJobBatchSegmentJobInputFactory> WithJobInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BatchSegmentJobFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<BatchSegmentJobFactory, T1, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1>(this CombinedResult<BatchSegmentJobFactory, T1> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchSegmentJobFactory, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1>(this CombinedResult<T1, BatchSegmentJobFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<BatchSegmentJobFactory, T1, T2, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2>(this CombinedResult<BatchSegmentJobFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchSegmentJobFactory, T2, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2>(this CombinedResult<T1, BatchSegmentJobFactory, T2> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchSegmentJobFactory, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2>(this CombinedResult<T1, T2, BatchSegmentJobFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<BatchSegmentJobFactory, T1, T2, T3, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<BatchSegmentJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchSegmentJobFactory, T2, T3, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<T1, BatchSegmentJobFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchSegmentJobFactory, T3, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<T1, T2, BatchSegmentJobFactory, T3> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BatchSegmentJobFactory, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<T1, T2, T3, BatchSegmentJobFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<BatchSegmentJobFactory, T1, T2, T3, T4, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<BatchSegmentJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchSegmentJobFactory, T2, T3, T4, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, BatchSegmentJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchSegmentJobFactory, T3, T4, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, BatchSegmentJobFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BatchSegmentJobFactory, T4, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BatchSegmentJobFactory, T4> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, BatchSegmentJobFactory, InnerBatchSegmentJobBatchSegmentJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BatchSegmentJobFactory> combinedResult, Action<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T5, subFactoryAction).T2);
}
