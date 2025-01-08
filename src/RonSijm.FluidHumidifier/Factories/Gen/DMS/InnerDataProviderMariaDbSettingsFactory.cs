// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderMariaDbSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.MariaDbSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.MariaDbSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.MariaDbSettings Create()
    {
        var mariaDbSettingsResult = CreateMariaDbSettings();
        factoryAction?.Invoke(mariaDbSettingsResult);

        return mariaDbSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.MariaDbSettings CreateMariaDbSettings()
    {
        var mariaDbSettingsResult = new Humidifier.DMS.DataProviderTypes.MariaDbSettings();

        return mariaDbSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderMariaDbSettingsFactoryExtensions
{
}
