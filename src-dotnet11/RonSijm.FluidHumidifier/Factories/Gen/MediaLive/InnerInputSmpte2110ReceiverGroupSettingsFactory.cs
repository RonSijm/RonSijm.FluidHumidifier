// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputSmpte2110ReceiverGroupSettingsFactory(Action<Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroupSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroupSettings>
{

    protected override Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroupSettings Create()
    {
        var smpte2110ReceiverGroupSettingsResult = CreateSmpte2110ReceiverGroupSettings();
        factoryAction?.Invoke(smpte2110ReceiverGroupSettingsResult);

        return smpte2110ReceiverGroupSettingsResult;
    }

    private Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroupSettings CreateSmpte2110ReceiverGroupSettings()
    {
        var smpte2110ReceiverGroupSettingsResult = new Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroupSettings();

        return smpte2110ReceiverGroupSettingsResult;
    }

} // End Of Class

public static class InnerInputSmpte2110ReceiverGroupSettingsFactoryExtensions
{
}
