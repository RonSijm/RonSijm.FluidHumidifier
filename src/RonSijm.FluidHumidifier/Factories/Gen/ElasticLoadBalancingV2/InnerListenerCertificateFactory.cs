// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerCertificateFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.Certificate> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerTypes.Certificate>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerTypes.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerTypes.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.ElasticLoadBalancingV2.ListenerTypes.Certificate();

        return certificateResult;
    }

} // End Of Class

public static class InnerListenerCertificateFactoryExtensions
{
}
