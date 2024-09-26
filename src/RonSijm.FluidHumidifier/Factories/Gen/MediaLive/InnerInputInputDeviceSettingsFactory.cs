// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputInputDeviceSettingsFactory(Action<Humidifier.MediaLive.InputTypes.InputDeviceSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.InputDeviceSettings>
{

    protected override Humidifier.MediaLive.InputTypes.InputDeviceSettings Create()
    {
        var inputDeviceSettingsResult = CreateInputDeviceSettings();
        factoryAction?.Invoke(inputDeviceSettingsResult);

        return inputDeviceSettingsResult;
    }

    private Humidifier.MediaLive.InputTypes.InputDeviceSettings CreateInputDeviceSettings()
    {
        var inputDeviceSettingsResult = new Humidifier.MediaLive.InputTypes.InputDeviceSettings();

        return inputDeviceSettingsResult;
    }

} // End Of Class

public static class InnerInputInputDeviceSettingsFactoryExtensions
{
}
