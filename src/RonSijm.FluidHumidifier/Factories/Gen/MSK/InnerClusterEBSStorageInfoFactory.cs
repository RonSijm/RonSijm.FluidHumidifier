// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterEBSStorageInfoFactory(Action<Humidifier.MSK.ClusterTypes.EBSStorageInfo> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.EBSStorageInfo>
{

    internal InnerClusterProvisionedThroughputFactory ProvisionedThroughputFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.EBSStorageInfo Create()
    {
        var eBSStorageInfoResult = CreateEBSStorageInfo();
        factoryAction?.Invoke(eBSStorageInfoResult);

        return eBSStorageInfoResult;
    }

    private Humidifier.MSK.ClusterTypes.EBSStorageInfo CreateEBSStorageInfo()
    {
        var eBSStorageInfoResult = new Humidifier.MSK.ClusterTypes.EBSStorageInfo();

        return eBSStorageInfoResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.EBSStorageInfo result)
    {
        base.CreateChildren(result);

        result.ProvisionedThroughput ??= ProvisionedThroughputFactory?.Build();
    }

} // End Of Class

public static class InnerClusterEBSStorageInfoFactoryExtensions
{
    public static CombinedResult<InnerClusterEBSStorageInfoFactory, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput(this InnerClusterEBSStorageInfoFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null)
    {
        parentFactory.ProvisionedThroughputFactory = new InnerClusterProvisionedThroughputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProvisionedThroughputFactory);
    }

    public static CombinedResult<InnerClusterEBSStorageInfoFactory, T1, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1>(this CombinedResult<InnerClusterEBSStorageInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEBSStorageInfoFactory, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1>(this CombinedResult<T1, InnerClusterEBSStorageInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterEBSStorageInfoFactory, T1, T2, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2>(this CombinedResult<InnerClusterEBSStorageInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEBSStorageInfoFactory, T2, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2>(this CombinedResult<T1, InnerClusterEBSStorageInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEBSStorageInfoFactory, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2>(this CombinedResult<T1, T2, InnerClusterEBSStorageInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterEBSStorageInfoFactory, T1, T2, T3, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3>(this CombinedResult<InnerClusterEBSStorageInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEBSStorageInfoFactory, T2, T3, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3>(this CombinedResult<T1, InnerClusterEBSStorageInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEBSStorageInfoFactory, T3, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterEBSStorageInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterEBSStorageInfoFactory, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterEBSStorageInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterEBSStorageInfoFactory, T1, T2, T3, T4, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3, T4>(this CombinedResult<InnerClusterEBSStorageInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEBSStorageInfoFactory, T2, T3, T4, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterEBSStorageInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEBSStorageInfoFactory, T3, T4, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterEBSStorageInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterEBSStorageInfoFactory, T4, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterEBSStorageInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterEBSStorageInfoFactory, InnerClusterProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterEBSStorageInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T5, subFactoryAction));
}
