// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerChannelExpirationSettingsFactory(Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> factoryAction = null) : SubResourceFactory<Humidifier.Chime.ChannelTypes.ExpirationSettings>
{

    protected override Humidifier.Chime.ChannelTypes.ExpirationSettings Create()
    {
        var expirationSettingsResult = CreateExpirationSettings();
        factoryAction?.Invoke(expirationSettingsResult);

        return expirationSettingsResult;
    }

    private Humidifier.Chime.ChannelTypes.ExpirationSettings CreateExpirationSettings()
    {
        var expirationSettingsResult = new Humidifier.Chime.ChannelTypes.ExpirationSettings();

        return expirationSettingsResult;
    }

} // End Of Class

public static class InnerChannelExpirationSettingsFactoryExtensions
{
}
