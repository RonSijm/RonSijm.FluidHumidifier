// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DRS;

public class RecoveryInstanceFactory(string resourceName = null, Action<Humidifier.DRS.RecoveryInstance> factoryAction = null) : ResourceFactory<Humidifier.DRS.RecoveryInstance>(resourceName)
{

    protected override Humidifier.DRS.RecoveryInstance Create()
    {
        var recoveryInstanceResult = CreateRecoveryInstance();
        factoryAction?.Invoke(recoveryInstanceResult);

        return recoveryInstanceResult;
    }

    private Humidifier.DRS.RecoveryInstance CreateRecoveryInstance()
    {
        var recoveryInstanceResult = new Humidifier.DRS.RecoveryInstance
        {
            GivenName = InputResourceName,
        };

        return recoveryInstanceResult;
    }

} // End Of Class

public static class RecoveryInstanceFactoryExtensions
{
}
