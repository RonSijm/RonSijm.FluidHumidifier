// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelEmptyConfigurationSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings Create()
    {
        var emptyConfigurationSettingsResult = CreateEmptyConfigurationSettings();
        factoryAction?.Invoke(emptyConfigurationSettingsResult);

        return emptyConfigurationSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings CreateEmptyConfigurationSettings()
    {
        var emptyConfigurationSettingsResult = new Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings();

        return emptyConfigurationSettingsResult;
    }

} // End Of Class

public static class InnerChannelEmptyConfigurationSettingsFactoryExtensions
{
}
