// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerApplicationMaxAgeRuleFactory(Action<Humidifier.ElasticBeanstalk.ApplicationTypes.MaxAgeRule> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.ApplicationTypes.MaxAgeRule>
{

    protected override Humidifier.ElasticBeanstalk.ApplicationTypes.MaxAgeRule Create()
    {
        var maxAgeRuleResult = CreateMaxAgeRule();
        factoryAction?.Invoke(maxAgeRuleResult);

        return maxAgeRuleResult;
    }

    private Humidifier.ElasticBeanstalk.ApplicationTypes.MaxAgeRule CreateMaxAgeRule()
    {
        var maxAgeRuleResult = new Humidifier.ElasticBeanstalk.ApplicationTypes.MaxAgeRule();

        return maxAgeRuleResult;
    }

} // End Of Class

public static class InnerApplicationMaxAgeRuleFactoryExtensions
{
}
