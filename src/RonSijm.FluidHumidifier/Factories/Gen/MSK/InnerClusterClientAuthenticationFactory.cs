// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterClientAuthenticationFactory(Action<Humidifier.MSK.ClusterTypes.ClientAuthentication> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.ClientAuthentication>
{

    internal InnerClusterSaslFactory SaslFactory { get; set; }

    internal InnerClusterUnauthenticatedFactory UnauthenticatedFactory { get; set; }

    internal InnerClusterTlsFactory TlsFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.ClientAuthentication Create()
    {
        var clientAuthenticationResult = CreateClientAuthentication();
        factoryAction?.Invoke(clientAuthenticationResult);

        return clientAuthenticationResult;
    }

    private Humidifier.MSK.ClusterTypes.ClientAuthentication CreateClientAuthentication()
    {
        var clientAuthenticationResult = new Humidifier.MSK.ClusterTypes.ClientAuthentication();

        return clientAuthenticationResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.ClientAuthentication result)
    {
        base.CreateChildren(result);

        result.Sasl ??= SaslFactory?.Build();
        result.Unauthenticated ??= UnauthenticatedFactory?.Build();
        result.Tls ??= TlsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterClientAuthenticationFactoryExtensions
{
    public static CombinedResult<InnerClusterClientAuthenticationFactory, InnerClusterSaslFactory> WithSasl(this InnerClusterClientAuthenticationFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null)
    {
        parentFactory.SaslFactory = new InnerClusterSaslFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SaslFactory);
    }

    public static CombinedResult<InnerClusterClientAuthenticationFactory, InnerClusterUnauthenticatedFactory> WithUnauthenticated(this InnerClusterClientAuthenticationFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null)
    {
        parentFactory.UnauthenticatedFactory = new InnerClusterUnauthenticatedFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UnauthenticatedFactory);
    }

    public static CombinedResult<InnerClusterClientAuthenticationFactory, InnerClusterTlsFactory> WithTls(this InnerClusterClientAuthenticationFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null)
    {
        parentFactory.TlsFactory = new InnerClusterTlsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TlsFactory);
    }

    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, InnerClusterSaslFactory> WithSasl<T1>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, InnerClusterSaslFactory> WithSasl<T1>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, InnerClusterSaslFactory> WithSasl<T1, T2>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, InnerClusterSaslFactory> WithSasl<T1, T2>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, InnerClusterSaslFactory> WithSasl<T1, T2>(this CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3, InnerClusterSaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3, InnerClusterSaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3, InnerClusterSaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory, InnerClusterSaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3, T4, InnerClusterSaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3, T4, InnerClusterSaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3, T4, InnerClusterSaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory, T4, InnerClusterSaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterClientAuthenticationFactory, InnerClusterSaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, WithUnauthenticated(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, WithUnauthenticated(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2>(this CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2, T3>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2, T3>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3, T4, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2, T3, T4>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3, T4, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3, T4, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory, T4, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterClientAuthenticationFactory, InnerClusterUnauthenticatedFactory> WithUnauthenticated<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Unauthenticated> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnauthenticated(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, InnerClusterTlsFactory> WithTls<T1>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, WithTls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, InnerClusterTlsFactory> WithTls<T1>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, WithTls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, InnerClusterTlsFactory> WithTls<T1, T2>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, InnerClusterTlsFactory> WithTls<T1, T2>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, InnerClusterTlsFactory> WithTls<T1, T2>(this CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3, InnerClusterTlsFactory> WithTls<T1, T2, T3>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3, InnerClusterTlsFactory> WithTls<T1, T2, T3>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3, InnerClusterTlsFactory> WithTls<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory, InnerClusterTlsFactory> WithTls<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3, T4, InnerClusterTlsFactory> WithTls<T1, T2, T3, T4>(this CombinedResult<InnerClusterClientAuthenticationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3, T4, InnerClusterTlsFactory> WithTls<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterClientAuthenticationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3, T4, InnerClusterTlsFactory> WithTls<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterClientAuthenticationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory, T4, InnerClusterTlsFactory> WithTls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterClientAuthenticationFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterClientAuthenticationFactory, InnerClusterTlsFactory> WithTls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Tls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTls(combinedResult.T5, subFactoryAction));
}
