// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointConnectionLogOptionsFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.ConnectionLogOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.ConnectionLogOptions>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.ConnectionLogOptions Create()
    {
        var connectionLogOptionsResult = CreateConnectionLogOptions();
        factoryAction?.Invoke(connectionLogOptionsResult);

        return connectionLogOptionsResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.ConnectionLogOptions CreateConnectionLogOptions()
    {
        var connectionLogOptionsResult = new Humidifier.EC2.ClientVpnEndpointTypes.ConnectionLogOptions();

        return connectionLogOptionsResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointConnectionLogOptionsFactoryExtensions
{
}
