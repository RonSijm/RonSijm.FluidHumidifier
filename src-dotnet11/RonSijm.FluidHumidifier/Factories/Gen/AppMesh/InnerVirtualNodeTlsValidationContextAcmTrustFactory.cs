// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeTlsValidationContextAcmTrustFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust>
{

    protected override Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust Create()
    {
        var tlsValidationContextAcmTrustResult = CreateTlsValidationContextAcmTrust();
        factoryAction?.Invoke(tlsValidationContextAcmTrustResult);

        return tlsValidationContextAcmTrustResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust CreateTlsValidationContextAcmTrust()
    {
        var tlsValidationContextAcmTrustResult = new Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust();

        return tlsValidationContextAcmTrustResult;
    }

} // End Of Class

public static class InnerVirtualNodeTlsValidationContextAcmTrustFactoryExtensions
{
}
