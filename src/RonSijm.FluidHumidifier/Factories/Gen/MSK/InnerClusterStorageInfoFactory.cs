// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterStorageInfoFactory(Action<Humidifier.MSK.ClusterTypes.StorageInfo> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.StorageInfo>
{

    internal InnerClusterEBSStorageInfoFactory EBSStorageInfoFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.StorageInfo Create()
    {
        var storageInfoResult = CreateStorageInfo();
        factoryAction?.Invoke(storageInfoResult);

        return storageInfoResult;
    }

    private Humidifier.MSK.ClusterTypes.StorageInfo CreateStorageInfo()
    {
        var storageInfoResult = new Humidifier.MSK.ClusterTypes.StorageInfo();

        return storageInfoResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.StorageInfo result)
    {
        base.CreateChildren(result);

        result.EBSStorageInfo ??= EBSStorageInfoFactory?.Build();
    }

} // End Of Class

public static class InnerClusterStorageInfoFactoryExtensions
{
    public static CombinedResult<InnerClusterStorageInfoFactory, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo(this InnerClusterStorageInfoFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null)
    {
        parentFactory.EBSStorageInfoFactory = new InnerClusterEBSStorageInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EBSStorageInfoFactory);
    }

    public static CombinedResult<InnerClusterStorageInfoFactory, T1, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1>(this CombinedResult<InnerClusterStorageInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStorageInfoFactory, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1>(this CombinedResult<T1, InnerClusterStorageInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterStorageInfoFactory, T1, T2, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2>(this CombinedResult<InnerClusterStorageInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStorageInfoFactory, T2, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2>(this CombinedResult<T1, InnerClusterStorageInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterStorageInfoFactory, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2>(this CombinedResult<T1, T2, InnerClusterStorageInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterStorageInfoFactory, T1, T2, T3, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2, T3>(this CombinedResult<InnerClusterStorageInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStorageInfoFactory, T2, T3, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2, T3>(this CombinedResult<T1, InnerClusterStorageInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterStorageInfoFactory, T3, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterStorageInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterStorageInfoFactory, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterStorageInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterStorageInfoFactory, T1, T2, T3, T4, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2, T3, T4>(this CombinedResult<InnerClusterStorageInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStorageInfoFactory, T2, T3, T4, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterStorageInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterStorageInfoFactory, T3, T4, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterStorageInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterStorageInfoFactory, T4, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterStorageInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterStorageInfoFactory, InnerClusterEBSStorageInfoFactory> WithEBSStorageInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterStorageInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEBSStorageInfo(combinedResult.T5, subFactoryAction));
}
