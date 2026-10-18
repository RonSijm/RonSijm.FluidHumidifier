// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderRedshiftSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.RedshiftSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.RedshiftSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.RedshiftSettings Create()
    {
        var redshiftSettingsResult = CreateRedshiftSettings();
        factoryAction?.Invoke(redshiftSettingsResult);

        return redshiftSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.RedshiftSettings CreateRedshiftSettings()
    {
        var redshiftSettingsResult = new Humidifier.DMS.DataProviderTypes.RedshiftSettings();

        return redshiftSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderRedshiftSettingsFactoryExtensions
{
}
