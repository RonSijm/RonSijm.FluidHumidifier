// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectConnect;

public class InnerPrivateVirtualInterfaceBgpPeerFactory(Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> factoryAction = null) : SubResourceFactory<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer>
{

    protected override Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer Create()
    {
        var bgpPeerResult = CreateBgpPeer();
        factoryAction?.Invoke(bgpPeerResult);

        return bgpPeerResult;
    }

    private Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer CreateBgpPeer()
    {
        var bgpPeerResult = new Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer();

        return bgpPeerResult;
    }

} // End Of Class

public static class InnerPrivateVirtualInterfaceBgpPeerFactoryExtensions
{
}
