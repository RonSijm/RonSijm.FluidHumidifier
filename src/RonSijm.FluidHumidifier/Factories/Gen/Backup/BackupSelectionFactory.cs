// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class BackupSelectionFactory(string resourceName = null, Action<Humidifier.Backup.BackupSelection> factoryAction = null) : ResourceFactory<Humidifier.Backup.BackupSelection>(resourceName)
{

    internal InnerBackupSelectionBackupSelectionResourceTypeFactory BackupSelection_Factory { get; set; }

    protected override Humidifier.Backup.BackupSelection Create()
    {
        var backupSelectionResult = CreateBackupSelection();
        factoryAction?.Invoke(backupSelectionResult);

        return backupSelectionResult;
    }

    private Humidifier.Backup.BackupSelection CreateBackupSelection()
    {
        var backupSelectionResult = new Humidifier.Backup.BackupSelection
        {
            GivenName = InputResourceName,
        };

        return backupSelectionResult;
    }
    public override void CreateChildren(Humidifier.Backup.BackupSelection result)
    {
        base.CreateChildren(result);

        result.BackupSelection_ ??= BackupSelection_Factory?.Build();
    }

} // End Of Class

public static class BackupSelectionFactoryExtensions
{
    public static CombinedResult<BackupSelectionFactory, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_(this BackupSelectionFactory parentFactory, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null)
    {
        parentFactory.BackupSelection_Factory = new InnerBackupSelectionBackupSelectionResourceTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BackupSelection_Factory);
    }

    public static CombinedResult<BackupSelectionFactory, T1, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1>(this CombinedResult<BackupSelectionFactory, T1> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithBackupSelection_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupSelectionFactory, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1>(this CombinedResult<T1, BackupSelectionFactory> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithBackupSelection_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BackupSelectionFactory, T1, T2, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2>(this CombinedResult<BackupSelectionFactory, T1, T2> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupSelectionFactory, T2, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2>(this CombinedResult<T1, BackupSelectionFactory, T2> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupSelectionFactory, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2>(this CombinedResult<T1, T2, BackupSelectionFactory> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BackupSelectionFactory, T1, T2, T3, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2, T3>(this CombinedResult<BackupSelectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupSelectionFactory, T2, T3, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2, T3>(this CombinedResult<T1, BackupSelectionFactory, T2, T3> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupSelectionFactory, T3, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2, T3>(this CombinedResult<T1, T2, BackupSelectionFactory, T3> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BackupSelectionFactory, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2, T3>(this CombinedResult<T1, T2, T3, BackupSelectionFactory> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BackupSelectionFactory, T1, T2, T3, T4, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2, T3, T4>(this CombinedResult<BackupSelectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupSelectionFactory, T2, T3, T4, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2, T3, T4>(this CombinedResult<T1, BackupSelectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupSelectionFactory, T3, T4, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2, T3, T4>(this CombinedResult<T1, T2, BackupSelectionFactory, T3, T4> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BackupSelectionFactory, T4, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BackupSelectionFactory, T4> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BackupSelectionFactory, InnerBackupSelectionBackupSelectionResourceTypeFactory> WithBackupSelection_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BackupSelectionFactory> combinedResult, Action<Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupSelection_(combinedResult.T5, subFactoryAction));
}
