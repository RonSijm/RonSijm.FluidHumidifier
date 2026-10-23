// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputMulticastSettingsFactory(Action<Humidifier.MediaLive.InputTypes.MulticastSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.MulticastSettings>
{

    protected override Humidifier.MediaLive.InputTypes.MulticastSettings Create()
    {
        var multicastSettingsResult = CreateMulticastSettings();
        factoryAction?.Invoke(multicastSettingsResult);

        return multicastSettingsResult;
    }

    private Humidifier.MediaLive.InputTypes.MulticastSettings CreateMulticastSettings()
    {
        var multicastSettingsResult = new Humidifier.MediaLive.InputTypes.MulticastSettings();

        return multicastSettingsResult;
    }

} // End Of Class

public static class InnerInputMulticastSettingsFactoryExtensions
{
}
