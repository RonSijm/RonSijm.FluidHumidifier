// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerNetworkIpPoolFactory(Action<Humidifier.MediaLive.NetworkTypes.IpPool> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.NetworkTypes.IpPool>
{

    protected override Humidifier.MediaLive.NetworkTypes.IpPool Create()
    {
        var ipPoolResult = CreateIpPool();
        factoryAction?.Invoke(ipPoolResult);

        return ipPoolResult;
    }

    private Humidifier.MediaLive.NetworkTypes.IpPool CreateIpPool()
    {
        var ipPoolResult = new Humidifier.MediaLive.NetworkTypes.IpPool();

        return ipPoolResult;
    }

} // End Of Class

public static class InnerNetworkIpPoolFactoryExtensions
{
}
