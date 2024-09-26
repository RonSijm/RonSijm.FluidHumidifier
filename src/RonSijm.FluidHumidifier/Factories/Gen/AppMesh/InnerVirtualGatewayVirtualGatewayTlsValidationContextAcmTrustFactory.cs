// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayVirtualGatewayTlsValidationContextAcmTrustFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextAcmTrust> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextAcmTrust>
{

    protected override Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextAcmTrust Create()
    {
        var virtualGatewayTlsValidationContextAcmTrustResult = CreateVirtualGatewayTlsValidationContextAcmTrust();
        factoryAction?.Invoke(virtualGatewayTlsValidationContextAcmTrustResult);

        return virtualGatewayTlsValidationContextAcmTrustResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextAcmTrust CreateVirtualGatewayTlsValidationContextAcmTrust()
    {
        var virtualGatewayTlsValidationContextAcmTrustResult = new Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextAcmTrust();

        return virtualGatewayTlsValidationContextAcmTrustResult;
    }

} // End Of Class

public static class InnerVirtualGatewayVirtualGatewayTlsValidationContextAcmTrustFactoryExtensions
{
}
