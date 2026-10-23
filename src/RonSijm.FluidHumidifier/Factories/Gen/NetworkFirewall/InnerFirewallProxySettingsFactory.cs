// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallProxySettingsFactory(Action<Humidifier.NetworkFirewall.FirewallTypes.ProxySettings> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallTypes.ProxySettings>
{

    protected override Humidifier.NetworkFirewall.FirewallTypes.ProxySettings Create()
    {
        var proxySettingsResult = CreateProxySettings();
        factoryAction?.Invoke(proxySettingsResult);

        return proxySettingsResult;
    }

    private Humidifier.NetworkFirewall.FirewallTypes.ProxySettings CreateProxySettings()
    {
        var proxySettingsResult = new Humidifier.NetworkFirewall.FirewallTypes.ProxySettings();

        return proxySettingsResult;
    }

} // End Of Class

public static class InnerFirewallProxySettingsFactoryExtensions
{
}
