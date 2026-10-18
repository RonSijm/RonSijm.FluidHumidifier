// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConfigRuleScopeFactory(Action<Humidifier.Config.ConfigRuleTypes.Scope> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConfigRuleTypes.Scope>
{

    protected override Humidifier.Config.ConfigRuleTypes.Scope Create()
    {
        var scopeResult = CreateScope();
        factoryAction?.Invoke(scopeResult);

        return scopeResult;
    }

    private Humidifier.Config.ConfigRuleTypes.Scope CreateScope()
    {
        var scopeResult = new Humidifier.Config.ConfigRuleTypes.Scope();

        return scopeResult;
    }

} // End Of Class

public static class InnerConfigRuleScopeFactoryExtensions
{
}
