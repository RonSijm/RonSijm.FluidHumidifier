// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InputDeviceFactory(string resourceName = null, Action<Humidifier.MediaLive.InputDevice> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.InputDevice>(resourceName)
{

    protected override Humidifier.MediaLive.InputDevice Create()
    {
        var inputDeviceResult = CreateInputDevice();
        factoryAction?.Invoke(inputDeviceResult);

        return inputDeviceResult;
    }

    private Humidifier.MediaLive.InputDevice CreateInputDevice()
    {
        var inputDeviceResult = new Humidifier.MediaLive.InputDevice
        {
            GivenName = InputResourceName,
        };

        return inputDeviceResult;
    }

} // End Of Class

public static class InputDeviceFactoryExtensions
{
}
