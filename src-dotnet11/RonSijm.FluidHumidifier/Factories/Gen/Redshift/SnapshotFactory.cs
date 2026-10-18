// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class SnapshotFactory(string resourceName = null, Action<Humidifier.Redshift.Snapshot> factoryAction = null) : ResourceFactory<Humidifier.Redshift.Snapshot>(resourceName)
{

    protected override Humidifier.Redshift.Snapshot Create()
    {
        var snapshotResult = CreateSnapshot();
        factoryAction?.Invoke(snapshotResult);

        return snapshotResult;
    }

    private Humidifier.Redshift.Snapshot CreateSnapshot()
    {
        var snapshotResult = new Humidifier.Redshift.Snapshot
        {
            GivenName = InputResourceName,
        };

        return snapshotResult;
    }

} // End Of Class

public static class SnapshotFactoryExtensions
{
}
