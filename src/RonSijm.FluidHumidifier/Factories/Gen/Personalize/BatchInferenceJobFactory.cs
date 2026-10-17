// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class BatchInferenceJobFactory(string resourceName = null, Action<Humidifier.Personalize.BatchInferenceJob> factoryAction = null) : ResourceFactory<Humidifier.Personalize.BatchInferenceJob>(resourceName)
{

    internal InnerBatchInferenceJobBatchInferenceJobInputFactory JobInputFactory { get; set; }

    internal InnerBatchInferenceJobBatchInferenceJobOutputFactory JobOutputFactory { get; set; }

    protected override Humidifier.Personalize.BatchInferenceJob Create()
    {
        var batchInferenceJobResult = CreateBatchInferenceJob();
        factoryAction?.Invoke(batchInferenceJobResult);

        return batchInferenceJobResult;
    }

    private Humidifier.Personalize.BatchInferenceJob CreateBatchInferenceJob()
    {
        var batchInferenceJobResult = new Humidifier.Personalize.BatchInferenceJob
        {
            GivenName = InputResourceName,
        };

        return batchInferenceJobResult;
    }
    public override void CreateChildren(Humidifier.Personalize.BatchInferenceJob result)
    {
        base.CreateChildren(result);

        result.JobInput ??= JobInputFactory?.Build();
        result.JobOutput ??= JobOutputFactory?.Build();
    }

} // End Of Class

public static class BatchInferenceJobFactoryExtensions
{
    public static CombinedResult<BatchInferenceJobFactory, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput(this BatchInferenceJobFactory parentFactory, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null)
    {
        parentFactory.JobInputFactory = new InnerBatchInferenceJobBatchInferenceJobInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobInputFactory);
    }

    public static CombinedResult<BatchInferenceJobFactory, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput(this BatchInferenceJobFactory parentFactory, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null)
    {
        parentFactory.JobOutputFactory = new InnerBatchInferenceJobBatchInferenceJobOutputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobOutputFactory);
    }

    public static CombinedResult<BatchInferenceJobFactory, T1, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1>(this CombinedResult<BatchInferenceJobFactory, T1> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchInferenceJobFactory, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1>(this CombinedResult<T1, BatchInferenceJobFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<BatchInferenceJobFactory, T1, T2, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2>(this CombinedResult<BatchInferenceJobFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchInferenceJobFactory, T2, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2>(this CombinedResult<T1, BatchInferenceJobFactory, T2> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchInferenceJobFactory, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2>(this CombinedResult<T1, T2, BatchInferenceJobFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<BatchInferenceJobFactory, T1, T2, T3, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2, T3>(this CombinedResult<BatchInferenceJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchInferenceJobFactory, T2, T3, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2, T3>(this CombinedResult<T1, BatchInferenceJobFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchInferenceJobFactory, T3, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2, T3>(this CombinedResult<T1, T2, BatchInferenceJobFactory, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BatchInferenceJobFactory, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, BatchInferenceJobFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<BatchInferenceJobFactory, T1, T2, T3, T4, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2, T3, T4>(this CombinedResult<BatchInferenceJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchInferenceJobFactory, T2, T3, T4, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2, T3, T4>(this CombinedResult<T1, BatchInferenceJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchInferenceJobFactory, T3, T4, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, BatchInferenceJobFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BatchInferenceJobFactory, T4, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BatchInferenceJobFactory, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, BatchInferenceJobFactory, InnerBatchInferenceJobBatchInferenceJobInputFactory> WithJobInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BatchInferenceJobFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobInput(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<BatchInferenceJobFactory, T1, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1>(this CombinedResult<BatchInferenceJobFactory, T1> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchInferenceJobFactory, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1>(this CombinedResult<T1, BatchInferenceJobFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<BatchInferenceJobFactory, T1, T2, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2>(this CombinedResult<BatchInferenceJobFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchInferenceJobFactory, T2, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2>(this CombinedResult<T1, BatchInferenceJobFactory, T2> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchInferenceJobFactory, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2>(this CombinedResult<T1, T2, BatchInferenceJobFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<BatchInferenceJobFactory, T1, T2, T3, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<BatchInferenceJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchInferenceJobFactory, T2, T3, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<T1, BatchInferenceJobFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchInferenceJobFactory, T3, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<T1, T2, BatchInferenceJobFactory, T3> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BatchInferenceJobFactory, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<T1, T2, T3, BatchInferenceJobFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<BatchInferenceJobFactory, T1, T2, T3, T4, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<BatchInferenceJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BatchInferenceJobFactory, T2, T3, T4, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, BatchInferenceJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BatchInferenceJobFactory, T3, T4, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, BatchInferenceJobFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BatchInferenceJobFactory, T4, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BatchInferenceJobFactory, T4> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, BatchInferenceJobFactory, InnerBatchInferenceJobBatchInferenceJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BatchInferenceJobFactory> combinedResult, Action<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T5, subFactoryAction).T2);
}
