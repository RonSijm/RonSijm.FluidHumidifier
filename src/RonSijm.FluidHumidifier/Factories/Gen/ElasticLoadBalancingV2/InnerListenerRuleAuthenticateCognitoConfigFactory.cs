// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleAuthenticateCognitoConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateCognitoConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateCognitoConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateCognitoConfig Create()
    {
        var authenticateCognitoConfigResult = CreateAuthenticateCognitoConfig();
        factoryAction?.Invoke(authenticateCognitoConfigResult);

        return authenticateCognitoConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateCognitoConfig CreateAuthenticateCognitoConfig()
    {
        var authenticateCognitoConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateCognitoConfig();

        return authenticateCognitoConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleAuthenticateCognitoConfigFactoryExtensions
{
}
