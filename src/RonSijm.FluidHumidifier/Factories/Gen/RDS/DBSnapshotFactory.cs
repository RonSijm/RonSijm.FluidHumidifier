// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBSnapshotFactory(string resourceName = null, Action<Humidifier.RDS.DBSnapshot> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBSnapshot>(resourceName)
{

    protected override Humidifier.RDS.DBSnapshot Create()
    {
        var dBSnapshotResult = CreateDBSnapshot();
        factoryAction?.Invoke(dBSnapshotResult);

        return dBSnapshotResult;
    }

    private Humidifier.RDS.DBSnapshot CreateDBSnapshot()
    {
        var dBSnapshotResult = new Humidifier.RDS.DBSnapshot
        {
            GivenName = InputResourceName,
        };

        return dBSnapshotResult;
    }

} // End Of Class

public static class DBSnapshotFactoryExtensions
{
}
