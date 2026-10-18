// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerClusterJwtAuthFactory(Action<Humidifier.PCS.ClusterTypes.JwtAuth> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ClusterTypes.JwtAuth>
{

    internal InnerClusterJwtKeyFactory JwtKeyFactory { get; set; }

    protected override Humidifier.PCS.ClusterTypes.JwtAuth Create()
    {
        var jwtAuthResult = CreateJwtAuth();
        factoryAction?.Invoke(jwtAuthResult);

        return jwtAuthResult;
    }

    private Humidifier.PCS.ClusterTypes.JwtAuth CreateJwtAuth()
    {
        var jwtAuthResult = new Humidifier.PCS.ClusterTypes.JwtAuth();

        return jwtAuthResult;
    }
    public override void CreateChildren(Humidifier.PCS.ClusterTypes.JwtAuth result)
    {
        base.CreateChildren(result);

        result.JwtKey ??= JwtKeyFactory?.Build();
    }

} // End Of Class

public static class InnerClusterJwtAuthFactoryExtensions
{
    public static CombinedResult<InnerClusterJwtAuthFactory, InnerClusterJwtKeyFactory> WithJwtKey(this InnerClusterJwtAuthFactory parentFactory, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null)
    {
        parentFactory.JwtKeyFactory = new InnerClusterJwtKeyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JwtKeyFactory);
    }

    public static CombinedResult<InnerClusterJwtAuthFactory, T1, InnerClusterJwtKeyFactory> WithJwtKey<T1>(this CombinedResult<InnerClusterJwtAuthFactory, T1> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithJwtKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterJwtAuthFactory, InnerClusterJwtKeyFactory> WithJwtKey<T1>(this CombinedResult<T1, InnerClusterJwtAuthFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithJwtKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterJwtAuthFactory, T1, T2, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2>(this CombinedResult<InnerClusterJwtAuthFactory, T1, T2> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterJwtAuthFactory, T2, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2>(this CombinedResult<T1, InnerClusterJwtAuthFactory, T2> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterJwtAuthFactory, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2>(this CombinedResult<T1, T2, InnerClusterJwtAuthFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterJwtAuthFactory, T1, T2, T3, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2, T3>(this CombinedResult<InnerClusterJwtAuthFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterJwtAuthFactory, T2, T3, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2, T3>(this CombinedResult<T1, InnerClusterJwtAuthFactory, T2, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterJwtAuthFactory, T3, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterJwtAuthFactory, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterJwtAuthFactory, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterJwtAuthFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterJwtAuthFactory, T1, T2, T3, T4, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2, T3, T4>(this CombinedResult<InnerClusterJwtAuthFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterJwtAuthFactory, T2, T3, T4, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterJwtAuthFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterJwtAuthFactory, T3, T4, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterJwtAuthFactory, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterJwtAuthFactory, T4, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterJwtAuthFactory, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterJwtAuthFactory, InnerClusterJwtKeyFactory> WithJwtKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterJwtAuthFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.JwtKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtKey(combinedResult.T5, subFactoryAction).T2);
}
