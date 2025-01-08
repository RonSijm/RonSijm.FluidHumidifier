// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterStorageConfigFactory(Action<Humidifier.EKS.ClusterTypes.StorageConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.StorageConfig>
{

    internal InnerClusterBlockStorageFactory BlockStorageFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.StorageConfig Create()
    {
        var storageConfigResult = CreateStorageConfig();
        factoryAction?.Invoke(storageConfigResult);

        return storageConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.StorageConfig CreateStorageConfig()
    {
        var storageConfigResult = new Humidifier.EKS.ClusterTypes.StorageConfig();

        return storageConfigResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.StorageConfig result)
    {
        base.CreateChildren(result);

        result.BlockStorage ??= BlockStorageFactory?.Build();
    }

} // End Of Class

public static class InnerClusterStorageConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterStorageConfigFactory, InnerClusterBlockStorageFactory> WithBlockStorage(this InnerClusterStorageConfigFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null)
    {
        parentFactory.BlockStorageFactory = new InnerClusterBlockStorageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BlockStorageFactory);
    }

    public static CombinedResult<InnerClusterStorageConfigFactory, T1, InnerClusterBlockStorageFactory> WithBlockStorage<T1>(this CombinedResult<InnerClusterStorageConfigFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithBlockStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStorageConfigFactory, InnerClusterBlockStorageFactory> WithBlockStorage<T1>(this CombinedResult<T1, InnerClusterStorageConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithBlockStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterStorageConfigFactory, T1, T2, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2>(this CombinedResult<InnerClusterStorageConfigFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStorageConfigFactory, T2, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2>(this CombinedResult<T1, InnerClusterStorageConfigFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterStorageConfigFactory, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2>(this CombinedResult<T1, T2, InnerClusterStorageConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterStorageConfigFactory, T1, T2, T3, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2, T3>(this CombinedResult<InnerClusterStorageConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStorageConfigFactory, T2, T3, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2, T3>(this CombinedResult<T1, InnerClusterStorageConfigFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterStorageConfigFactory, T3, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterStorageConfigFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterStorageConfigFactory, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterStorageConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterStorageConfigFactory, T1, T2, T3, T4, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2, T3, T4>(this CombinedResult<InnerClusterStorageConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStorageConfigFactory, T2, T3, T4, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterStorageConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterStorageConfigFactory, T3, T4, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterStorageConfigFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterStorageConfigFactory, T4, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterStorageConfigFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterStorageConfigFactory, InnerClusterBlockStorageFactory> WithBlockStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterStorageConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.BlockStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockStorage(combinedResult.T5, subFactoryAction));
}
