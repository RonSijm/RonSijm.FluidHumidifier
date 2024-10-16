// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class KeyValueStoreFactory(string resourceName = null, Action<Humidifier.CloudFront.KeyValueStore> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.KeyValueStore>(resourceName)
{

    internal InnerKeyValueStoreImportSourceFactory ImportSourceFactory { get; set; }

    protected override Humidifier.CloudFront.KeyValueStore Create()
    {
        var keyValueStoreResult = CreateKeyValueStore();
        factoryAction?.Invoke(keyValueStoreResult);

        return keyValueStoreResult;
    }

    private Humidifier.CloudFront.KeyValueStore CreateKeyValueStore()
    {
        var keyValueStoreResult = new Humidifier.CloudFront.KeyValueStore
        {
            GivenName = InputResourceName,
        };

        return keyValueStoreResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.KeyValueStore result)
    {
        base.CreateChildren(result);

        result.ImportSource ??= ImportSourceFactory?.Build();
    }

} // End Of Class

public static class KeyValueStoreFactoryExtensions
{
    public static CombinedResult<KeyValueStoreFactory, InnerKeyValueStoreImportSourceFactory> WithImportSource(this KeyValueStoreFactory parentFactory, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null)
    {
        parentFactory.ImportSourceFactory = new InnerKeyValueStoreImportSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ImportSourceFactory);
    }

    public static CombinedResult<KeyValueStoreFactory, T1, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1>(this CombinedResult<KeyValueStoreFactory, T1> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithImportSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyValueStoreFactory, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1>(this CombinedResult<T1, KeyValueStoreFactory> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithImportSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<KeyValueStoreFactory, T1, T2, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2>(this CombinedResult<KeyValueStoreFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyValueStoreFactory, T2, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2>(this CombinedResult<T1, KeyValueStoreFactory, T2> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyValueStoreFactory, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2>(this CombinedResult<T1, T2, KeyValueStoreFactory> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<KeyValueStoreFactory, T1, T2, T3, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2, T3>(this CombinedResult<KeyValueStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyValueStoreFactory, T2, T3, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2, T3>(this CombinedResult<T1, KeyValueStoreFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyValueStoreFactory, T3, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2, T3>(this CombinedResult<T1, T2, KeyValueStoreFactory, T3> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KeyValueStoreFactory, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, KeyValueStoreFactory> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<KeyValueStoreFactory, T1, T2, T3, T4, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2, T3, T4>(this CombinedResult<KeyValueStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyValueStoreFactory, T2, T3, T4, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2, T3, T4>(this CombinedResult<T1, KeyValueStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyValueStoreFactory, T3, T4, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, KeyValueStoreFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KeyValueStoreFactory, T4, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, KeyValueStoreFactory, T4> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, KeyValueStoreFactory, InnerKeyValueStoreImportSourceFactory> WithImportSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, KeyValueStoreFactory> combinedResult, Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImportSource(combinedResult.T5, subFactoryAction));
}
