// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class SnapshotFactory(string resourceName = null, Action<Humidifier.FSx.Snapshot> factoryAction = null) : ResourceFactory<Humidifier.FSx.Snapshot>(resourceName)
{

    protected override Humidifier.FSx.Snapshot Create()
    {
        var snapshotResult = CreateSnapshot();
        factoryAction?.Invoke(snapshotResult);

        return snapshotResult;
    }

    private Humidifier.FSx.Snapshot CreateSnapshot()
    {
        var snapshotResult = new Humidifier.FSx.Snapshot
        {
            GivenName = InputResourceName,
        };

        return snapshotResult;
    }

} // End Of Class

public static class SnapshotFactoryExtensions
{
}
