// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleJwtValidationConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.JwtValidationConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.JwtValidationConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.JwtValidationConfig Create()
    {
        var jwtValidationConfigResult = CreateJwtValidationConfig();
        factoryAction?.Invoke(jwtValidationConfigResult);

        return jwtValidationConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.JwtValidationConfig CreateJwtValidationConfig()
    {
        var jwtValidationConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.JwtValidationConfig();

        return jwtValidationConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleJwtValidationConfigFactoryExtensions
{
}
