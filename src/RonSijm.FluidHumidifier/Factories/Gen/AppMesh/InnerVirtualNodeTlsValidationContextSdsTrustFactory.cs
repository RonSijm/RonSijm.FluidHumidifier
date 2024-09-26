// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeTlsValidationContextSdsTrustFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust>
{

    protected override Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust Create()
    {
        var tlsValidationContextSdsTrustResult = CreateTlsValidationContextSdsTrust();
        factoryAction?.Invoke(tlsValidationContextSdsTrustResult);

        return tlsValidationContextSdsTrustResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust CreateTlsValidationContextSdsTrust()
    {
        var tlsValidationContextSdsTrustResult = new Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust();

        return tlsValidationContextSdsTrustResult;
    }

} // End Of Class

public static class InnerVirtualNodeTlsValidationContextSdsTrustFactoryExtensions
{
}
