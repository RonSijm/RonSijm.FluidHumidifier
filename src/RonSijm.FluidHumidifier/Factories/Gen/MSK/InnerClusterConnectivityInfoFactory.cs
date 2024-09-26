// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterConnectivityInfoFactory(Action<Humidifier.MSK.ClusterTypes.ConnectivityInfo> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.ConnectivityInfo>
{

    internal InnerClusterVpcConnectivityFactory VpcConnectivityFactory { get; set; }

    internal InnerClusterPublicAccessFactory PublicAccessFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.ConnectivityInfo Create()
    {
        var connectivityInfoResult = CreateConnectivityInfo();
        factoryAction?.Invoke(connectivityInfoResult);

        return connectivityInfoResult;
    }

    private Humidifier.MSK.ClusterTypes.ConnectivityInfo CreateConnectivityInfo()
    {
        var connectivityInfoResult = new Humidifier.MSK.ClusterTypes.ConnectivityInfo();

        return connectivityInfoResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.ConnectivityInfo result)
    {
        base.CreateChildren(result);

        result.VpcConnectivity ??= VpcConnectivityFactory?.Build();
        result.PublicAccess ??= PublicAccessFactory?.Build();
    }

} // End Of Class

public static class InnerClusterConnectivityInfoFactoryExtensions
{
    public static CombinedResult<InnerClusterConnectivityInfoFactory, InnerClusterVpcConnectivityFactory> WithVpcConnectivity(this InnerClusterConnectivityInfoFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null)
    {
        parentFactory.VpcConnectivityFactory = new InnerClusterVpcConnectivityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConnectivityFactory);
    }

    public static CombinedResult<InnerClusterConnectivityInfoFactory, InnerClusterPublicAccessFactory> WithPublicAccess(this InnerClusterConnectivityInfoFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null)
    {
        parentFactory.PublicAccessFactory = new InnerClusterPublicAccessFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PublicAccessFactory);
    }

    public static CombinedResult<InnerClusterConnectivityInfoFactory, T1, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1>(this CombinedResult<InnerClusterConnectivityInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterConnectivityInfoFactory, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1>(this CombinedResult<T1, InnerClusterConnectivityInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2>(this CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2>(this CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2>(this CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2, T3, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2, T3>(this CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2, T3, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2, T3>(this CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory, T3, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterConnectivityInfoFactory, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterConnectivityInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2, T3, T4, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2, T3, T4>(this CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2, T3, T4, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory, T3, T4, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterConnectivityInfoFactory, T4, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterConnectivityInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterConnectivityInfoFactory, InnerClusterVpcConnectivityFactory> WithVpcConnectivity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterConnectivityInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConnectivity(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterConnectivityInfoFactory, T1, InnerClusterPublicAccessFactory> WithPublicAccess<T1>(this CombinedResult<InnerClusterConnectivityInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicAccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterConnectivityInfoFactory, InnerClusterPublicAccessFactory> WithPublicAccess<T1>(this CombinedResult<T1, InnerClusterConnectivityInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicAccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2>(this CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2>(this CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2>(this CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2, T3, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2, T3>(this CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2, T3, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2, T3>(this CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory, T3, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterConnectivityInfoFactory, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterConnectivityInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2, T3, T4, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2, T3, T4>(this CombinedResult<InnerClusterConnectivityInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2, T3, T4, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterConnectivityInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory, T3, T4, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterConnectivityInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterConnectivityInfoFactory, T4, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterConnectivityInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterConnectivityInfoFactory, InnerClusterPublicAccessFactory> WithPublicAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterConnectivityInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.PublicAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccess(combinedResult.T5, subFactoryAction));
}
