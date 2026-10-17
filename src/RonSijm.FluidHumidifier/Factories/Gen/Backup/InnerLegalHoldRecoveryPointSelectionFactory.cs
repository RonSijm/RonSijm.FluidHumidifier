// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerLegalHoldRecoveryPointSelectionFactory(Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> factoryAction = null) : SubResourceFactory<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection>
{

    internal InnerLegalHoldDateRangeFactory DateRangeFactory { get; set; }

    protected override Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection Create()
    {
        var recoveryPointSelectionResult = CreateRecoveryPointSelection();
        factoryAction?.Invoke(recoveryPointSelectionResult);

        return recoveryPointSelectionResult;
    }

    private Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection CreateRecoveryPointSelection()
    {
        var recoveryPointSelectionResult = new Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection();

        return recoveryPointSelectionResult;
    }
    public override void CreateChildren(Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection result)
    {
        base.CreateChildren(result);

        result.DateRange ??= DateRangeFactory?.Build();
    }

} // End Of Class

public static class InnerLegalHoldRecoveryPointSelectionFactoryExtensions
{
    public static CombinedResult<InnerLegalHoldRecoveryPointSelectionFactory, InnerLegalHoldDateRangeFactory> WithDateRange(this InnerLegalHoldRecoveryPointSelectionFactory parentFactory, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null)
    {
        parentFactory.DateRangeFactory = new InnerLegalHoldDateRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DateRangeFactory);
    }

    public static CombinedResult<InnerLegalHoldRecoveryPointSelectionFactory, T1, InnerLegalHoldDateRangeFactory> WithDateRange<T1>(this CombinedResult<InnerLegalHoldRecoveryPointSelectionFactory, T1> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithDateRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLegalHoldRecoveryPointSelectionFactory, InnerLegalHoldDateRangeFactory> WithDateRange<T1>(this CombinedResult<T1, InnerLegalHoldRecoveryPointSelectionFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithDateRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLegalHoldRecoveryPointSelectionFactory, T1, T2, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2>(this CombinedResult<InnerLegalHoldRecoveryPointSelectionFactory, T1, T2> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLegalHoldRecoveryPointSelectionFactory, T2, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2>(this CombinedResult<T1, InnerLegalHoldRecoveryPointSelectionFactory, T2> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLegalHoldRecoveryPointSelectionFactory, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2>(this CombinedResult<T1, T2, InnerLegalHoldRecoveryPointSelectionFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLegalHoldRecoveryPointSelectionFactory, T1, T2, T3, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2, T3>(this CombinedResult<InnerLegalHoldRecoveryPointSelectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLegalHoldRecoveryPointSelectionFactory, T2, T3, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2, T3>(this CombinedResult<T1, InnerLegalHoldRecoveryPointSelectionFactory, T2, T3> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLegalHoldRecoveryPointSelectionFactory, T3, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2, T3>(this CombinedResult<T1, T2, InnerLegalHoldRecoveryPointSelectionFactory, T3> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLegalHoldRecoveryPointSelectionFactory, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLegalHoldRecoveryPointSelectionFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLegalHoldRecoveryPointSelectionFactory, T1, T2, T3, T4, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2, T3, T4>(this CombinedResult<InnerLegalHoldRecoveryPointSelectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLegalHoldRecoveryPointSelectionFactory, T2, T3, T4, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2, T3, T4>(this CombinedResult<T1, InnerLegalHoldRecoveryPointSelectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLegalHoldRecoveryPointSelectionFactory, T3, T4, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLegalHoldRecoveryPointSelectionFactory, T3, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLegalHoldRecoveryPointSelectionFactory, T4, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLegalHoldRecoveryPointSelectionFactory, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLegalHoldRecoveryPointSelectionFactory, InnerLegalHoldDateRangeFactory> WithDateRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLegalHoldRecoveryPointSelectionFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.DateRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDateRange(combinedResult.T5, subFactoryAction).T2);
}
