// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InfluxDBBackupFactory(string resourceName = null, Action<Humidifier.Timestream.InfluxDBBackup> factoryAction = null) : ResourceFactory<Humidifier.Timestream.InfluxDBBackup>(resourceName)
{

    protected override Humidifier.Timestream.InfluxDBBackup Create()
    {
        var influxDBBackupResult = CreateInfluxDBBackup();
        factoryAction?.Invoke(influxDBBackupResult);

        return influxDBBackupResult;
    }

    private Humidifier.Timestream.InfluxDBBackup CreateInfluxDBBackup()
    {
        var influxDBBackupResult = new Humidifier.Timestream.InfluxDBBackup
        {
            GivenName = InputResourceName,
        };

        return influxDBBackupResult;
    }

} // End Of Class

public static class InfluxDBBackupFactoryExtensions
{
}
