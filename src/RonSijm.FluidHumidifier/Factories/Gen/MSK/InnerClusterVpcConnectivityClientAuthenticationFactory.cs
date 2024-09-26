// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterVpcConnectivityClientAuthenticationFactory(Action<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication>
{

    internal InnerClusterVpcConnectivitySaslFactory SaslFactory { get; set; }

    internal InnerClusterVpcConnectivityTlsFactory TlsFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication Create()
    {
        var vpcConnectivityClientAuthenticationResult = CreateVpcConnectivityClientAuthentication();
        factoryAction?.Invoke(vpcConnectivityClientAuthenticationResult);

        return vpcConnectivityClientAuthenticationResult;
    }

    private Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication CreateVpcConnectivityClientAuthentication()
    {
        var vpcConnectivityClientAuthenticationResult = new Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication();

        return vpcConnectivityClientAuthenticationResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication result)
    {
        base.CreateChildren(result);

        result.Sasl ??= SaslFactory?.Build();
        result.Tls ??= TlsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterVpcConnectivityClientAuthenticationFactoryExtensions
{
    public static CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, InnerClusterVpcConnectivitySaslFactory> WithSasl(this InnerClusterVpcConnectivityClientAuthenticationFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null)
    {
        parentFactory.SaslFactory = new InnerClusterVpcConnectivitySaslFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SaslFactory);
    }

    public static CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, InnerClusterVpcConnectivityTlsFactory> WithTls(this InnerClusterVpcConnectivityClientAuthenticationFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null)
    {
        parentFactory.TlsFactory = new InnerClusterVpcConnectivityTlsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TlsFactory);
    }

    public static CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1>(this CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1>(this CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2>(this CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2>(this CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2>(this CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2, T3, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2, T3, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory, T3, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityClientAuthenticationFactory, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2, T3, T4, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2, T3, T4, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory, T3, T4, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityClientAuthenticationFactory, T4, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityClientAuthenticationFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterVpcConnectivityClientAuthenticationFactory, InnerClusterVpcConnectivitySaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterVpcConnectivityClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, InnerClusterVpcConnectivityTlsFactory> WithTls<T1>(this CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, WithTls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, InnerClusterVpcConnectivityTlsFactory> WithTls<T1>(this CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, WithTls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2>(this CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2>(this CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2>(this CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2, T3, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2, T3>(this CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2, T3, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2, T3>(this CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory, T3, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityClientAuthenticationFactory, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2, T3, T4, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2, T3, T4>(this CombinedResult<InnerClusterVpcConnectivityClientAuthenticationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2, T3, T4, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterVpcConnectivityClientAuthenticationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory, T3, T4, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterVpcConnectivityClientAuthenticationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityClientAuthenticationFactory, T4, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterVpcConnectivityClientAuthenticationFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterVpcConnectivityClientAuthenticationFactory, InnerClusterVpcConnectivityTlsFactory> WithTls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterVpcConnectivityClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T5, subFactoryAction));
}
