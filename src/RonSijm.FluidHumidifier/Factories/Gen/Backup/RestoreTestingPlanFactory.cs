// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class RestoreTestingPlanFactory(string resourceName = null, Action<Humidifier.Backup.RestoreTestingPlan> factoryAction = null) : ResourceFactory<Humidifier.Backup.RestoreTestingPlan>(resourceName)
{

    internal InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory RecoveryPointSelectionFactory { get; set; }

    protected override Humidifier.Backup.RestoreTestingPlan Create()
    {
        var restoreTestingPlanResult = CreateRestoreTestingPlan();
        factoryAction?.Invoke(restoreTestingPlanResult);

        return restoreTestingPlanResult;
    }

    private Humidifier.Backup.RestoreTestingPlan CreateRestoreTestingPlan()
    {
        var restoreTestingPlanResult = new Humidifier.Backup.RestoreTestingPlan
        {
            GivenName = InputResourceName,
        };

        return restoreTestingPlanResult;
    }
    public override void CreateChildren(Humidifier.Backup.RestoreTestingPlan result)
    {
        base.CreateChildren(result);

        result.RecoveryPointSelection ??= RecoveryPointSelectionFactory?.Build();
    }

} // End Of Class

public static class RestoreTestingPlanFactoryExtensions
{
    public static CombinedResult<RestoreTestingPlanFactory, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection(this RestoreTestingPlanFactory parentFactory, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null)
    {
        parentFactory.RecoveryPointSelectionFactory = new InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecoveryPointSelectionFactory);
    }

    public static CombinedResult<RestoreTestingPlanFactory, T1, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1>(this CombinedResult<RestoreTestingPlanFactory, T1> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestoreTestingPlanFactory, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1>(this CombinedResult<T1, RestoreTestingPlanFactory> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RestoreTestingPlanFactory, T1, T2, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2>(this CombinedResult<RestoreTestingPlanFactory, T1, T2> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestoreTestingPlanFactory, T2, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2>(this CombinedResult<T1, RestoreTestingPlanFactory, T2> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestoreTestingPlanFactory, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2>(this CombinedResult<T1, T2, RestoreTestingPlanFactory> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RestoreTestingPlanFactory, T1, T2, T3, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3>(this CombinedResult<RestoreTestingPlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestoreTestingPlanFactory, T2, T3, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3>(this CombinedResult<T1, RestoreTestingPlanFactory, T2, T3> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestoreTestingPlanFactory, T3, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3>(this CombinedResult<T1, T2, RestoreTestingPlanFactory, T3> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RestoreTestingPlanFactory, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3>(this CombinedResult<T1, T2, T3, RestoreTestingPlanFactory> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RestoreTestingPlanFactory, T1, T2, T3, T4, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3, T4>(this CombinedResult<RestoreTestingPlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestoreTestingPlanFactory, T2, T3, T4, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3, T4>(this CombinedResult<T1, RestoreTestingPlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestoreTestingPlanFactory, T3, T4, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, RestoreTestingPlanFactory, T3, T4> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RestoreTestingPlanFactory, T4, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RestoreTestingPlanFactory, T4> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RestoreTestingPlanFactory, InnerRestoreTestingPlanRestoreTestingRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RestoreTestingPlanFactory> combinedResult, Action<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T5, subFactoryAction));
}
