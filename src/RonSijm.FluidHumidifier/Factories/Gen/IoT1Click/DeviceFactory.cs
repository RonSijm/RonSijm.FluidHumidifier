// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT1Click;

public class DeviceFactory(string resourceName = null, Action<Humidifier.IoT1Click.Device> factoryAction = null) : ResourceFactory<Humidifier.IoT1Click.Device>(resourceName)
{

    protected override Humidifier.IoT1Click.Device Create()
    {
        var deviceResult = CreateDevice();
        factoryAction?.Invoke(deviceResult);

        return deviceResult;
    }

    private Humidifier.IoT1Click.Device CreateDevice()
    {
        var deviceResult = new Humidifier.IoT1Click.Device
        {
            GivenName = InputResourceName,
        };

        return deviceResult;
    }

} // End Of Class

public static class DeviceFactoryExtensions
{
}
