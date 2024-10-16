// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancing;

public class InnerLoadBalancerListenersFactory(Action<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Listeners> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Listeners>
{

    protected override Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Listeners Create()
    {
        var listenersResult = CreateListeners();
        factoryAction?.Invoke(listenersResult);

        return listenersResult;
    }

    private Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Listeners CreateListeners()
    {
        var listenersResult = new Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Listeners();

        return listenersResult;
    }

} // End Of Class

public static class InnerLoadBalancerListenersFactoryExtensions
{
}
