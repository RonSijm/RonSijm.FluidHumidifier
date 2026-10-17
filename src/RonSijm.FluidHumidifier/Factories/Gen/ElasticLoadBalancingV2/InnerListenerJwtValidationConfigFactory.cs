// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerJwtValidationConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.JwtValidationConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerTypes.JwtValidationConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerTypes.JwtValidationConfig Create()
    {
        var jwtValidationConfigResult = CreateJwtValidationConfig();
        factoryAction?.Invoke(jwtValidationConfigResult);

        return jwtValidationConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerTypes.JwtValidationConfig CreateJwtValidationConfig()
    {
        var jwtValidationConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerTypes.JwtValidationConfig();

        return jwtValidationConfigResult;
    }

} // End Of Class

public static class InnerListenerJwtValidationConfigFactoryExtensions
{
}
