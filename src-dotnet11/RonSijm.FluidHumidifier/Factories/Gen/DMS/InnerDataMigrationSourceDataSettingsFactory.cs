// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataMigrationSourceDataSettingsFactory(Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataMigrationTypes.SourceDataSettings>
{

    protected override Humidifier.DMS.DataMigrationTypes.SourceDataSettings Create()
    {
        var sourceDataSettingsResult = CreateSourceDataSettings();
        factoryAction?.Invoke(sourceDataSettingsResult);

        return sourceDataSettingsResult;
    }

    private Humidifier.DMS.DataMigrationTypes.SourceDataSettings CreateSourceDataSettings()
    {
        var sourceDataSettingsResult = new Humidifier.DMS.DataMigrationTypes.SourceDataSettings();

        return sourceDataSettingsResult;
    }

} // End Of Class

public static class InnerDataMigrationSourceDataSettingsFactoryExtensions
{
}
