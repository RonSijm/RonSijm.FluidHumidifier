// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerAuthenticateCognitoConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateCognitoConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateCognitoConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateCognitoConfig Create()
    {
        var authenticateCognitoConfigResult = CreateAuthenticateCognitoConfig();
        factoryAction?.Invoke(authenticateCognitoConfigResult);

        return authenticateCognitoConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateCognitoConfig CreateAuthenticateCognitoConfig()
    {
        var authenticateCognitoConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateCognitoConfig();

        return authenticateCognitoConfigResult;
    }

} // End Of Class

public static class InnerListenerAuthenticateCognitoConfigFactoryExtensions
{
}
