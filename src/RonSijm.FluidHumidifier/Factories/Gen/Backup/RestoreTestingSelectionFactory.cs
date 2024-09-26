// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class RestoreTestingSelectionFactory(string resourceName = null, Action<Humidifier.Backup.RestoreTestingSelection> factoryAction = null) : ResourceFactory<Humidifier.Backup.RestoreTestingSelection>(resourceName)
{

    internal InnerRestoreTestingSelectionProtectedResourceConditionsFactory ProtectedResourceConditionsFactory { get; set; }

    protected override Humidifier.Backup.RestoreTestingSelection Create()
    {
        var restoreTestingSelectionResult = CreateRestoreTestingSelection();
        factoryAction?.Invoke(restoreTestingSelectionResult);

        return restoreTestingSelectionResult;
    }

    private Humidifier.Backup.RestoreTestingSelection CreateRestoreTestingSelection()
    {
        var restoreTestingSelectionResult = new Humidifier.Backup.RestoreTestingSelection
        {
            GivenName = InputResourceName,
        };

        return restoreTestingSelectionResult;
    }
    public override void CreateChildren(Humidifier.Backup.RestoreTestingSelection result)
    {
        base.CreateChildren(result);

        result.ProtectedResourceConditions ??= ProtectedResourceConditionsFactory?.Build();
    }

} // End Of Class

public static class RestoreTestingSelectionFactoryExtensions
{
    public static CombinedResult<RestoreTestingSelectionFactory, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions(this RestoreTestingSelectionFactory parentFactory, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null)
    {
        parentFactory.ProtectedResourceConditionsFactory = new InnerRestoreTestingSelectionProtectedResourceConditionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProtectedResourceConditionsFactory);
    }

    public static CombinedResult<RestoreTestingSelectionFactory, T1, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1>(this CombinedResult<RestoreTestingSelectionFactory, T1> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestoreTestingSelectionFactory, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1>(this CombinedResult<T1, RestoreTestingSelectionFactory> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RestoreTestingSelectionFactory, T1, T2, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2>(this CombinedResult<RestoreTestingSelectionFactory, T1, T2> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestoreTestingSelectionFactory, T2, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2>(this CombinedResult<T1, RestoreTestingSelectionFactory, T2> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestoreTestingSelectionFactory, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2>(this CombinedResult<T1, T2, RestoreTestingSelectionFactory> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RestoreTestingSelectionFactory, T1, T2, T3, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2, T3>(this CombinedResult<RestoreTestingSelectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestoreTestingSelectionFactory, T2, T3, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2, T3>(this CombinedResult<T1, RestoreTestingSelectionFactory, T2, T3> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestoreTestingSelectionFactory, T3, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2, T3>(this CombinedResult<T1, T2, RestoreTestingSelectionFactory, T3> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RestoreTestingSelectionFactory, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2, T3>(this CombinedResult<T1, T2, T3, RestoreTestingSelectionFactory> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RestoreTestingSelectionFactory, T1, T2, T3, T4, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2, T3, T4>(this CombinedResult<RestoreTestingSelectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestoreTestingSelectionFactory, T2, T3, T4, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2, T3, T4>(this CombinedResult<T1, RestoreTestingSelectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestoreTestingSelectionFactory, T3, T4, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, RestoreTestingSelectionFactory, T3, T4> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RestoreTestingSelectionFactory, T4, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RestoreTestingSelectionFactory, T4> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RestoreTestingSelectionFactory, InnerRestoreTestingSelectionProtectedResourceConditionsFactory> WithProtectedResourceConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RestoreTestingSelectionFactory> combinedResult, Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtectedResourceConditions(combinedResult.T5, subFactoryAction));
}
