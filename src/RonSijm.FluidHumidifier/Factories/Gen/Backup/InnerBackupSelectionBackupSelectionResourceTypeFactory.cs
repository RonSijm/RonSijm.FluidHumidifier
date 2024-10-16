// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerBackupSelectionBackupSelectionResourceTypeFactory(Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> factoryAction = null) : SubResourceFactory<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType>
{

    internal InnerBackupSelectionConditionsFactory ConditionsFactory { get; set; }

    protected override Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType Create()
    {
        var backupSelectionResourceTypeResult = CreateBackupSelectionResourceType();
        factoryAction?.Invoke(backupSelectionResourceTypeResult);

        return backupSelectionResourceTypeResult;
    }

    private Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType CreateBackupSelectionResourceType()
    {
        var backupSelectionResourceTypeResult = new Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType();

        return backupSelectionResourceTypeResult;
    }
    public override void CreateChildren(Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType result)
    {
        base.CreateChildren(result);

        result.Conditions ??= ConditionsFactory?.Build();
    }

} // End Of Class

public static class InnerBackupSelectionBackupSelectionResourceTypeFactoryExtensions
{
    public static CombinedResult<InnerBackupSelectionBackupSelectionResourceTypeFactory, InnerBackupSelectionConditionsFactory> WithConditions(this InnerBackupSelectionBackupSelectionResourceTypeFactory parentFactory, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null)
    {
        parentFactory.ConditionsFactory = new InnerBackupSelectionConditionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConditionsFactory);
    }

    public static CombinedResult<InnerBackupSelectionBackupSelectionResourceTypeFactory, T1, InnerBackupSelectionConditionsFactory> WithConditions<T1>(this CombinedResult<InnerBackupSelectionBackupSelectionResourceTypeFactory, T1> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBackupSelectionBackupSelectionResourceTypeFactory, InnerBackupSelectionConditionsFactory> WithConditions<T1>(this CombinedResult<T1, InnerBackupSelectionBackupSelectionResourceTypeFactory> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBackupSelectionBackupSelectionResourceTypeFactory, T1, T2, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2>(this CombinedResult<InnerBackupSelectionBackupSelectionResourceTypeFactory, T1, T2> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBackupSelectionBackupSelectionResourceTypeFactory, T2, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2>(this CombinedResult<T1, InnerBackupSelectionBackupSelectionResourceTypeFactory, T2> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBackupSelectionBackupSelectionResourceTypeFactory, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2>(this CombinedResult<T1, T2, InnerBackupSelectionBackupSelectionResourceTypeFactory> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBackupSelectionBackupSelectionResourceTypeFactory, T1, T2, T3, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2, T3>(this CombinedResult<InnerBackupSelectionBackupSelectionResourceTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBackupSelectionBackupSelectionResourceTypeFactory, T2, T3, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, InnerBackupSelectionBackupSelectionResourceTypeFactory, T2, T3> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBackupSelectionBackupSelectionResourceTypeFactory, T3, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, InnerBackupSelectionBackupSelectionResourceTypeFactory, T3> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBackupSelectionBackupSelectionResourceTypeFactory, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBackupSelectionBackupSelectionResourceTypeFactory> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBackupSelectionBackupSelectionResourceTypeFactory, T1, T2, T3, T4, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<InnerBackupSelectionBackupSelectionResourceTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBackupSelectionBackupSelectionResourceTypeFactory, T2, T3, T4, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, InnerBackupSelectionBackupSelectionResourceTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBackupSelectionBackupSelectionResourceTypeFactory, T3, T4, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBackupSelectionBackupSelectionResourceTypeFactory, T3, T4> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBackupSelectionBackupSelectionResourceTypeFactory, T4, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBackupSelectionBackupSelectionResourceTypeFactory, T4> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBackupSelectionBackupSelectionResourceTypeFactory, InnerBackupSelectionConditionsFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBackupSelectionBackupSelectionResourceTypeFactory> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T5, subFactoryAction));
}
