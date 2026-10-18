// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerRuleGroupSummaryConfigurationFactory(Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration>
{

    protected override Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration Create()
    {
        var summaryConfigurationResult = CreateSummaryConfiguration();
        factoryAction?.Invoke(summaryConfigurationResult);

        return summaryConfigurationResult;
    }

    private Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration CreateSummaryConfiguration()
    {
        var summaryConfigurationResult = new Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration();

        return summaryConfigurationResult;
    }

} // End Of Class

public static class InnerRuleGroupSummaryConfigurationFactoryExtensions
{
}
