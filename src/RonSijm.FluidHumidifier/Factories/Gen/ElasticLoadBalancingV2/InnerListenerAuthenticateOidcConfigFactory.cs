// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerAuthenticateOidcConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateOidcConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateOidcConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateOidcConfig Create()
    {
        var authenticateOidcConfigResult = CreateAuthenticateOidcConfig();
        factoryAction?.Invoke(authenticateOidcConfigResult);

        return authenticateOidcConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateOidcConfig CreateAuthenticateOidcConfig()
    {
        var authenticateOidcConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateOidcConfig();

        return authenticateOidcConfigResult;
    }

} // End Of Class

public static class InnerListenerAuthenticateOidcConfigFactoryExtensions
{
}
