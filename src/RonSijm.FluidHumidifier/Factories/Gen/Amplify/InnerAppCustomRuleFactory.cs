// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerAppCustomRuleFactory(Action<Humidifier.Amplify.AppTypes.CustomRule> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.AppTypes.CustomRule>
{

    protected override Humidifier.Amplify.AppTypes.CustomRule Create()
    {
        var customRuleResult = CreateCustomRule();
        factoryAction?.Invoke(customRuleResult);

        return customRuleResult;
    }

    private Humidifier.Amplify.AppTypes.CustomRule CreateCustomRule()
    {
        var customRuleResult = new Humidifier.Amplify.AppTypes.CustomRule();

        return customRuleResult;
    }

} // End Of Class

public static class InnerAppCustomRuleFactoryExtensions
{
}
