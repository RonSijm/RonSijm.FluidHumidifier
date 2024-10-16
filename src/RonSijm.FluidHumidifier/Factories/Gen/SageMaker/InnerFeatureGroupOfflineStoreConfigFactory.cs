// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerFeatureGroupOfflineStoreConfigFactory(Action<Humidifier.SageMaker.FeatureGroupTypes.OfflineStoreConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.FeatureGroupTypes.OfflineStoreConfig>
{

    internal InnerFeatureGroupDataCatalogConfigFactory DataCatalogConfigFactory { get; set; }

    internal InnerFeatureGroupS3StorageConfigFactory S3StorageConfigFactory { get; set; }

    protected override Humidifier.SageMaker.FeatureGroupTypes.OfflineStoreConfig Create()
    {
        var offlineStoreConfigResult = CreateOfflineStoreConfig();
        factoryAction?.Invoke(offlineStoreConfigResult);

        return offlineStoreConfigResult;
    }

    private Humidifier.SageMaker.FeatureGroupTypes.OfflineStoreConfig CreateOfflineStoreConfig()
    {
        var offlineStoreConfigResult = new Humidifier.SageMaker.FeatureGroupTypes.OfflineStoreConfig();

        return offlineStoreConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.FeatureGroupTypes.OfflineStoreConfig result)
    {
        base.CreateChildren(result);

        result.DataCatalogConfig ??= DataCatalogConfigFactory?.Build();
        result.S3StorageConfig ??= S3StorageConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFeatureGroupOfflineStoreConfigFactoryExtensions
{
    public static CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig(this InnerFeatureGroupOfflineStoreConfigFactory parentFactory, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null)
    {
        parentFactory.DataCatalogConfigFactory = new InnerFeatureGroupDataCatalogConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataCatalogConfigFactory);
    }

    public static CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig(this InnerFeatureGroupOfflineStoreConfigFactory parentFactory, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null)
    {
        parentFactory.S3StorageConfigFactory = new InnerFeatureGroupS3StorageConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3StorageConfigFactory);
    }

    public static CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1>(this CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1>(this CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2>(this CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2>(this CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2>(this CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2, T3, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2, T3>(this CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2, T3, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2, T3>(this CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory, T3, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFeatureGroupOfflineStoreConfigFactory, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFeatureGroupOfflineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2, T3, T4, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2, T3, T4>(this CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2, T3, T4, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory, T3, T4, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFeatureGroupOfflineStoreConfigFactory, T4, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFeatureGroupOfflineStoreConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFeatureGroupOfflineStoreConfigFactory, InnerFeatureGroupDataCatalogConfigFactory> WithDataCatalogConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFeatureGroupOfflineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1>(this CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1>(this CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2>(this CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2>(this CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2>(this CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2, T3, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3>(this CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2, T3, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3>(this CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory, T3, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFeatureGroupOfflineStoreConfigFactory, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFeatureGroupOfflineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2, T3, T4, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3, T4>(this CombinedResult<InnerFeatureGroupOfflineStoreConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2, T3, T4, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFeatureGroupOfflineStoreConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory, T3, T4, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFeatureGroupOfflineStoreConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFeatureGroupOfflineStoreConfigFactory, T4, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFeatureGroupOfflineStoreConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFeatureGroupOfflineStoreConfigFactory, InnerFeatureGroupS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFeatureGroupOfflineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T5, subFactoryAction));
}
