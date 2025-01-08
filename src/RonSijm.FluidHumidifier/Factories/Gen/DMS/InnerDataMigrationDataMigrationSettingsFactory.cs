// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataMigrationDataMigrationSettingsFactory(Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings>
{

    protected override Humidifier.DMS.DataMigrationTypes.DataMigrationSettings Create()
    {
        var dataMigrationSettingsResult = CreateDataMigrationSettings();
        factoryAction?.Invoke(dataMigrationSettingsResult);

        return dataMigrationSettingsResult;
    }

    private Humidifier.DMS.DataMigrationTypes.DataMigrationSettings CreateDataMigrationSettings()
    {
        var dataMigrationSettingsResult = new Humidifier.DMS.DataMigrationTypes.DataMigrationSettings();

        return dataMigrationSettingsResult;
    }

} // End Of Class

public static class InnerDataMigrationDataMigrationSettingsFactoryExtensions
{
}
