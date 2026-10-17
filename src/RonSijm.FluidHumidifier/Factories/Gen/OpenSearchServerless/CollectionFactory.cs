// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class CollectionFactory(string resourceName = null, Action<Humidifier.OpenSearchServerless.Collection> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchServerless.Collection>(resourceName)
{

    internal InnerCollectionEncryptionConfigFactory EncryptionConfigFactory { get; set; }

    internal InnerCollectionVectorOptionsFactory VectorOptionsFactory { get; set; }

    protected override Humidifier.OpenSearchServerless.Collection Create()
    {
        var collectionResult = CreateCollection();
        factoryAction?.Invoke(collectionResult);

        return collectionResult;
    }

    private Humidifier.OpenSearchServerless.Collection CreateCollection()
    {
        var collectionResult = new Humidifier.OpenSearchServerless.Collection
        {
            GivenName = InputResourceName,
        };

        return collectionResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchServerless.Collection result)
    {
        base.CreateChildren(result);

        result.EncryptionConfig ??= EncryptionConfigFactory?.Build();
        result.VectorOptions ??= VectorOptionsFactory?.Build();
    }

} // End Of Class

public static class CollectionFactoryExtensions
{
    public static CombinedResult<CollectionFactory, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig(this CollectionFactory parentFactory, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigFactory = new InnerCollectionEncryptionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigFactory);
    }

    public static CombinedResult<CollectionFactory, InnerCollectionVectorOptionsFactory> WithVectorOptions(this CollectionFactory parentFactory, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null)
    {
        parentFactory.VectorOptionsFactory = new InnerCollectionVectorOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VectorOptionsFactory);
    }

    public static CombinedResult<CollectionFactory, T1, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1>(this CombinedResult<CollectionFactory, T1> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionFactory, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1>(this CombinedResult<T1, CollectionFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CollectionFactory, T1, T2, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<CollectionFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionFactory, T2, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<T1, CollectionFactory, T2> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CollectionFactory, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<T1, T2, CollectionFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CollectionFactory, T1, T2, T3, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<CollectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionFactory, T2, T3, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, CollectionFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CollectionFactory, T3, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, CollectionFactory, T3> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CollectionFactory, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, CollectionFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CollectionFactory, T1, T2, T3, T4, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<CollectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionFactory, T2, T3, T4, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, CollectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CollectionFactory, T3, T4, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, CollectionFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CollectionFactory, T4, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CollectionFactory, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CollectionFactory, InnerCollectionEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CollectionFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CollectionFactory, T1, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1>(this CombinedResult<CollectionFactory, T1> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithVectorOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionFactory, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1>(this CombinedResult<T1, CollectionFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithVectorOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CollectionFactory, T1, T2, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2>(this CombinedResult<CollectionFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionFactory, T2, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2>(this CombinedResult<T1, CollectionFactory, T2> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CollectionFactory, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2>(this CombinedResult<T1, T2, CollectionFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CollectionFactory, T1, T2, T3, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2, T3>(this CombinedResult<CollectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionFactory, T2, T3, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2, T3>(this CombinedResult<T1, CollectionFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CollectionFactory, T3, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2, T3>(this CombinedResult<T1, T2, CollectionFactory, T3> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CollectionFactory, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, CollectionFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CollectionFactory, T1, T2, T3, T4, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2, T3, T4>(this CombinedResult<CollectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CollectionFactory, T2, T3, T4, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2, T3, T4>(this CombinedResult<T1, CollectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CollectionFactory, T3, T4, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, CollectionFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CollectionFactory, T4, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CollectionFactory, T4> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CollectionFactory, InnerCollectionVectorOptionsFactory> WithVectorOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CollectionFactory> combinedResult, Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorOptions(combinedResult.T5, subFactoryAction).T2);
}
