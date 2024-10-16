// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeTlsValidationContextFileTrustFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust>
{

    protected override Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust Create()
    {
        var tlsValidationContextFileTrustResult = CreateTlsValidationContextFileTrust();
        factoryAction?.Invoke(tlsValidationContextFileTrustResult);

        return tlsValidationContextFileTrustResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust CreateTlsValidationContextFileTrust()
    {
        var tlsValidationContextFileTrustResult = new Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust();

        return tlsValidationContextFileTrustResult;
    }

} // End Of Class

public static class InnerVirtualNodeTlsValidationContextFileTrustFactoryExtensions
{
}
