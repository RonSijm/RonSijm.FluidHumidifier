// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class InnerIpAccessSettingsIpRuleFactory(Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule>
{

    protected override Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule Create()
    {
        var ipRuleResult = CreateIpRule();
        factoryAction?.Invoke(ipRuleResult);

        return ipRuleResult;
    }

    private Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule CreateIpRule()
    {
        var ipRuleResult = new Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule();

        return ipRuleResult;
    }

} // End Of Class

public static class InnerIpAccessSettingsIpRuleFactoryExtensions
{
}
