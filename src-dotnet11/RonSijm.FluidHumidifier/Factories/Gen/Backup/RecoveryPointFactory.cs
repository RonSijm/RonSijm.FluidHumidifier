// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class RecoveryPointFactory(string resourceName = null, Action<Humidifier.Backup.RecoveryPoint> factoryAction = null) : ResourceFactory<Humidifier.Backup.RecoveryPoint>(resourceName)
{

    protected override Humidifier.Backup.RecoveryPoint Create()
    {
        var recoveryPointResult = CreateRecoveryPoint();
        factoryAction?.Invoke(recoveryPointResult);

        return recoveryPointResult;
    }

    private Humidifier.Backup.RecoveryPoint CreateRecoveryPoint()
    {
        var recoveryPointResult = new Humidifier.Backup.RecoveryPoint
        {
            GivenName = InputResourceName,
        };

        return recoveryPointResult;
    }

} // End Of Class

public static class RecoveryPointFactoryExtensions
{
}
