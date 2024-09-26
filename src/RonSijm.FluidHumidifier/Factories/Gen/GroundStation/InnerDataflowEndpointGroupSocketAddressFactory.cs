// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupSocketAddressFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress>
{

    protected override Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress Create()
    {
        var socketAddressResult = CreateSocketAddress();
        factoryAction?.Invoke(socketAddressResult);

        return socketAddressResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress CreateSocketAddress()
    {
        var socketAddressResult = new Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress();

        return socketAddressResult;
    }

} // End Of Class

public static class InnerDataflowEndpointGroupSocketAddressFactoryExtensions
{
}
