// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointCertificateAuthenticationRequestFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.CertificateAuthenticationRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.CertificateAuthenticationRequest>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.CertificateAuthenticationRequest Create()
    {
        var certificateAuthenticationRequestResult = CreateCertificateAuthenticationRequest();
        factoryAction?.Invoke(certificateAuthenticationRequestResult);

        return certificateAuthenticationRequestResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.CertificateAuthenticationRequest CreateCertificateAuthenticationRequest()
    {
        var certificateAuthenticationRequestResult = new Humidifier.EC2.ClientVpnEndpointTypes.CertificateAuthenticationRequest();

        return certificateAuthenticationRequestResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointCertificateAuthenticationRequestFactoryExtensions
{
}
