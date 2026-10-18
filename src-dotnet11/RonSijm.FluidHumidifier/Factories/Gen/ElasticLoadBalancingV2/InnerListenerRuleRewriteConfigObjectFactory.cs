// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleRewriteConfigObjectFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RewriteConfigObject> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RewriteConfigObject>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RewriteConfigObject Create()
    {
        var rewriteConfigObjectResult = CreateRewriteConfigObject();
        factoryAction?.Invoke(rewriteConfigObjectResult);

        return rewriteConfigObjectResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RewriteConfigObject CreateRewriteConfigObject()
    {
        var rewriteConfigObjectResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RewriteConfigObject();

        return rewriteConfigObjectResult;
    }

} // End Of Class

public static class InnerListenerRuleRewriteConfigObjectFactoryExtensions
{
}
