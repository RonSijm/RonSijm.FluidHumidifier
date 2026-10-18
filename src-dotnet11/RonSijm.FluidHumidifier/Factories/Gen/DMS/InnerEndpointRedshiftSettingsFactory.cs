// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointRedshiftSettingsFactory(Action<Humidifier.DMS.EndpointTypes.RedshiftSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.RedshiftSettings>
{

    protected override Humidifier.DMS.EndpointTypes.RedshiftSettings Create()
    {
        var redshiftSettingsResult = CreateRedshiftSettings();
        factoryAction?.Invoke(redshiftSettingsResult);

        return redshiftSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.RedshiftSettings CreateRedshiftSettings()
    {
        var redshiftSettingsResult = new Humidifier.DMS.EndpointTypes.RedshiftSettings();

        return redshiftSettingsResult;
    }

} // End Of Class

public static class InnerEndpointRedshiftSettingsFactoryExtensions
{
}
