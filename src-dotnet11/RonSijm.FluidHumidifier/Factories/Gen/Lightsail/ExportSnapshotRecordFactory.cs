// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class ExportSnapshotRecordFactory(string resourceName = null, Action<Humidifier.Lightsail.ExportSnapshotRecord> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.ExportSnapshotRecord>(resourceName)
{

    protected override Humidifier.Lightsail.ExportSnapshotRecord Create()
    {
        var exportSnapshotRecordResult = CreateExportSnapshotRecord();
        factoryAction?.Invoke(exportSnapshotRecordResult);

        return exportSnapshotRecordResult;
    }

    private Humidifier.Lightsail.ExportSnapshotRecord CreateExportSnapshotRecord()
    {
        var exportSnapshotRecordResult = new Humidifier.Lightsail.ExportSnapshotRecord
        {
            GivenName = InputResourceName,
        };

        return exportSnapshotRecordResult;
    }

} // End Of Class

public static class ExportSnapshotRecordFactoryExtensions
{
}
