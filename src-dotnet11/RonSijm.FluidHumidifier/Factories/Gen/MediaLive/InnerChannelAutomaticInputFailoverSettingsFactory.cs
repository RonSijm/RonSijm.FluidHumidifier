// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelAutomaticInputFailoverSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings Create()
    {
        var automaticInputFailoverSettingsResult = CreateAutomaticInputFailoverSettings();
        factoryAction?.Invoke(automaticInputFailoverSettingsResult);

        return automaticInputFailoverSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings CreateAutomaticInputFailoverSettings()
    {
        var automaticInputFailoverSettingsResult = new Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings();

        return automaticInputFailoverSettingsResult;
    }

} // End Of Class

public static class InnerChannelAutomaticInputFailoverSettingsFactoryExtensions
{
}
