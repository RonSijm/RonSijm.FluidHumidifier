// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class SnapshotScheduleFactory(string resourceName = null, Action<Humidifier.Redshift.SnapshotSchedule> factoryAction = null) : ResourceFactory<Humidifier.Redshift.SnapshotSchedule>(resourceName)
{

    protected override Humidifier.Redshift.SnapshotSchedule Create()
    {
        var snapshotScheduleResult = CreateSnapshotSchedule();
        factoryAction?.Invoke(snapshotScheduleResult);

        return snapshotScheduleResult;
    }

    private Humidifier.Redshift.SnapshotSchedule CreateSnapshotSchedule()
    {
        var snapshotScheduleResult = new Humidifier.Redshift.SnapshotSchedule
        {
            GivenName = InputResourceName,
        };

        return snapshotScheduleResult;
    }

} // End Of Class

public static class SnapshotScheduleFactoryExtensions
{
}
