// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class LoadBalancerFactory(string resourceName = null, Action<Humidifier.Lightsail.LoadBalancer> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.LoadBalancer>(resourceName)
{

    protected override Humidifier.Lightsail.LoadBalancer Create()
    {
        var loadBalancerResult = CreateLoadBalancer();
        factoryAction?.Invoke(loadBalancerResult);

        return loadBalancerResult;
    }

    private Humidifier.Lightsail.LoadBalancer CreateLoadBalancer()
    {
        var loadBalancerResult = new Humidifier.Lightsail.LoadBalancer
        {
            GivenName = InputResourceName,
        };

        return loadBalancerResult;
    }

} // End Of Class

public static class LoadBalancerFactoryExtensions
{
}
