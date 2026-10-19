// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class NFSFileShareFactory(string resourceName = null, Action<Humidifier.StorageGateway.NFSFileShare> factoryAction = null) : ResourceFactory<Humidifier.StorageGateway.NFSFileShare>(resourceName)
{

    internal InnerNFSFileShareNFSFileShareDefaultsFactory NFSFileShareDefaultsFactory { get; set; }

    internal InnerNFSFileShareCacheAttributesFactory CacheAttributesFactory { get; set; }

    protected override Humidifier.StorageGateway.NFSFileShare Create()
    {
        var nFSFileShareResult = CreateNFSFileShare();
        factoryAction?.Invoke(nFSFileShareResult);

        return nFSFileShareResult;
    }

    private Humidifier.StorageGateway.NFSFileShare CreateNFSFileShare()
    {
        var nFSFileShareResult = new Humidifier.StorageGateway.NFSFileShare
        {
            GivenName = InputResourceName,
        };

        return nFSFileShareResult;
    }
    public override void CreateChildren(Humidifier.StorageGateway.NFSFileShare result)
    {
        base.CreateChildren(result);

        result.NFSFileShareDefaults ??= NFSFileShareDefaultsFactory?.Build();
        result.CacheAttributes ??= CacheAttributesFactory?.Build();
    }

} // End Of Class

public static class NFSFileShareFactoryExtensions
{
    public static CombinedResult<NFSFileShareFactory, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults(this NFSFileShareFactory parentFactory, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null)
    {
        parentFactory.NFSFileShareDefaultsFactory = new InnerNFSFileShareNFSFileShareDefaultsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NFSFileShareDefaultsFactory);
    }

    public static CombinedResult<NFSFileShareFactory, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes(this NFSFileShareFactory parentFactory, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null)
    {
        parentFactory.CacheAttributesFactory = new InnerNFSFileShareCacheAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CacheAttributesFactory);
    }

    public static CombinedResult<NFSFileShareFactory, T1, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1>(this CombinedResult<NFSFileShareFactory, T1> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NFSFileShareFactory, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1>(this CombinedResult<T1, NFSFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<NFSFileShareFactory, T1, T2, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2>(this CombinedResult<NFSFileShareFactory, T1, T2> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NFSFileShareFactory, T2, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2>(this CombinedResult<T1, NFSFileShareFactory, T2> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NFSFileShareFactory, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2>(this CombinedResult<T1, T2, NFSFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<NFSFileShareFactory, T1, T2, T3, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2, T3>(this CombinedResult<NFSFileShareFactory, T1, T2, T3> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NFSFileShareFactory, T2, T3, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2, T3>(this CombinedResult<T1, NFSFileShareFactory, T2, T3> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NFSFileShareFactory, T3, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2, T3>(this CombinedResult<T1, T2, NFSFileShareFactory, T3> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NFSFileShareFactory, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2, T3>(this CombinedResult<T1, T2, T3, NFSFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<NFSFileShareFactory, T1, T2, T3, T4, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2, T3, T4>(this CombinedResult<NFSFileShareFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NFSFileShareFactory, T2, T3, T4, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2, T3, T4>(this CombinedResult<T1, NFSFileShareFactory, T2, T3, T4> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NFSFileShareFactory, T3, T4, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2, T3, T4>(this CombinedResult<T1, T2, NFSFileShareFactory, T3, T4> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NFSFileShareFactory, T4, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NFSFileShareFactory, T4> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, NFSFileShareFactory, InnerNFSFileShareNFSFileShareDefaultsFactory> WithNFSFileShareDefaults<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NFSFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFSFileShareDefaults(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<NFSFileShareFactory, T1, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1>(this CombinedResult<NFSFileShareFactory, T1> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithCacheAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NFSFileShareFactory, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1>(this CombinedResult<T1, NFSFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithCacheAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<NFSFileShareFactory, T1, T2, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2>(this CombinedResult<NFSFileShareFactory, T1, T2> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NFSFileShareFactory, T2, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2>(this CombinedResult<T1, NFSFileShareFactory, T2> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NFSFileShareFactory, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2>(this CombinedResult<T1, T2, NFSFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<NFSFileShareFactory, T1, T2, T3, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3>(this CombinedResult<NFSFileShareFactory, T1, T2, T3> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NFSFileShareFactory, T2, T3, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3>(this CombinedResult<T1, NFSFileShareFactory, T2, T3> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NFSFileShareFactory, T3, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3>(this CombinedResult<T1, T2, NFSFileShareFactory, T3> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NFSFileShareFactory, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, NFSFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<NFSFileShareFactory, T1, T2, T3, T4, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3, T4>(this CombinedResult<NFSFileShareFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NFSFileShareFactory, T2, T3, T4, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3, T4>(this CombinedResult<T1, NFSFileShareFactory, T2, T3, T4> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NFSFileShareFactory, T3, T4, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, NFSFileShareFactory, T3, T4> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NFSFileShareFactory, T4, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NFSFileShareFactory, T4> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, NFSFileShareFactory, InnerNFSFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NFSFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T5, subFactoryAction).T2);
}
