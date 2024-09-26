// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ClientVpnAuthorizationRuleFactory(string resourceName = null, Action<Humidifier.EC2.ClientVpnAuthorizationRule> factoryAction = null) : ResourceFactory<Humidifier.EC2.ClientVpnAuthorizationRule>(resourceName)
{

    protected override Humidifier.EC2.ClientVpnAuthorizationRule Create()
    {
        var clientVpnAuthorizationRuleResult = CreateClientVpnAuthorizationRule();
        factoryAction?.Invoke(clientVpnAuthorizationRuleResult);

        return clientVpnAuthorizationRuleResult;
    }

    private Humidifier.EC2.ClientVpnAuthorizationRule CreateClientVpnAuthorizationRule()
    {
        var clientVpnAuthorizationRuleResult = new Humidifier.EC2.ClientVpnAuthorizationRule
        {
            GivenName = InputResourceName,
        };

        return clientVpnAuthorizationRuleResult;
    }

} // End Of Class

public static class ClientVpnAuthorizationRuleFactoryExtensions
{
}
