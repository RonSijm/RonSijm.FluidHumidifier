// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class StorageLensGroupFactory(string resourceName = null, Action<Humidifier.S3.StorageLensGroup> factoryAction = null) : ResourceFactory<Humidifier.S3.StorageLensGroup>(resourceName)
{

    internal InnerStorageLensGroupFilterFactory FilterFactory { get; set; }

    protected override Humidifier.S3.StorageLensGroup Create()
    {
        var storageLensGroupResult = CreateStorageLensGroup();
        factoryAction?.Invoke(storageLensGroupResult);

        return storageLensGroupResult;
    }

    private Humidifier.S3.StorageLensGroup CreateStorageLensGroup()
    {
        var storageLensGroupResult = new Humidifier.S3.StorageLensGroup
        {
            GivenName = InputResourceName,
        };

        return storageLensGroupResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLensGroup result)
    {
        base.CreateChildren(result);

        result.Filter ??= FilterFactory?.Build();
    }

} // End Of Class

public static class StorageLensGroupFactoryExtensions
{
    public static CombinedResult<StorageLensGroupFactory, InnerStorageLensGroupFilterFactory> WithFilter(this StorageLensGroupFactory parentFactory, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null)
    {
        parentFactory.FilterFactory = new InnerStorageLensGroupFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterFactory);
    }

    public static CombinedResult<StorageLensGroupFactory, T1, InnerStorageLensGroupFilterFactory> WithFilter<T1>(this CombinedResult<StorageLensGroupFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageLensGroupFactory, InnerStorageLensGroupFilterFactory> WithFilter<T1>(this CombinedResult<T1, StorageLensGroupFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StorageLensGroupFactory, T1, T2, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2>(this CombinedResult<StorageLensGroupFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageLensGroupFactory, T2, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2>(this CombinedResult<T1, StorageLensGroupFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageLensGroupFactory, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2>(this CombinedResult<T1, T2, StorageLensGroupFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StorageLensGroupFactory, T1, T2, T3, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<StorageLensGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageLensGroupFactory, T2, T3, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<T1, StorageLensGroupFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageLensGroupFactory, T3, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<T1, T2, StorageLensGroupFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageLensGroupFactory, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, StorageLensGroupFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StorageLensGroupFactory, T1, T2, T3, T4, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<StorageLensGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageLensGroupFactory, T2, T3, T4, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, StorageLensGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageLensGroupFactory, T3, T4, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, StorageLensGroupFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageLensGroupFactory, T4, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StorageLensGroupFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StorageLensGroupFactory, InnerStorageLensGroupFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StorageLensGroupFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T5, subFactoryAction));
}
