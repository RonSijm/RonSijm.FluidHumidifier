// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RedshiftServerless;

public class RecoveryPointFactory(string resourceName = null, Action<Humidifier.RedshiftServerless.RecoveryPoint> factoryAction = null) : ResourceFactory<Humidifier.RedshiftServerless.RecoveryPoint>(resourceName)
{

    protected override Humidifier.RedshiftServerless.RecoveryPoint Create()
    {
        var recoveryPointResult = CreateRecoveryPoint();
        factoryAction?.Invoke(recoveryPointResult);

        return recoveryPointResult;
    }

    private Humidifier.RedshiftServerless.RecoveryPoint CreateRecoveryPoint()
    {
        var recoveryPointResult = new Humidifier.RedshiftServerless.RecoveryPoint
        {
            GivenName = InputResourceName,
        };

        return recoveryPointResult;
    }

} // End Of Class

public static class RecoveryPointFactoryExtensions
{
}
