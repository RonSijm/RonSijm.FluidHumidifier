// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerMutualAuthenticationFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.MutualAuthentication> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerTypes.MutualAuthentication>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerTypes.MutualAuthentication Create()
    {
        var mutualAuthenticationResult = CreateMutualAuthentication();
        factoryAction?.Invoke(mutualAuthenticationResult);

        return mutualAuthenticationResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerTypes.MutualAuthentication CreateMutualAuthentication()
    {
        var mutualAuthenticationResult = new Humidifier.ElasticLoadBalancingV2.ListenerTypes.MutualAuthentication();

        return mutualAuthenticationResult;
    }

} // End Of Class

public static class InnerListenerMutualAuthenticationFactoryExtensions
{
}
