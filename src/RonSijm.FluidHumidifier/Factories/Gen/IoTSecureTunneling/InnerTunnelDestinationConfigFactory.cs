// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSecureTunneling;

public class InnerTunnelDestinationConfigFactory(Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig>
{

    protected override Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig Create()
    {
        var destinationConfigResult = CreateDestinationConfig();
        factoryAction?.Invoke(destinationConfigResult);

        return destinationConfigResult;
    }

    private Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig CreateDestinationConfig()
    {
        var destinationConfigResult = new Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig();

        return destinationConfigResult;
    }

} // End Of Class

public static class InnerTunnelDestinationConfigFactoryExtensions
{
}
