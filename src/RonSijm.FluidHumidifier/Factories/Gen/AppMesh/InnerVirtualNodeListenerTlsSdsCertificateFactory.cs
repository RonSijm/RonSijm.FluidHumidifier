// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeListenerTlsSdsCertificateFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate>
{

    protected override Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate Create()
    {
        var listenerTlsSdsCertificateResult = CreateListenerTlsSdsCertificate();
        factoryAction?.Invoke(listenerTlsSdsCertificateResult);

        return listenerTlsSdsCertificateResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate CreateListenerTlsSdsCertificate()
    {
        var listenerTlsSdsCertificateResult = new Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate();

        return listenerTlsSdsCertificateResult;
    }

} // End Of Class

public static class InnerVirtualNodeListenerTlsSdsCertificateFactoryExtensions
{
}
