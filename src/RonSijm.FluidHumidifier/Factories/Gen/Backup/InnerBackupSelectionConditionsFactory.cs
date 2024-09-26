// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerBackupSelectionConditionsFactory(Action<Humidifier.Backup.BackupSelectionTypes.Conditions> factoryAction = null) : SubResourceFactory<Humidifier.Backup.BackupSelectionTypes.Conditions>
{

    protected override Humidifier.Backup.BackupSelectionTypes.Conditions Create()
    {
        var conditionsResult = CreateConditions();
        factoryAction?.Invoke(conditionsResult);

        return conditionsResult;
    }

    private Humidifier.Backup.BackupSelectionTypes.Conditions CreateConditions()
    {
        var conditionsResult = new Humidifier.Backup.BackupSelectionTypes.Conditions();

        return conditionsResult;
    }

} // End Of Class

public static class InnerBackupSelectionConditionsFactoryExtensions
{
}
