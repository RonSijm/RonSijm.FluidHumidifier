// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessEndpointLoadBalancerOptionsFactory(Action<Humidifier.EC2.VerifiedAccessEndpointTypes.LoadBalancerOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessEndpointTypes.LoadBalancerOptions>
{

    protected override Humidifier.EC2.VerifiedAccessEndpointTypes.LoadBalancerOptions Create()
    {
        var loadBalancerOptionsResult = CreateLoadBalancerOptions();
        factoryAction?.Invoke(loadBalancerOptionsResult);

        return loadBalancerOptionsResult;
    }

    private Humidifier.EC2.VerifiedAccessEndpointTypes.LoadBalancerOptions CreateLoadBalancerOptions()
    {
        var loadBalancerOptionsResult = new Humidifier.EC2.VerifiedAccessEndpointTypes.LoadBalancerOptions();

        return loadBalancerOptionsResult;
    }

} // End Of Class

public static class InnerVerifiedAccessEndpointLoadBalancerOptionsFactoryExtensions
{
}
