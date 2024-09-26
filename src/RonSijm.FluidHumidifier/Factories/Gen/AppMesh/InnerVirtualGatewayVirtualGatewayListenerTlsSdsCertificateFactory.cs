// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayVirtualGatewayListenerTlsSdsCertificateFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsSdsCertificate> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsSdsCertificate>
{

    protected override Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsSdsCertificate Create()
    {
        var virtualGatewayListenerTlsSdsCertificateResult = CreateVirtualGatewayListenerTlsSdsCertificate();
        factoryAction?.Invoke(virtualGatewayListenerTlsSdsCertificateResult);

        return virtualGatewayListenerTlsSdsCertificateResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsSdsCertificate CreateVirtualGatewayListenerTlsSdsCertificate()
    {
        var virtualGatewayListenerTlsSdsCertificateResult = new Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsSdsCertificate();

        return virtualGatewayListenerTlsSdsCertificateResult;
    }

} // End Of Class

public static class InnerVirtualGatewayVirtualGatewayListenerTlsSdsCertificateFactoryExtensions
{
}
