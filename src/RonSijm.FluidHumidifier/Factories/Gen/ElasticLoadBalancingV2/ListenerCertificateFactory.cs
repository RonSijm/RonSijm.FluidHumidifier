// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class ListenerCertificateFactory(string resourceName = null, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificate> factoryAction = null) : ResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerCertificate>(resourceName)
{

    internal List<InnerListenerCertificateCertificateFactory> CertificatesFactories { get; set; } = [];

    protected override Humidifier.ElasticLoadBalancingV2.ListenerCertificate Create()
    {
        var listenerCertificateResult = CreateListenerCertificate();
        factoryAction?.Invoke(listenerCertificateResult);

        return listenerCertificateResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerCertificate CreateListenerCertificate()
    {
        var listenerCertificateResult = new Humidifier.ElasticLoadBalancingV2.ListenerCertificate
        {
            GivenName = InputResourceName,
        };

        return listenerCertificateResult;
    }
    public override void CreateChildren(Humidifier.ElasticLoadBalancingV2.ListenerCertificate result)
    {
        base.CreateChildren(result);

        result.Certificates = CertificatesFactories.Any() ? CertificatesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ListenerCertificateFactoryExtensions
{
    public static CombinedResult<ListenerCertificateFactory, InnerListenerCertificateCertificateFactory> WithCertificates(this ListenerCertificateFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null)
    {
        var factory = new InnerListenerCertificateCertificateFactory(subFactoryAction);
        parentFactory.CertificatesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ListenerCertificateFactory, T1, InnerListenerCertificateCertificateFactory> WithCertificates<T1>(this CombinedResult<ListenerCertificateFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerCertificateFactory, InnerListenerCertificateCertificateFactory> WithCertificates<T1>(this CombinedResult<T1, ListenerCertificateFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ListenerCertificateFactory, T1, T2, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2>(this CombinedResult<ListenerCertificateFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerCertificateFactory, T2, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2>(this CombinedResult<T1, ListenerCertificateFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerCertificateFactory, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2>(this CombinedResult<T1, T2, ListenerCertificateFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ListenerCertificateFactory, T1, T2, T3, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2, T3>(this CombinedResult<ListenerCertificateFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerCertificateFactory, T2, T3, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2, T3>(this CombinedResult<T1, ListenerCertificateFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerCertificateFactory, T3, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2, T3>(this CombinedResult<T1, T2, ListenerCertificateFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ListenerCertificateFactory, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2, T3>(this CombinedResult<T1, T2, T3, ListenerCertificateFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ListenerCertificateFactory, T1, T2, T3, T4, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2, T3, T4>(this CombinedResult<ListenerCertificateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerCertificateFactory, T2, T3, T4, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2, T3, T4>(this CombinedResult<T1, ListenerCertificateFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerCertificateFactory, T3, T4, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2, T3, T4>(this CombinedResult<T1, T2, ListenerCertificateFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ListenerCertificateFactory, T4, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ListenerCertificateFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ListenerCertificateFactory, InnerListenerCertificateCertificateFactory> WithCertificates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ListenerCertificateFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T5, subFactoryAction));
}
