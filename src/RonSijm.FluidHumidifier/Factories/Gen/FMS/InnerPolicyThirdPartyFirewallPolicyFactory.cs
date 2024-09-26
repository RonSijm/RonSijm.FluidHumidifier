// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class InnerPolicyThirdPartyFirewallPolicyFactory(Action<Humidifier.FMS.PolicyTypes.ThirdPartyFirewallPolicy> factoryAction = null) : SubResourceFactory<Humidifier.FMS.PolicyTypes.ThirdPartyFirewallPolicy>
{

    protected override Humidifier.FMS.PolicyTypes.ThirdPartyFirewallPolicy Create()
    {
        var thirdPartyFirewallPolicyResult = CreateThirdPartyFirewallPolicy();
        factoryAction?.Invoke(thirdPartyFirewallPolicyResult);

        return thirdPartyFirewallPolicyResult;
    }

    private Humidifier.FMS.PolicyTypes.ThirdPartyFirewallPolicy CreateThirdPartyFirewallPolicy()
    {
        var thirdPartyFirewallPolicyResult = new Humidifier.FMS.PolicyTypes.ThirdPartyFirewallPolicy();

        return thirdPartyFirewallPolicyResult;
    }

} // End Of Class

public static class InnerPolicyThirdPartyFirewallPolicyFactoryExtensions
{
}
