// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensPrefixLevelFactory(Action<Humidifier.S3.StorageLensTypes.PrefixLevel> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.PrefixLevel>
{

    internal InnerStorageLensPrefixLevelStorageMetricsFactory StorageMetricsFactory { get; set; }

    protected override Humidifier.S3.StorageLensTypes.PrefixLevel Create()
    {
        var prefixLevelResult = CreatePrefixLevel();
        factoryAction?.Invoke(prefixLevelResult);

        return prefixLevelResult;
    }

    private Humidifier.S3.StorageLensTypes.PrefixLevel CreatePrefixLevel()
    {
        var prefixLevelResult = new Humidifier.S3.StorageLensTypes.PrefixLevel();

        return prefixLevelResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLensTypes.PrefixLevel result)
    {
        base.CreateChildren(result);

        result.StorageMetrics ??= StorageMetricsFactory?.Build();
    }

} // End Of Class

public static class InnerStorageLensPrefixLevelFactoryExtensions
{
    public static CombinedResult<InnerStorageLensPrefixLevelFactory, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics(this InnerStorageLensPrefixLevelFactory parentFactory, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null)
    {
        parentFactory.StorageMetricsFactory = new InnerStorageLensPrefixLevelStorageMetricsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageMetricsFactory);
    }

    public static CombinedResult<InnerStorageLensPrefixLevelFactory, T1, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1>(this CombinedResult<InnerStorageLensPrefixLevelFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensPrefixLevelFactory, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1>(this CombinedResult<T1, InnerStorageLensPrefixLevelFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensPrefixLevelFactory, T1, T2, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2>(this CombinedResult<InnerStorageLensPrefixLevelFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensPrefixLevelFactory, T2, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2>(this CombinedResult<T1, InnerStorageLensPrefixLevelFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensPrefixLevelFactory, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensPrefixLevelFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensPrefixLevelFactory, T1, T2, T3, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2, T3>(this CombinedResult<InnerStorageLensPrefixLevelFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensPrefixLevelFactory, T2, T3, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensPrefixLevelFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensPrefixLevelFactory, T3, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensPrefixLevelFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensPrefixLevelFactory, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensPrefixLevelFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensPrefixLevelFactory, T1, T2, T3, T4, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensPrefixLevelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensPrefixLevelFactory, T2, T3, T4, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensPrefixLevelFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensPrefixLevelFactory, T3, T4, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensPrefixLevelFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensPrefixLevelFactory, T4, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensPrefixLevelFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensPrefixLevelFactory, InnerStorageLensPrefixLevelStorageMetricsFactory> WithStorageMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensPrefixLevelFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageMetrics(combinedResult.T5, subFactoryAction));
}
