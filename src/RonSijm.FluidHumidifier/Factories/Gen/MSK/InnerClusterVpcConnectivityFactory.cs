// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterVpcConnectivityFactory(Action<Humidifier.MSK.ClusterTypes.VpcConnectivity> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.VpcConnectivity>
{

    internal InnerClusterVpcConnectivityClientAuthenticationFactory ClientAuthenticationFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.VpcConnectivity Create()
    {
        var vpcConnectivityResult = CreateVpcConnectivity();
        factoryAction?.Invoke(vpcConnectivityResult);

        return vpcConnectivityResult;
    }

    private Humidifier.MSK.ClusterTypes.VpcConnectivity CreateVpcConnectivity()
    {
        var vpcConnectivityResult = new Humidifier.MSK.ClusterTypes.VpcConnectivity();

        return vpcConnectivityResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.VpcConnectivity result)
    {
        base.CreateChildren(result);

        result.ClientAuthentication ??= ClientAuthenticationFactory?.Build();
    }

} // End Of Class

public static class InnerClusterVpcConnectivityFactoryExtensions
{
    public static CombinedResult<InnerClusterVpcConnectivityFactory, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication(this InnerClusterVpcConnectivityFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null)
    {
        parentFactory.ClientAuthenticationFactory = new InnerClusterVpcConnectivityClientAuthenticationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClientAuthenticationFactory);
    }

    public static CombinedResult<InnerClusterVpcConnectivityFactory, T1, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1>(this CombinedResult<InnerClusterVpcConnectivityFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityFactory, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1>(this CombinedResult<T1, InnerClusterVpcConnectivityFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivityFactory, T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2>(this CombinedResult<InnerClusterVpcConnectivityFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityFactory, T2, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2>(this CombinedResult<T1, InnerClusterVpcConnectivityFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivityFactory, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2>(this CombinedResult<T1, T2, InnerClusterVpcConnectivityFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivityFactory, T1, T2, T3, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3>(this CombinedResult<InnerClusterVpcConnectivityFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityFactory, T2, T3, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3>(this CombinedResult<T1, InnerClusterVpcConnectivityFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivityFactory, T3, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterVpcConnectivityFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityFactory, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivityFactory, T1, T2, T3, T4, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3, T4>(this CombinedResult<InnerClusterVpcConnectivityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityFactory, T2, T3, T4, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterVpcConnectivityFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivityFactory, T3, T4, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterVpcConnectivityFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityFactory, T4, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterVpcConnectivityFactory, InnerClusterVpcConnectivityClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterVpcConnectivityFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T5, subFactoryAction));
}
