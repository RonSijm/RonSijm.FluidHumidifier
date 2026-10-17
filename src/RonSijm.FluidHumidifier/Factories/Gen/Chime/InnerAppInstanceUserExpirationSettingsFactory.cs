// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerAppInstanceUserExpirationSettingsFactory(Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> factoryAction = null) : SubResourceFactory<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings>
{

    protected override Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings Create()
    {
        var expirationSettingsResult = CreateExpirationSettings();
        factoryAction?.Invoke(expirationSettingsResult);

        return expirationSettingsResult;
    }

    private Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings CreateExpirationSettings()
    {
        var expirationSettingsResult = new Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings();

        return expirationSettingsResult;
    }

} // End Of Class

public static class InnerAppInstanceUserExpirationSettingsFactoryExtensions
{
}
