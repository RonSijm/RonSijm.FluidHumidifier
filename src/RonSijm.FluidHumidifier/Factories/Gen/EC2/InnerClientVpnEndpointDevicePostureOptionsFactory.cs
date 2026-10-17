// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointDevicePostureOptionsFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.DevicePostureOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.DevicePostureOptions>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.DevicePostureOptions Create()
    {
        var devicePostureOptionsResult = CreateDevicePostureOptions();
        factoryAction?.Invoke(devicePostureOptionsResult);

        return devicePostureOptionsResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.DevicePostureOptions CreateDevicePostureOptions()
    {
        var devicePostureOptionsResult = new Humidifier.EC2.ClientVpnEndpointTypes.DevicePostureOptions();

        return devicePostureOptionsResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointDevicePostureOptionsFactoryExtensions
{
}
