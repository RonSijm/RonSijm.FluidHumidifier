// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerFixedResponseConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.FixedResponseConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerTypes.FixedResponseConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerTypes.FixedResponseConfig Create()
    {
        var fixedResponseConfigResult = CreateFixedResponseConfig();
        factoryAction?.Invoke(fixedResponseConfigResult);

        return fixedResponseConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerTypes.FixedResponseConfig CreateFixedResponseConfig()
    {
        var fixedResponseConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerTypes.FixedResponseConfig();

        return fixedResponseConfigResult;
    }

} // End Of Class

public static class InnerListenerFixedResponseConfigFactoryExtensions
{
}
