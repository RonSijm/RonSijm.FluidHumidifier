// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class ManagedRecoveryPointFactory(string resourceName = null, Action<Humidifier.Backup.ManagedRecoveryPoint> factoryAction = null) : ResourceFactory<Humidifier.Backup.ManagedRecoveryPoint>(resourceName)
{

    protected override Humidifier.Backup.ManagedRecoveryPoint Create()
    {
        var managedRecoveryPointResult = CreateManagedRecoveryPoint();
        factoryAction?.Invoke(managedRecoveryPointResult);

        return managedRecoveryPointResult;
    }

    private Humidifier.Backup.ManagedRecoveryPoint CreateManagedRecoveryPoint()
    {
        var managedRecoveryPointResult = new Humidifier.Backup.ManagedRecoveryPoint
        {
            GivenName = InputResourceName,
        };

        return managedRecoveryPointResult;
    }

} // End Of Class

public static class ManagedRecoveryPointFactoryExtensions
{
}
