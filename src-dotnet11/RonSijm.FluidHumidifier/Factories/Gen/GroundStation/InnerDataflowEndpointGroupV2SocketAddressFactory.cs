// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupV2SocketAddressFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress>
{

    protected override Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress Create()
    {
        var socketAddressResult = CreateSocketAddress();
        factoryAction?.Invoke(socketAddressResult);

        return socketAddressResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress CreateSocketAddress()
    {
        var socketAddressResult = new Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress();

        return socketAddressResult;
    }

} // End Of Class

public static class InnerDataflowEndpointGroupV2SocketAddressFactoryExtensions
{
}
