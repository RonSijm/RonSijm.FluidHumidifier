// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleSourceIpConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.SourceIpConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.SourceIpConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.SourceIpConfig Create()
    {
        var sourceIpConfigResult = CreateSourceIpConfig();
        factoryAction?.Invoke(sourceIpConfigResult);

        return sourceIpConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.SourceIpConfig CreateSourceIpConfig()
    {
        var sourceIpConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.SourceIpConfig();

        return sourceIpConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleSourceIpConfigFactoryExtensions
{
}
