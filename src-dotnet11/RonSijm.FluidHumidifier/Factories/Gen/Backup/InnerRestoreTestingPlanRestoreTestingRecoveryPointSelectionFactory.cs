// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory(Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> factoryAction = null) : SubResourceFactory<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection>
{

    protected override Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection Create()
    {
        var restoreTestingRecoveryPointSelectionResult = CreateRestoreTestingRecoveryPointSelection();
        factoryAction?.Invoke(restoreTestingRecoveryPointSelectionResult);

        return restoreTestingRecoveryPointSelectionResult;
    }

    private Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection CreateRestoreTestingRecoveryPointSelection()
    {
        var restoreTestingRecoveryPointSelectionResult = new Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection();

        return restoreTestingRecoveryPointSelectionResult;
    }

} // End Of Class

public static class InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactoryExtensions
{
}
