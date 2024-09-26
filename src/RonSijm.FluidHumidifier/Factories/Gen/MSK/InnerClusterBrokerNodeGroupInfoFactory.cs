// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterBrokerNodeGroupInfoFactory(Action<Humidifier.MSK.ClusterTypes.BrokerNodeGroupInfo> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.BrokerNodeGroupInfo>
{

    internal InnerClusterConnectivityInfoFactory ConnectivityInfoFactory { get; set; }

    internal InnerClusterStorageInfoFactory StorageInfoFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.BrokerNodeGroupInfo Create()
    {
        var brokerNodeGroupInfoResult = CreateBrokerNodeGroupInfo();
        factoryAction?.Invoke(brokerNodeGroupInfoResult);

        return brokerNodeGroupInfoResult;
    }

    private Humidifier.MSK.ClusterTypes.BrokerNodeGroupInfo CreateBrokerNodeGroupInfo()
    {
        var brokerNodeGroupInfoResult = new Humidifier.MSK.ClusterTypes.BrokerNodeGroupInfo();

        return brokerNodeGroupInfoResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.BrokerNodeGroupInfo result)
    {
        base.CreateChildren(result);

        result.ConnectivityInfo ??= ConnectivityInfoFactory?.Build();
        result.StorageInfo ??= StorageInfoFactory?.Build();
    }

} // End Of Class

public static class InnerClusterBrokerNodeGroupInfoFactoryExtensions
{
    public static CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, InnerClusterConnectivityInfoFactory> WithConnectivityInfo(this InnerClusterBrokerNodeGroupInfoFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null)
    {
        parentFactory.ConnectivityInfoFactory = new InnerClusterConnectivityInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectivityInfoFactory);
    }

    public static CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, InnerClusterStorageInfoFactory> WithStorageInfo(this InnerClusterBrokerNodeGroupInfoFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null)
    {
        parentFactory.StorageInfoFactory = new InnerClusterStorageInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageInfoFactory);
    }

    public static CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1>(this CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1>(this CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2>(this CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2>(this CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2>(this CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2, T3, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2, T3>(this CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2, T3, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2, T3>(this CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory, T3, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBrokerNodeGroupInfoFactory, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterBrokerNodeGroupInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2, T3, T4, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2, T3, T4>(this CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2, T3, T4, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory, T3, T4, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBrokerNodeGroupInfoFactory, T4, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterBrokerNodeGroupInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterBrokerNodeGroupInfoFactory, InnerClusterConnectivityInfoFactory> WithConnectivityInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterBrokerNodeGroupInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectivityInfo(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, InnerClusterStorageInfoFactory> WithStorageInfo<T1>(this CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, InnerClusterStorageInfoFactory> WithStorageInfo<T1>(this CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2>(this CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2>(this CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2>(this CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2, T3, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2, T3>(this CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2, T3, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2, T3>(this CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory, T3, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBrokerNodeGroupInfoFactory, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterBrokerNodeGroupInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2, T3, T4, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2, T3, T4>(this CombinedResult<InnerClusterBrokerNodeGroupInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2, T3, T4, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterBrokerNodeGroupInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory, T3, T4, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterBrokerNodeGroupInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBrokerNodeGroupInfoFactory, T4, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterBrokerNodeGroupInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterBrokerNodeGroupInfoFactory, InnerClusterStorageInfoFactory> WithStorageInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterBrokerNodeGroupInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.StorageInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageInfo(combinedResult.T5, subFactoryAction));
}
