// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class SnapshotCopyGrantFactory(string resourceName = null, Action<Humidifier.Redshift.SnapshotCopyGrant> factoryAction = null) : ResourceFactory<Humidifier.Redshift.SnapshotCopyGrant>(resourceName)
{

    protected override Humidifier.Redshift.SnapshotCopyGrant Create()
    {
        var snapshotCopyGrantResult = CreateSnapshotCopyGrant();
        factoryAction?.Invoke(snapshotCopyGrantResult);

        return snapshotCopyGrantResult;
    }

    private Humidifier.Redshift.SnapshotCopyGrant CreateSnapshotCopyGrant()
    {
        var snapshotCopyGrantResult = new Humidifier.Redshift.SnapshotCopyGrant
        {
            GivenName = InputResourceName,
        };

        return snapshotCopyGrantResult;
    }

} // End Of Class

public static class SnapshotCopyGrantFactoryExtensions
{
}
