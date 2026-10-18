// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DRS;

public class RecoveryPlanFactory(string resourceName = null, Action<Humidifier.DRS.RecoveryPlan> factoryAction = null) : ResourceFactory<Humidifier.DRS.RecoveryPlan>(resourceName)
{

    protected override Humidifier.DRS.RecoveryPlan Create()
    {
        var recoveryPlanResult = CreateRecoveryPlan();
        factoryAction?.Invoke(recoveryPlanResult);

        return recoveryPlanResult;
    }

    private Humidifier.DRS.RecoveryPlan CreateRecoveryPlan()
    {
        var recoveryPlanResult = new Humidifier.DRS.RecoveryPlan
        {
            GivenName = InputResourceName,
        };

        return recoveryPlanResult;
    }

} // End Of Class

public static class RecoveryPlanFactoryExtensions
{
}
