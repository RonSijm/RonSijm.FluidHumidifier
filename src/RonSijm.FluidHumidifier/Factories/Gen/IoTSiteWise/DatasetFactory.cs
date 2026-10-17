// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class DatasetFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.Dataset> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.Dataset>(resourceName)
{

    internal InnerDatasetDatasetConfigFactory DatasetConfigFactory { get; set; }

    internal InnerDatasetDatasetSourceFactory DatasetSourceFactory { get; set; }

    protected override Humidifier.IoTSiteWise.Dataset Create()
    {
        var datasetResult = CreateDataset();
        factoryAction?.Invoke(datasetResult);

        return datasetResult;
    }

    private Humidifier.IoTSiteWise.Dataset CreateDataset()
    {
        var datasetResult = new Humidifier.IoTSiteWise.Dataset
        {
            GivenName = InputResourceName,
        };

        return datasetResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.Dataset result)
    {
        base.CreateChildren(result);

        result.DatasetConfig ??= DatasetConfigFactory?.Build();
        result.DatasetSource ??= DatasetSourceFactory?.Build();
    }

} // End Of Class

public static class DatasetFactoryExtensions
{
    public static CombinedResult<DatasetFactory, InnerDatasetDatasetConfigFactory> WithDatasetConfig(this DatasetFactory parentFactory, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null)
    {
        parentFactory.DatasetConfigFactory = new InnerDatasetDatasetConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatasetConfigFactory);
    }

    public static CombinedResult<DatasetFactory, InnerDatasetDatasetSourceFactory> WithDatasetSource(this DatasetFactory parentFactory, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null)
    {
        parentFactory.DatasetSourceFactory = new InnerDatasetDatasetSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatasetSourceFactory);
    }

    public static CombinedResult<DatasetFactory, T1, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetDatasetConfigFactory> WithDatasetConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetDatasetSourceFactory> WithDatasetSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetSource(combinedResult.T5, subFactoryAction).T2);
}
