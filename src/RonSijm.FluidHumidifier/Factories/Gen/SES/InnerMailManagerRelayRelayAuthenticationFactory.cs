// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMailManagerRelayRelayAuthenticationFactory(Action<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication> factoryAction = null) : SubResourceFactory<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication>
{

    protected override Humidifier.SES.MailManagerRelayTypes.RelayAuthentication Create()
    {
        var relayAuthenticationResult = CreateRelayAuthentication();
        factoryAction?.Invoke(relayAuthenticationResult);

        return relayAuthenticationResult;
    }

    private Humidifier.SES.MailManagerRelayTypes.RelayAuthentication CreateRelayAuthentication()
    {
        var relayAuthenticationResult = new Humidifier.SES.MailManagerRelayTypes.RelayAuthentication();

        return relayAuthenticationResult;
    }

} // End Of Class

public static class InnerMailManagerRelayRelayAuthenticationFactoryExtensions
{
}
