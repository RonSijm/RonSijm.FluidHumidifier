// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderOracleSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.OracleSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.OracleSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.OracleSettings Create()
    {
        var oracleSettingsResult = CreateOracleSettings();
        factoryAction?.Invoke(oracleSettingsResult);

        return oracleSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.OracleSettings CreateOracleSettings()
    {
        var oracleSettingsResult = new Humidifier.DMS.DataProviderTypes.OracleSettings();

        return oracleSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderOracleSettingsFactoryExtensions
{
}
