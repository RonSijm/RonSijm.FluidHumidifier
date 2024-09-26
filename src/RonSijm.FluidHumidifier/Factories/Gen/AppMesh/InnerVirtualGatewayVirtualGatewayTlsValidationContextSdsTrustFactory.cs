// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayVirtualGatewayTlsValidationContextSdsTrustFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextSdsTrust> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextSdsTrust>
{

    protected override Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextSdsTrust Create()
    {
        var virtualGatewayTlsValidationContextSdsTrustResult = CreateVirtualGatewayTlsValidationContextSdsTrust();
        factoryAction?.Invoke(virtualGatewayTlsValidationContextSdsTrustResult);

        return virtualGatewayTlsValidationContextSdsTrustResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextSdsTrust CreateVirtualGatewayTlsValidationContextSdsTrust()
    {
        var virtualGatewayTlsValidationContextSdsTrustResult = new Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextSdsTrust();

        return virtualGatewayTlsValidationContextSdsTrustResult;
    }

} // End Of Class

public static class InnerVirtualGatewayVirtualGatewayTlsValidationContextSdsTrustFactoryExtensions
{
}
