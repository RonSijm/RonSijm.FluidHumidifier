// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeListenerTlsFileCertificateFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate>
{

    protected override Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate Create()
    {
        var listenerTlsFileCertificateResult = CreateListenerTlsFileCertificate();
        factoryAction?.Invoke(listenerTlsFileCertificateResult);

        return listenerTlsFileCertificateResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate CreateListenerTlsFileCertificate()
    {
        var listenerTlsFileCertificateResult = new Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate();

        return listenerTlsFileCertificateResult;
    }

} // End Of Class

public static class InnerVirtualNodeListenerTlsFileCertificateFactoryExtensions
{
}
