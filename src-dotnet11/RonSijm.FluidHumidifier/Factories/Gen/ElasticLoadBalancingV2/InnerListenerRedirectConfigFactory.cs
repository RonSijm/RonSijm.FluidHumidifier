// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRedirectConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.RedirectConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerTypes.RedirectConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerTypes.RedirectConfig Create()
    {
        var redirectConfigResult = CreateRedirectConfig();
        factoryAction?.Invoke(redirectConfigResult);

        return redirectConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerTypes.RedirectConfig CreateRedirectConfig()
    {
        var redirectConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerTypes.RedirectConfig();

        return redirectConfigResult;
    }

} // End Of Class

public static class InnerListenerRedirectConfigFactoryExtensions
{
}
