// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensPrefixLevelStorageMetricsFactory(Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics>
{

    internal InnerStorageLensSelectionCriteriaFactory SelectionCriteriaFactory { get; set; }

    protected override Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics Create()
    {
        var prefixLevelStorageMetricsResult = CreatePrefixLevelStorageMetrics();
        factoryAction?.Invoke(prefixLevelStorageMetricsResult);

        return prefixLevelStorageMetricsResult;
    }

    private Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics CreatePrefixLevelStorageMetrics()
    {
        var prefixLevelStorageMetricsResult = new Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics();

        return prefixLevelStorageMetricsResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics result)
    {
        base.CreateChildren(result);

        result.SelectionCriteria ??= SelectionCriteriaFactory?.Build();
    }

} // End Of Class

public static class InnerStorageLensPrefixLevelStorageMetricsFactoryExtensions
{
    public static CombinedResult<InnerStorageLensPrefixLevelStorageMetricsFactory, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria(this InnerStorageLensPrefixLevelStorageMetricsFactory parentFactory, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null)
    {
        parentFactory.SelectionCriteriaFactory = new InnerStorageLensSelectionCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SelectionCriteriaFactory);
    }

    public static CombinedResult<InnerStorageLensPrefixLevelStorageMetricsFactory, T1, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1>(this CombinedResult<InnerStorageLensPrefixLevelStorageMetricsFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensPrefixLevelStorageMetricsFactory, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1>(this CombinedResult<T1, InnerStorageLensPrefixLevelStorageMetricsFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensPrefixLevelStorageMetricsFactory, T1, T2, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2>(this CombinedResult<InnerStorageLensPrefixLevelStorageMetricsFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensPrefixLevelStorageMetricsFactory, T2, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2>(this CombinedResult<T1, InnerStorageLensPrefixLevelStorageMetricsFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensPrefixLevelStorageMetricsFactory, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensPrefixLevelStorageMetricsFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensPrefixLevelStorageMetricsFactory, T1, T2, T3, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2, T3>(this CombinedResult<InnerStorageLensPrefixLevelStorageMetricsFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensPrefixLevelStorageMetricsFactory, T2, T3, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensPrefixLevelStorageMetricsFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensPrefixLevelStorageMetricsFactory, T3, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensPrefixLevelStorageMetricsFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensPrefixLevelStorageMetricsFactory, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensPrefixLevelStorageMetricsFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensPrefixLevelStorageMetricsFactory, T1, T2, T3, T4, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensPrefixLevelStorageMetricsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensPrefixLevelStorageMetricsFactory, T2, T3, T4, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensPrefixLevelStorageMetricsFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensPrefixLevelStorageMetricsFactory, T3, T4, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensPrefixLevelStorageMetricsFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensPrefixLevelStorageMetricsFactory, T4, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensPrefixLevelStorageMetricsFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensPrefixLevelStorageMetricsFactory, InnerStorageLensSelectionCriteriaFactory> WithSelectionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensPrefixLevelStorageMetricsFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionCriteria(combinedResult.T5, subFactoryAction));
}
