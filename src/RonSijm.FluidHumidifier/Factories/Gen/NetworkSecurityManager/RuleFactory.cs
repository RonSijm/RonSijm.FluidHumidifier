// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class RuleFactory(string resourceName = null, Action<Humidifier.NetworkSecurityManager.Rule> factoryAction = null) : ResourceFactory<Humidifier.NetworkSecurityManager.Rule>(resourceName)
{

    protected override Humidifier.NetworkSecurityManager.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.NetworkSecurityManager.Rule CreateRule()
    {
        var ruleResult = new Humidifier.NetworkSecurityManager.Rule
        {
            GivenName = InputResourceName,
        };

        return ruleResult;
    }

} // End Of Class

public static class RuleFactoryExtensions
{
}
