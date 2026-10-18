// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class CollectionGroupFactory(string resourceName = null, Action<Humidifier.OpenSearchServerless.CollectionGroup> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchServerless.CollectionGroup>(resourceName)
{

    internal InnerCollectionGroupCapacityLimitsFactory CapacityLimitsFactory { get; set; }

    protected override Humidifier.OpenSearchServerless.CollectionGroup Create()
    {
        var collectionGroupResult = CreateCollectionGroup();
        factoryAction?.Invoke(collectionGroupResult);

        return collectionGroupResult;
    }

    private Humidifier.OpenSearchServerless.CollectionGroup CreateCollectionGroup()
    {
        var collectionGroupResult = new Humidifier.OpenSearchServerless.CollectionGroup
        {
            GivenName = InputResourceName,
        };

        return collectionGroupResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchServerless.CollectionGroup result)
    {
        base.CreateChildren(result);

        result.CapacityLimits ??= CapacityLimitsFactory?.Build();
    }

} // End Of Class

public static class CollectionGroupFactoryExtensions
{
    public static CombinedResult<CollectionGroupFactory, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits(this CollectionGroupFactory parentFactory, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null)
    {
        parentFactory.CapacityLimitsFactory = new InnerCollectionGroupCapacityLimitsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityLimitsFactory);
    }

    public static CombinedResult<CollectionGroupFactory, T1, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1>(this CombinedResult<CollectionGroupFactory, T1> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionGroupFactory, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1>(this CombinedResult<T1, CollectionGroupFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CollectionGroupFactory, T1, T2, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2>(this CombinedResult<CollectionGroupFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionGroupFactory, T2, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2>(this CombinedResult<T1, CollectionGroupFactory, T2> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CollectionGroupFactory, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2>(this CombinedResult<T1, T2, CollectionGroupFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CollectionGroupFactory, T1, T2, T3, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2, T3>(this CombinedResult<CollectionGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionGroupFactory, T2, T3, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2, T3>(this CombinedResult<T1, CollectionGroupFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CollectionGroupFactory, T3, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2, T3>(this CombinedResult<T1, T2, CollectionGroupFactory, T3> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CollectionGroupFactory, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2, T3>(this CombinedResult<T1, T2, T3, CollectionGroupFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CollectionGroupFactory, T1, T2, T3, T4, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2, T3, T4>(this CombinedResult<CollectionGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionGroupFactory, T2, T3, T4, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2, T3, T4>(this CombinedResult<T1, CollectionGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CollectionGroupFactory, T3, T4, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, CollectionGroupFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CollectionGroupFactory, T4, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CollectionGroupFactory, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CollectionGroupFactory, InnerCollectionGroupCapacityLimitsFactory> WithCapacityLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CollectionGroupFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T5, subFactoryAction).T2);
}
