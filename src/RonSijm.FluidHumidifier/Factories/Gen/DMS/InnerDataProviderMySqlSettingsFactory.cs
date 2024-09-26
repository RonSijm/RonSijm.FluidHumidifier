// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderMySqlSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.MySqlSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.MySqlSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.MySqlSettings Create()
    {
        var mySqlSettingsResult = CreateMySqlSettings();
        factoryAction?.Invoke(mySqlSettingsResult);

        return mySqlSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.MySqlSettings CreateMySqlSettings()
    {
        var mySqlSettingsResult = new Humidifier.DMS.DataProviderTypes.MySqlSettings();

        return mySqlSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderMySqlSettingsFactoryExtensions
{
}
