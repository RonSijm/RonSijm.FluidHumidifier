// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayVirtualGatewayListenerTlsFileCertificateFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsFileCertificate> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsFileCertificate>
{

    protected override Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsFileCertificate Create()
    {
        var virtualGatewayListenerTlsFileCertificateResult = CreateVirtualGatewayListenerTlsFileCertificate();
        factoryAction?.Invoke(virtualGatewayListenerTlsFileCertificateResult);

        return virtualGatewayListenerTlsFileCertificateResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsFileCertificate CreateVirtualGatewayListenerTlsFileCertificate()
    {
        var virtualGatewayListenerTlsFileCertificateResult = new Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsFileCertificate();

        return virtualGatewayListenerTlsFileCertificateResult;
    }

} // End Of Class

public static class InnerVirtualGatewayVirtualGatewayListenerTlsFileCertificateFactoryExtensions
{
}
