// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class DatasetExportJobFactory(string resourceName = null, Action<Humidifier.Personalize.DatasetExportJob> factoryAction = null) : ResourceFactory<Humidifier.Personalize.DatasetExportJob>(resourceName)
{

    internal InnerDatasetExportJobDatasetExportJobOutputFactory JobOutputFactory { get; set; }

    protected override Humidifier.Personalize.DatasetExportJob Create()
    {
        var datasetExportJobResult = CreateDatasetExportJob();
        factoryAction?.Invoke(datasetExportJobResult);

        return datasetExportJobResult;
    }

    private Humidifier.Personalize.DatasetExportJob CreateDatasetExportJob()
    {
        var datasetExportJobResult = new Humidifier.Personalize.DatasetExportJob
        {
            GivenName = InputResourceName,
        };

        return datasetExportJobResult;
    }
    public override void CreateChildren(Humidifier.Personalize.DatasetExportJob result)
    {
        base.CreateChildren(result);

        result.JobOutput ??= JobOutputFactory?.Build();
    }

} // End Of Class

public static class DatasetExportJobFactoryExtensions
{
    public static CombinedResult<DatasetExportJobFactory, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput(this DatasetExportJobFactory parentFactory, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null)
    {
        parentFactory.JobOutputFactory = new InnerDatasetExportJobDatasetExportJobOutputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobOutputFactory);
    }

    public static CombinedResult<DatasetExportJobFactory, T1, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1>(this CombinedResult<DatasetExportJobFactory, T1> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetExportJobFactory, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1>(this CombinedResult<T1, DatasetExportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DatasetExportJobFactory, T1, T2, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2>(this CombinedResult<DatasetExportJobFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetExportJobFactory, T2, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2>(this CombinedResult<T1, DatasetExportJobFactory, T2> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetExportJobFactory, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2>(this CombinedResult<T1, T2, DatasetExportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DatasetExportJobFactory, T1, T2, T3, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<DatasetExportJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetExportJobFactory, T2, T3, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<T1, DatasetExportJobFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetExportJobFactory, T3, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<T1, T2, DatasetExportJobFactory, T3> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetExportJobFactory, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetExportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DatasetExportJobFactory, T1, T2, T3, T4, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<DatasetExportJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetExportJobFactory, T2, T3, T4, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, DatasetExportJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetExportJobFactory, T3, T4, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetExportJobFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetExportJobFactory, T4, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetExportJobFactory, T4> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DatasetExportJobFactory, InnerDatasetExportJobDatasetExportJobOutputFactory> WithJobOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetExportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobOutput(combinedResult.T5, subFactoryAction).T2);
}
