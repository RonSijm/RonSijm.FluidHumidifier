// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class MailManagerIngressPointFactory(string resourceName = null, Action<Humidifier.SES.MailManagerIngressPoint> factoryAction = null) : ResourceFactory<Humidifier.SES.MailManagerIngressPoint>(resourceName)
{

    internal InnerMailManagerIngressPointIngressPointConfigurationFactory IngressPointConfigurationFactory { get; set; }

    protected override Humidifier.SES.MailManagerIngressPoint Create()
    {
        var mailManagerIngressPointResult = CreateMailManagerIngressPoint();
        factoryAction?.Invoke(mailManagerIngressPointResult);

        return mailManagerIngressPointResult;
    }

    private Humidifier.SES.MailManagerIngressPoint CreateMailManagerIngressPoint()
    {
        var mailManagerIngressPointResult = new Humidifier.SES.MailManagerIngressPoint
        {
            GivenName = InputResourceName,
        };

        return mailManagerIngressPointResult;
    }
    public override void CreateChildren(Humidifier.SES.MailManagerIngressPoint result)
    {
        base.CreateChildren(result);

        result.IngressPointConfiguration ??= IngressPointConfigurationFactory?.Build();
    }

} // End Of Class

public static class MailManagerIngressPointFactoryExtensions
{
    public static CombinedResult<MailManagerIngressPointFactory, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration(this MailManagerIngressPointFactory parentFactory, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null)
    {
        parentFactory.IngressPointConfigurationFactory = new InnerMailManagerIngressPointIngressPointConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IngressPointConfigurationFactory);
    }

    public static CombinedResult<MailManagerIngressPointFactory, T1, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1>(this CombinedResult<MailManagerIngressPointFactory, T1> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerIngressPointFactory, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1>(this CombinedResult<T1, MailManagerIngressPointFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MailManagerIngressPointFactory, T1, T2, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2>(this CombinedResult<MailManagerIngressPointFactory, T1, T2> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerIngressPointFactory, T2, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2>(this CombinedResult<T1, MailManagerIngressPointFactory, T2> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerIngressPointFactory, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2>(this CombinedResult<T1, T2, MailManagerIngressPointFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MailManagerIngressPointFactory, T1, T2, T3, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2, T3>(this CombinedResult<MailManagerIngressPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerIngressPointFactory, T2, T3, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2, T3>(this CombinedResult<T1, MailManagerIngressPointFactory, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerIngressPointFactory, T3, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, MailManagerIngressPointFactory, T3> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MailManagerIngressPointFactory, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, MailManagerIngressPointFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MailManagerIngressPointFactory, T1, T2, T3, T4, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2, T3, T4>(this CombinedResult<MailManagerIngressPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerIngressPointFactory, T2, T3, T4, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, MailManagerIngressPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerIngressPointFactory, T3, T4, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, MailManagerIngressPointFactory, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MailManagerIngressPointFactory, T4, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MailManagerIngressPointFactory, T4> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MailManagerIngressPointFactory, InnerMailManagerIngressPointIngressPointConfigurationFactory> WithIngressPointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MailManagerIngressPointFactory> combinedResult, Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressPointConfiguration(combinedResult.T5, subFactoryAction));
}
