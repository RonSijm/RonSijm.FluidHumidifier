// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupIPSetForwardedIPConfigurationFactory(Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration Create()
    {
        var iPSetForwardedIPConfigurationResult = CreateIPSetForwardedIPConfiguration();
        factoryAction?.Invoke(iPSetForwardedIPConfigurationResult);

        return iPSetForwardedIPConfigurationResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration CreateIPSetForwardedIPConfiguration()
    {
        var iPSetForwardedIPConfigurationResult = new Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration();

        return iPSetForwardedIPConfigurationResult;
    }

} // End Of Class

public static class InnerRuleGroupIPSetForwardedIPConfigurationFactoryExtensions
{
}
