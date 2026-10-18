// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMailManagerIngressPointTlsAuthConfigurationFactory(Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration>
{

    internal InnerMailManagerIngressPointTrustStoreFactory TrustStoreFactory { get; set; }

    protected override Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration Create()
    {
        var tlsAuthConfigurationResult = CreateTlsAuthConfiguration();
        factoryAction?.Invoke(tlsAuthConfigurationResult);

        return tlsAuthConfigurationResult;
    }

    private Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration CreateTlsAuthConfiguration()
    {
        var tlsAuthConfigurationResult = new Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration();

        return tlsAuthConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration result)
    {
        base.CreateChildren(result);

        result.TrustStore ??= TrustStoreFactory?.Build();
    }

} // End Of Class

public static class InnerMailManagerIngressPointTlsAuthConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMailManagerIngressPointTlsAuthConfigurationFactory, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore(this InnerMailManagerIngressPointTlsAuthConfigurationFactory parentFactory, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null)
    {
        parentFactory.TrustStoreFactory = new InnerMailManagerIngressPointTrustStoreFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TrustStoreFactory);
    }

    public static CombinedResult<InnerMailManagerIngressPointTlsAuthConfigurationFactory, T1, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1>(this CombinedResult<InnerMailManagerIngressPointTlsAuthConfigurationFactory, T1> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrustStore(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMailManagerIngressPointTlsAuthConfigurationFactory, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1>(this CombinedResult<T1, InnerMailManagerIngressPointTlsAuthConfigurationFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrustStore(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMailManagerIngressPointTlsAuthConfigurationFactory, T1, T2, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2>(this CombinedResult<InnerMailManagerIngressPointTlsAuthConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T2, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2>(this CombinedResult<T1, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T2> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMailManagerIngressPointTlsAuthConfigurationFactory, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2>(this CombinedResult<T1, T2, InnerMailManagerIngressPointTlsAuthConfigurationFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMailManagerIngressPointTlsAuthConfigurationFactory, T1, T2, T3, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2, T3>(this CombinedResult<InnerMailManagerIngressPointTlsAuthConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T2, T3, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2, T3>(this CombinedResult<T1, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T3, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2, T3>(this CombinedResult<T1, T2, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T3> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMailManagerIngressPointTlsAuthConfigurationFactory, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMailManagerIngressPointTlsAuthConfigurationFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMailManagerIngressPointTlsAuthConfigurationFactory, T1, T2, T3, T4, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2, T3, T4>(this CombinedResult<InnerMailManagerIngressPointTlsAuthConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T2, T3, T4, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2, T3, T4>(this CombinedResult<T1, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T3, T4, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T4, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMailManagerIngressPointTlsAuthConfigurationFactory, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMailManagerIngressPointTlsAuthConfigurationFactory, InnerMailManagerIngressPointTrustStoreFactory> WithTrustStore<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMailManagerIngressPointTlsAuthConfigurationFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStore(combinedResult.T5, subFactoryAction).T2);
}
