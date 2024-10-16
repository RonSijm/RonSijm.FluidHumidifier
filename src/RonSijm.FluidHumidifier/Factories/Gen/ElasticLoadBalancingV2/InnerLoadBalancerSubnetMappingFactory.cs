// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerLoadBalancerSubnetMappingFactory(Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping>
{

    protected override Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping Create()
    {
        var subnetMappingResult = CreateSubnetMapping();
        factoryAction?.Invoke(subnetMappingResult);

        return subnetMappingResult;
    }

    private Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping CreateSubnetMapping()
    {
        var subnetMappingResult = new Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping();

        return subnetMappingResult;
    }

} // End Of Class

public static class InnerLoadBalancerSubnetMappingFactoryExtensions
{
}
