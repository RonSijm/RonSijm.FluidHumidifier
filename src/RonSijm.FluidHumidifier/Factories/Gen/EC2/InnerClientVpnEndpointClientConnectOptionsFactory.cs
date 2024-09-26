// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointClientConnectOptionsFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.ClientConnectOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.ClientConnectOptions>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.ClientConnectOptions Create()
    {
        var clientConnectOptionsResult = CreateClientConnectOptions();
        factoryAction?.Invoke(clientConnectOptionsResult);

        return clientConnectOptionsResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.ClientConnectOptions CreateClientConnectOptions()
    {
        var clientConnectOptionsResult = new Humidifier.EC2.ClientVpnEndpointTypes.ClientConnectOptions();

        return clientConnectOptionsResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointClientConnectOptionsFactoryExtensions
{
}
