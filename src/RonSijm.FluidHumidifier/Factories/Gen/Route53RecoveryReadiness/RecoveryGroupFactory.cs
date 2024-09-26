// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryReadiness;

public class RecoveryGroupFactory(string resourceName = null, Action<Humidifier.Route53RecoveryReadiness.RecoveryGroup> factoryAction = null) : ResourceFactory<Humidifier.Route53RecoveryReadiness.RecoveryGroup>(resourceName)
{

    protected override Humidifier.Route53RecoveryReadiness.RecoveryGroup Create()
    {
        var recoveryGroupResult = CreateRecoveryGroup();
        factoryAction?.Invoke(recoveryGroupResult);

        return recoveryGroupResult;
    }

    private Humidifier.Route53RecoveryReadiness.RecoveryGroup CreateRecoveryGroup()
    {
        var recoveryGroupResult = new Humidifier.Route53RecoveryReadiness.RecoveryGroup
        {
            GivenName = InputResourceName,
        };

        return recoveryGroupResult;
    }

} // End Of Class

public static class RecoveryGroupFactoryExtensions
{
}
