// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class BackupPlanFactory(string resourceName = null, Action<Humidifier.Backup.BackupPlan> factoryAction = null) : ResourceFactory<Humidifier.Backup.BackupPlan>(resourceName)
{

    internal InnerBackupPlanBackupPlanResourceTypeFactory BackupPlan_Factory { get; set; }

    protected override Humidifier.Backup.BackupPlan Create()
    {
        var backupPlanResult = CreateBackupPlan();
        factoryAction?.Invoke(backupPlanResult);

        return backupPlanResult;
    }

    private Humidifier.Backup.BackupPlan CreateBackupPlan()
    {
        var backupPlanResult = new Humidifier.Backup.BackupPlan
        {
            GivenName = InputResourceName,
        };

        return backupPlanResult;
    }
    public override void CreateChildren(Humidifier.Backup.BackupPlan result)
    {
        base.CreateChildren(result);

        result.BackupPlan_ ??= BackupPlan_Factory?.Build();
    }

} // End Of Class

public static class BackupPlanFactoryExtensions
{
    public static CombinedResult<BackupPlanFactory, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_(this BackupPlanFactory parentFactory, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null)
    {
        parentFactory.BackupPlan_Factory = new InnerBackupPlanBackupPlanResourceTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BackupPlan_Factory);
    }

    public static CombinedResult<BackupPlanFactory, T1, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1>(this CombinedResult<BackupPlanFactory, T1> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithBackupPlan_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupPlanFactory, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1>(this CombinedResult<T1, BackupPlanFactory> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithBackupPlan_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BackupPlanFactory, T1, T2, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2>(this CombinedResult<BackupPlanFactory, T1, T2> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupPlanFactory, T2, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2>(this CombinedResult<T1, BackupPlanFactory, T2> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupPlanFactory, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2>(this CombinedResult<T1, T2, BackupPlanFactory> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BackupPlanFactory, T1, T2, T3, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2, T3>(this CombinedResult<BackupPlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupPlanFactory, T2, T3, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2, T3>(this CombinedResult<T1, BackupPlanFactory, T2, T3> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupPlanFactory, T3, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2, T3>(this CombinedResult<T1, T2, BackupPlanFactory, T3> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BackupPlanFactory, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2, T3>(this CombinedResult<T1, T2, T3, BackupPlanFactory> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BackupPlanFactory, T1, T2, T3, T4, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2, T3, T4>(this CombinedResult<BackupPlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupPlanFactory, T2, T3, T4, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2, T3, T4>(this CombinedResult<T1, BackupPlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupPlanFactory, T3, T4, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2, T3, T4>(this CombinedResult<T1, T2, BackupPlanFactory, T3, T4> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BackupPlanFactory, T4, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BackupPlanFactory, T4> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BackupPlanFactory, InnerBackupPlanBackupPlanResourceTypeFactory> WithBackupPlan_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BackupPlanFactory> combinedResult, Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupPlan_(combinedResult.T5, subFactoryAction));
}
