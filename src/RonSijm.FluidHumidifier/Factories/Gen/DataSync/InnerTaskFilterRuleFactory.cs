// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskFilterRuleFactory(Action<Humidifier.DataSync.TaskTypes.FilterRule> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.FilterRule>
{

    protected override Humidifier.DataSync.TaskTypes.FilterRule Create()
    {
        var filterRuleResult = CreateFilterRule();
        factoryAction?.Invoke(filterRuleResult);

        return filterRuleResult;
    }

    private Humidifier.DataSync.TaskTypes.FilterRule CreateFilterRule()
    {
        var filterRuleResult = new Humidifier.DataSync.TaskTypes.FilterRule();

        return filterRuleResult;
    }

} // End Of Class

public static class InnerTaskFilterRuleFactoryExtensions
{
}
