// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleAuthenticateOidcConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateOidcConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateOidcConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateOidcConfig Create()
    {
        var authenticateOidcConfigResult = CreateAuthenticateOidcConfig();
        factoryAction?.Invoke(authenticateOidcConfigResult);

        return authenticateOidcConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateOidcConfig CreateAuthenticateOidcConfig()
    {
        var authenticateOidcConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateOidcConfig();

        return authenticateOidcConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleAuthenticateOidcConfigFactoryExtensions
{
}
