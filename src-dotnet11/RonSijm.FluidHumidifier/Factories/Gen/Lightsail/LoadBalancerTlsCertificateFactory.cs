// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class LoadBalancerTlsCertificateFactory(string resourceName = null, Action<Humidifier.Lightsail.LoadBalancerTlsCertificate> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.LoadBalancerTlsCertificate>(resourceName)
{

    protected override Humidifier.Lightsail.LoadBalancerTlsCertificate Create()
    {
        var loadBalancerTlsCertificateResult = CreateLoadBalancerTlsCertificate();
        factoryAction?.Invoke(loadBalancerTlsCertificateResult);

        return loadBalancerTlsCertificateResult;
    }

    private Humidifier.Lightsail.LoadBalancerTlsCertificate CreateLoadBalancerTlsCertificate()
    {
        var loadBalancerTlsCertificateResult = new Humidifier.Lightsail.LoadBalancerTlsCertificate
        {
            GivenName = InputResourceName,
        };

        return loadBalancerTlsCertificateResult;
    }

} // End Of Class

public static class LoadBalancerTlsCertificateFactoryExtensions
{
}
