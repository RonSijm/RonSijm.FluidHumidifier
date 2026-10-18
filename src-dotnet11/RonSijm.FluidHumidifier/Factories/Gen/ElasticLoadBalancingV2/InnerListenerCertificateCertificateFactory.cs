// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerCertificateCertificateFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate();

        return certificateResult;
    }

} // End Of Class

public static class InnerListenerCertificateCertificateFactoryExtensions
{
}
