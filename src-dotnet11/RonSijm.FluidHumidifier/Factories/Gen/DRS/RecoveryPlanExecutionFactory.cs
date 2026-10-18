// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DRS;

public class RecoveryPlanExecutionFactory(string resourceName = null, Action<Humidifier.DRS.RecoveryPlanExecution> factoryAction = null) : ResourceFactory<Humidifier.DRS.RecoveryPlanExecution>(resourceName)
{

    protected override Humidifier.DRS.RecoveryPlanExecution Create()
    {
        var recoveryPlanExecutionResult = CreateRecoveryPlanExecution();
        factoryAction?.Invoke(recoveryPlanExecutionResult);

        return recoveryPlanExecutionResult;
    }

    private Humidifier.DRS.RecoveryPlanExecution CreateRecoveryPlanExecution()
    {
        var recoveryPlanExecutionResult = new Humidifier.DRS.RecoveryPlanExecution
        {
            GivenName = InputResourceName,
        };

        return recoveryPlanExecutionResult;
    }

} // End Of Class

public static class RecoveryPlanExecutionFactoryExtensions
{
}
