// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointMicrosoftSqlServerSettingsFactory(Action<Humidifier.DMS.EndpointTypes.MicrosoftSqlServerSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.MicrosoftSqlServerSettings>
{

    protected override Humidifier.DMS.EndpointTypes.MicrosoftSqlServerSettings Create()
    {
        var microsoftSqlServerSettingsResult = CreateMicrosoftSqlServerSettings();
        factoryAction?.Invoke(microsoftSqlServerSettingsResult);

        return microsoftSqlServerSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.MicrosoftSqlServerSettings CreateMicrosoftSqlServerSettings()
    {
        var microsoftSqlServerSettingsResult = new Humidifier.DMS.EndpointTypes.MicrosoftSqlServerSettings();

        return microsoftSqlServerSettingsResult;
    }

} // End Of Class

public static class InnerEndpointMicrosoftSqlServerSettingsFactoryExtensions
{
}
