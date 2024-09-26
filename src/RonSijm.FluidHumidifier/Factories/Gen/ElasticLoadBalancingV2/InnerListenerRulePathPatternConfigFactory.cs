// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRulePathPatternConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.PathPatternConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.PathPatternConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.PathPatternConfig Create()
    {
        var pathPatternConfigResult = CreatePathPatternConfig();
        factoryAction?.Invoke(pathPatternConfigResult);

        return pathPatternConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.PathPatternConfig CreatePathPatternConfig()
    {
        var pathPatternConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.PathPatternConfig();

        return pathPatternConfigResult;
    }

} // End Of Class

public static class InnerListenerRulePathPatternConfigFactoryExtensions
{
}
