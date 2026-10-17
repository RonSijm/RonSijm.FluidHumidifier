// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSecureTunneling;

public class InnerTunnelTimeoutConfigFactory(Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig>
{

    protected override Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig Create()
    {
        var timeoutConfigResult = CreateTimeoutConfig();
        factoryAction?.Invoke(timeoutConfigResult);

        return timeoutConfigResult;
    }

    private Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig CreateTimeoutConfig()
    {
        var timeoutConfigResult = new Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig();

        return timeoutConfigResult;
    }

} // End Of Class

public static class InnerTunnelTimeoutConfigFactoryExtensions
{
}
