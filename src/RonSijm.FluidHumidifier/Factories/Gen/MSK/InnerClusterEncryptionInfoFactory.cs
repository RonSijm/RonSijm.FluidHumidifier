// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterEncryptionInfoFactory(Action<Humidifier.MSK.ClusterTypes.EncryptionInfo> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.EncryptionInfo>
{

    internal InnerClusterEncryptionAtRestFactory EncryptionAtRestFactory { get; set; }

    internal InnerClusterEncryptionInTransitFactory EncryptionInTransitFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.EncryptionInfo Create()
    {
        var encryptionInfoResult = CreateEncryptionInfo();
        factoryAction?.Invoke(encryptionInfoResult);

        return encryptionInfoResult;
    }

    private Humidifier.MSK.ClusterTypes.EncryptionInfo CreateEncryptionInfo()
    {
        var encryptionInfoResult = new Humidifier.MSK.ClusterTypes.EncryptionInfo();

        return encryptionInfoResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.EncryptionInfo result)
    {
        base.CreateChildren(result);

        result.EncryptionAtRest ??= EncryptionAtRestFactory?.Build();
        result.EncryptionInTransit ??= EncryptionInTransitFactory?.Build();
    }

} // End Of Class

public static class InnerClusterEncryptionInfoFactoryExtensions
{
    public static CombinedResult<InnerClusterEncryptionInfoFactory, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest(this InnerClusterEncryptionInfoFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null)
    {
        parentFactory.EncryptionAtRestFactory = new InnerClusterEncryptionAtRestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionAtRestFactory);
    }

    public static CombinedResult<InnerClusterEncryptionInfoFactory, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit(this InnerClusterEncryptionInfoFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null)
    {
        parentFactory.EncryptionInTransitFactory = new InnerClusterEncryptionInTransitFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionInTransitFactory);
    }

    public static CombinedResult<InnerClusterEncryptionInfoFactory, T1, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1>(this CombinedResult<InnerClusterEncryptionInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionInfoFactory, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1>(this CombinedResult<T1, InnerClusterEncryptionInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2>(this CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2>(this CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2>(this CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2, T3, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2, T3>(this CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2, T3, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2, T3>(this CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory, T3, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterEncryptionInfoFactory, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterEncryptionInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2, T3, T4, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2, T3, T4>(this CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2, T3, T4, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory, T3, T4, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterEncryptionInfoFactory, T4, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterEncryptionInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterEncryptionInfoFactory, InnerClusterEncryptionAtRestFactory> WithEncryptionAtRest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterEncryptionInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionAtRest(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterEncryptionInfoFactory, T1, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1>(this CombinedResult<InnerClusterEncryptionInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionInfoFactory, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1>(this CombinedResult<T1, InnerClusterEncryptionInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2>(this CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2>(this CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2>(this CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2, T3, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2, T3>(this CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2, T3, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2, T3>(this CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory, T3, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterEncryptionInfoFactory, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterEncryptionInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2, T3, T4, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2, T3, T4>(this CombinedResult<InnerClusterEncryptionInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2, T3, T4, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterEncryptionInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory, T3, T4, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterEncryptionInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterEncryptionInfoFactory, T4, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterEncryptionInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterEncryptionInfoFactory, InnerClusterEncryptionInTransitFactory> WithEncryptionInTransit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterEncryptionInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionInTransit(combinedResult.T5, subFactoryAction));
}
