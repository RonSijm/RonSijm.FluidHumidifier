// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerConnectPeerBgpOptionsFactory(Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions>
{

    protected override Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions Create()
    {
        var bgpOptionsResult = CreateBgpOptions();
        factoryAction?.Invoke(bgpOptionsResult);

        return bgpOptionsResult;
    }

    private Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions CreateBgpOptions()
    {
        var bgpOptionsResult = new Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions();

        return bgpOptionsResult;
    }

} // End Of Class

public static class InnerConnectPeerBgpOptionsFactoryExtensions
{
}
