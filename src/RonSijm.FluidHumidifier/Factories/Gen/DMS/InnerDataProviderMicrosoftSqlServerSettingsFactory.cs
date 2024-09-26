// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderMicrosoftSqlServerSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.MicrosoftSqlServerSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.MicrosoftSqlServerSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.MicrosoftSqlServerSettings Create()
    {
        var microsoftSqlServerSettingsResult = CreateMicrosoftSqlServerSettings();
        factoryAction?.Invoke(microsoftSqlServerSettingsResult);

        return microsoftSqlServerSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.MicrosoftSqlServerSettings CreateMicrosoftSqlServerSettings()
    {
        var microsoftSqlServerSettingsResult = new Humidifier.DMS.DataProviderTypes.MicrosoftSqlServerSettings();

        return microsoftSqlServerSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderMicrosoftSqlServerSettingsFactoryExtensions
{
}
