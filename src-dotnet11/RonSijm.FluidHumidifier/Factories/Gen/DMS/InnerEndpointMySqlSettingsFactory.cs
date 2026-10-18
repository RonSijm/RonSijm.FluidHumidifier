// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointMySqlSettingsFactory(Action<Humidifier.DMS.EndpointTypes.MySqlSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.MySqlSettings>
{

    protected override Humidifier.DMS.EndpointTypes.MySqlSettings Create()
    {
        var mySqlSettingsResult = CreateMySqlSettings();
        factoryAction?.Invoke(mySqlSettingsResult);

        return mySqlSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.MySqlSettings CreateMySqlSettings()
    {
        var mySqlSettingsResult = new Humidifier.DMS.EndpointTypes.MySqlSettings();

        return mySqlSettingsResult;
    }

} // End Of Class

public static class InnerEndpointMySqlSettingsFactoryExtensions
{
}
