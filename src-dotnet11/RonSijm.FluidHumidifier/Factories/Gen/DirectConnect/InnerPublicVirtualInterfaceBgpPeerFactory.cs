// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectConnect;

public class InnerPublicVirtualInterfaceBgpPeerFactory(Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> factoryAction = null) : SubResourceFactory<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer>
{

    protected override Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer Create()
    {
        var bgpPeerResult = CreateBgpPeer();
        factoryAction?.Invoke(bgpPeerResult);

        return bgpPeerResult;
    }

    private Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer CreateBgpPeer()
    {
        var bgpPeerResult = new Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer();

        return bgpPeerResult;
    }

} // End Of Class

public static class InnerPublicVirtualInterfaceBgpPeerFactoryExtensions
{
}
