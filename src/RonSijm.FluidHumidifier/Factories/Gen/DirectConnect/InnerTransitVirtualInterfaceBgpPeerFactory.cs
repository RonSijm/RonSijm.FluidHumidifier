// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectConnect;

public class InnerTransitVirtualInterfaceBgpPeerFactory(Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> factoryAction = null) : SubResourceFactory<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer>
{

    protected override Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer Create()
    {
        var bgpPeerResult = CreateBgpPeer();
        factoryAction?.Invoke(bgpPeerResult);

        return bgpPeerResult;
    }

    private Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer CreateBgpPeer()
    {
        var bgpPeerResult = new Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer();

        return bgpPeerResult;
    }

} // End Of Class

public static class InnerTransitVirtualInterfaceBgpPeerFactoryExtensions
{
}
