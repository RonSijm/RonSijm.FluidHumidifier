// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class DatasetFactory(string resourceName = null, Action<Humidifier.Personalize.Dataset> factoryAction = null) : ResourceFactory<Humidifier.Personalize.Dataset>(resourceName)
{

    internal InnerDatasetDatasetImportJobFactory DatasetImportJobFactory { get; set; }

    protected override Humidifier.Personalize.Dataset Create()
    {
        var datasetResult = CreateDataset();
        factoryAction?.Invoke(datasetResult);

        return datasetResult;
    }

    private Humidifier.Personalize.Dataset CreateDataset()
    {
        var datasetResult = new Humidifier.Personalize.Dataset
        {
            GivenName = InputResourceName,
        };

        return datasetResult;
    }
    public override void CreateChildren(Humidifier.Personalize.Dataset result)
    {
        base.CreateChildren(result);

        result.DatasetImportJob ??= DatasetImportJobFactory?.Build();
    }

} // End Of Class

public static class DatasetFactoryExtensions
{
    public static CombinedResult<DatasetFactory, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob(this DatasetFactory parentFactory, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null)
    {
        parentFactory.DatasetImportJobFactory = new InnerDatasetDatasetImportJobFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatasetImportJobFactory);
    }

    public static CombinedResult<DatasetFactory, T1, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetDatasetImportJobFactory> WithDatasetImportJob<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetImportJob(combinedResult.T5, subFactoryAction));
}
