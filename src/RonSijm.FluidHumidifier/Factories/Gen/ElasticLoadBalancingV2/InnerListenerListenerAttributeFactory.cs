// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerListenerAttributeFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.ListenerAttribute> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerTypes.ListenerAttribute>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerTypes.ListenerAttribute Create()
    {
        var listenerAttributeResult = CreateListenerAttribute();
        factoryAction?.Invoke(listenerAttributeResult);

        return listenerAttributeResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerTypes.ListenerAttribute CreateListenerAttribute()
    {
        var listenerAttributeResult = new Humidifier.ElasticLoadBalancingV2.ListenerTypes.ListenerAttribute();

        return listenerAttributeResult;
    }

} // End Of Class

public static class InnerListenerListenerAttributeFactoryExtensions
{
}
