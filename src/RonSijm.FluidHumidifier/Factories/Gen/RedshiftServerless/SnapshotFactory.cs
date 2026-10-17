// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RedshiftServerless;

public class SnapshotFactory(string resourceName = null, Action<Humidifier.RedshiftServerless.Snapshot> factoryAction = null) : ResourceFactory<Humidifier.RedshiftServerless.Snapshot>(resourceName)
{

    protected override Humidifier.RedshiftServerless.Snapshot Create()
    {
        var snapshotResult = CreateSnapshot();
        factoryAction?.Invoke(snapshotResult);

        return snapshotResult;
    }

    private Humidifier.RedshiftServerless.Snapshot CreateSnapshot()
    {
        var snapshotResult = new Humidifier.RedshiftServerless.Snapshot
        {
            GivenName = InputResourceName,
        };

        return snapshotResult;
    }

} // End Of Class

public static class SnapshotFactoryExtensions
{
}
