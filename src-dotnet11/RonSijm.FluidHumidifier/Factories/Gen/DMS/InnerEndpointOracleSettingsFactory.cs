// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointOracleSettingsFactory(Action<Humidifier.DMS.EndpointTypes.OracleSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.OracleSettings>
{

    protected override Humidifier.DMS.EndpointTypes.OracleSettings Create()
    {
        var oracleSettingsResult = CreateOracleSettings();
        factoryAction?.Invoke(oracleSettingsResult);

        return oracleSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.OracleSettings CreateOracleSettings()
    {
        var oracleSettingsResult = new Humidifier.DMS.EndpointTypes.OracleSettings();

        return oracleSettingsResult;
    }

} // End Of Class

public static class InnerEndpointOracleSettingsFactoryExtensions
{
}
