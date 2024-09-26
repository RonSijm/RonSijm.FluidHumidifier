// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerApplicationMaxCountRuleFactory(Action<Humidifier.ElasticBeanstalk.ApplicationTypes.MaxCountRule> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.ApplicationTypes.MaxCountRule>
{

    protected override Humidifier.ElasticBeanstalk.ApplicationTypes.MaxCountRule Create()
    {
        var maxCountRuleResult = CreateMaxCountRule();
        factoryAction?.Invoke(maxCountRuleResult);

        return maxCountRuleResult;
    }

    private Humidifier.ElasticBeanstalk.ApplicationTypes.MaxCountRule CreateMaxCountRule()
    {
        var maxCountRuleResult = new Humidifier.ElasticBeanstalk.ApplicationTypes.MaxCountRule();

        return maxCountRuleResult;
    }

} // End Of Class

public static class InnerApplicationMaxCountRuleFactoryExtensions
{
}
