// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayVirtualGatewayTlsValidationContextFileTrustFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextFileTrust> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextFileTrust>
{

    protected override Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextFileTrust Create()
    {
        var virtualGatewayTlsValidationContextFileTrustResult = CreateVirtualGatewayTlsValidationContextFileTrust();
        factoryAction?.Invoke(virtualGatewayTlsValidationContextFileTrustResult);

        return virtualGatewayTlsValidationContextFileTrustResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextFileTrust CreateVirtualGatewayTlsValidationContextFileTrust()
    {
        var virtualGatewayTlsValidationContextFileTrustResult = new Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextFileTrust();

        return virtualGatewayTlsValidationContextFileTrustResult;
    }

} // End Of Class

public static class InnerVirtualGatewayVirtualGatewayTlsValidationContextFileTrustFactoryExtensions
{
}
