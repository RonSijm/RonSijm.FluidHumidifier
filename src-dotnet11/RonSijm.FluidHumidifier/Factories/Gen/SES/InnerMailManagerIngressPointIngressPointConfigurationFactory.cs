// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMailManagerIngressPointIngressPointConfigurationFactory(Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration>
{

    internal InnerMailManagerIngressPointTlsAuthConfigurationFactory TlsAuthConfigurationFactory { get; set; }

    protected override Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration Create()
    {
        var ingressPointConfigurationResult = CreateIngressPointConfiguration();
        factoryAction?.Invoke(ingressPointConfigurationResult);

        return ingressPointConfigurationResult;
    }

    private Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration CreateIngressPointConfiguration()
    {
        var ingressPointConfigurationResult = new Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration();

        return ingressPointConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration result)
    {
        base.CreateChildren(result);

        result.TlsAuthConfiguration ??= TlsAuthConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMailManagerIngressPointIngressPointConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMailManagerIngressPointIngressPointConfigurationFactory, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration(this InnerMailManagerIngressPointIngressPointConfigurationFactory parentFactory, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null)
    {
        parentFactory.TlsAuthConfigurationFactory = new InnerMailManagerIngressPointTlsAuthConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TlsAuthConfigurationFactory);
    }

    public static CombinedResult<InnerMailManagerIngressPointIngressPointConfigurationFactory, T1, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1>(this CombinedResult<InnerMailManagerIngressPointIngressPointConfigurationFactory, T1> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMailManagerIngressPointIngressPointConfigurationFactory, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1>(this CombinedResult<T1, InnerMailManagerIngressPointIngressPointConfigurationFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMailManagerIngressPointIngressPointConfigurationFactory, T1, T2, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2>(this CombinedResult<InnerMailManagerIngressPointIngressPointConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMailManagerIngressPointIngressPointConfigurationFactory, T2, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2>(this CombinedResult<T1, InnerMailManagerIngressPointIngressPointConfigurationFactory, T2> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMailManagerIngressPointIngressPointConfigurationFactory, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMailManagerIngressPointIngressPointConfigurationFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMailManagerIngressPointIngressPointConfigurationFactory, T1, T2, T3, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2, T3>(this CombinedResult<InnerMailManagerIngressPointIngressPointConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMailManagerIngressPointIngressPointConfigurationFactory, T2, T3, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMailManagerIngressPointIngressPointConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMailManagerIngressPointIngressPointConfigurationFactory, T3, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMailManagerIngressPointIngressPointConfigurationFactory, T3> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMailManagerIngressPointIngressPointConfigurationFactory, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMailManagerIngressPointIngressPointConfigurationFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMailManagerIngressPointIngressPointConfigurationFactory, T1, T2, T3, T4, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMailManagerIngressPointIngressPointConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMailManagerIngressPointIngressPointConfigurationFactory, T2, T3, T4, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMailManagerIngressPointIngressPointConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMailManagerIngressPointIngressPointConfigurationFactory, T3, T4, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMailManagerIngressPointIngressPointConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMailManagerIngressPointIngressPointConfigurationFactory, T4, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMailManagerIngressPointIngressPointConfigurationFactory, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMailManagerIngressPointIngressPointConfigurationFactory, InnerMailManagerIngressPointTlsAuthConfigurationFactory> WithTlsAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMailManagerIngressPointIngressPointConfigurationFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsAuthConfiguration(combinedResult.T5, subFactoryAction).T2);
}
