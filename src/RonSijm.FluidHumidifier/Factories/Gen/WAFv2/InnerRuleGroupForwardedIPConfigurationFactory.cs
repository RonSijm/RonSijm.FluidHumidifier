// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupForwardedIPConfigurationFactory(Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration Create()
    {
        var forwardedIPConfigurationResult = CreateForwardedIPConfiguration();
        factoryAction?.Invoke(forwardedIPConfigurationResult);

        return forwardedIPConfigurationResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration CreateForwardedIPConfiguration()
    {
        var forwardedIPConfigurationResult = new Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration();

        return forwardedIPConfigurationResult;
    }

} // End Of Class

public static class InnerRuleGroupForwardedIPConfigurationFactoryExtensions
{
}
