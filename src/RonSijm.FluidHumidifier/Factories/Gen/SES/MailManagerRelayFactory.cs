// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class MailManagerRelayFactory(string resourceName = null, Action<Humidifier.SES.MailManagerRelay> factoryAction = null) : ResourceFactory<Humidifier.SES.MailManagerRelay>(resourceName)
{

    internal InnerMailManagerRelayRelayAuthenticationFactory AuthenticationFactory { get; set; }

    protected override Humidifier.SES.MailManagerRelay Create()
    {
        var mailManagerRelayResult = CreateMailManagerRelay();
        factoryAction?.Invoke(mailManagerRelayResult);

        return mailManagerRelayResult;
    }

    private Humidifier.SES.MailManagerRelay CreateMailManagerRelay()
    {
        var mailManagerRelayResult = new Humidifier.SES.MailManagerRelay
        {
            GivenName = InputResourceName,
        };

        return mailManagerRelayResult;
    }
    public override void CreateChildren(Humidifier.SES.MailManagerRelay result)
    {
        base.CreateChildren(result);

        result.Authentication ??= AuthenticationFactory?.Build();
    }

} // End Of Class

public static class MailManagerRelayFactoryExtensions
{
    public static CombinedResult<MailManagerRelayFactory, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication(this MailManagerRelayFactory parentFactory, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null)
    {
        parentFactory.AuthenticationFactory = new InnerMailManagerRelayRelayAuthenticationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthenticationFactory);
    }

    public static CombinedResult<MailManagerRelayFactory, T1, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1>(this CombinedResult<MailManagerRelayFactory, T1> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerRelayFactory, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1>(this CombinedResult<T1, MailManagerRelayFactory> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MailManagerRelayFactory, T1, T2, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2>(this CombinedResult<MailManagerRelayFactory, T1, T2> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerRelayFactory, T2, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2>(this CombinedResult<T1, MailManagerRelayFactory, T2> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerRelayFactory, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2>(this CombinedResult<T1, T2, MailManagerRelayFactory> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MailManagerRelayFactory, T1, T2, T3, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2, T3>(this CombinedResult<MailManagerRelayFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerRelayFactory, T2, T3, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2, T3>(this CombinedResult<T1, MailManagerRelayFactory, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerRelayFactory, T3, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2, T3>(this CombinedResult<T1, T2, MailManagerRelayFactory, T3> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MailManagerRelayFactory, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2, T3>(this CombinedResult<T1, T2, T3, MailManagerRelayFactory> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MailManagerRelayFactory, T1, T2, T3, T4, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2, T3, T4>(this CombinedResult<MailManagerRelayFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerRelayFactory, T2, T3, T4, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, MailManagerRelayFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerRelayFactory, T3, T4, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, MailManagerRelayFactory, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MailManagerRelayFactory, T4, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MailManagerRelayFactory, T4> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MailManagerRelayFactory, InnerMailManagerRelayRelayAuthenticationFactory> WithAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MailManagerRelayFactory> combinedResult, Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthentication(combinedResult.T5, subFactoryAction));
}
