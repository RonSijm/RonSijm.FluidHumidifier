// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SnapshotBlockPublicAccessFactory(string resourceName = null, Action<Humidifier.EC2.SnapshotBlockPublicAccess> factoryAction = null) : ResourceFactory<Humidifier.EC2.SnapshotBlockPublicAccess>(resourceName)
{

    protected override Humidifier.EC2.SnapshotBlockPublicAccess Create()
    {
        var snapshotBlockPublicAccessResult = CreateSnapshotBlockPublicAccess();
        factoryAction?.Invoke(snapshotBlockPublicAccessResult);

        return snapshotBlockPublicAccessResult;
    }

    private Humidifier.EC2.SnapshotBlockPublicAccess CreateSnapshotBlockPublicAccess()
    {
        var snapshotBlockPublicAccessResult = new Humidifier.EC2.SnapshotBlockPublicAccess
        {
            GivenName = InputResourceName,
        };

        return snapshotBlockPublicAccessResult;
    }

} // End Of Class

public static class SnapshotBlockPublicAccessFactoryExtensions
{
}
