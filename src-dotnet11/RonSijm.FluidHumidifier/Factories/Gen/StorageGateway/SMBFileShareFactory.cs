// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class SMBFileShareFactory(string resourceName = null, Action<Humidifier.StorageGateway.SMBFileShare> factoryAction = null) : ResourceFactory<Humidifier.StorageGateway.SMBFileShare>(resourceName)
{

    internal InnerSMBFileShareCacheAttributesFactory CacheAttributesFactory { get; set; }

    protected override Humidifier.StorageGateway.SMBFileShare Create()
    {
        var sMBFileShareResult = CreateSMBFileShare();
        factoryAction?.Invoke(sMBFileShareResult);

        return sMBFileShareResult;
    }

    private Humidifier.StorageGateway.SMBFileShare CreateSMBFileShare()
    {
        var sMBFileShareResult = new Humidifier.StorageGateway.SMBFileShare
        {
            GivenName = InputResourceName,
        };

        return sMBFileShareResult;
    }
    public override void CreateChildren(Humidifier.StorageGateway.SMBFileShare result)
    {
        base.CreateChildren(result);

        result.CacheAttributes ??= CacheAttributesFactory?.Build();
    }

} // End Of Class

public static class SMBFileShareFactoryExtensions
{
    public static CombinedResult<SMBFileShareFactory, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes(this SMBFileShareFactory parentFactory, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null)
    {
        parentFactory.CacheAttributesFactory = new InnerSMBFileShareCacheAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CacheAttributesFactory);
    }

    public static CombinedResult<SMBFileShareFactory, T1, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1>(this CombinedResult<SMBFileShareFactory, T1> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithCacheAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SMBFileShareFactory, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1>(this CombinedResult<T1, SMBFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithCacheAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SMBFileShareFactory, T1, T2, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2>(this CombinedResult<SMBFileShareFactory, T1, T2> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SMBFileShareFactory, T2, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2>(this CombinedResult<T1, SMBFileShareFactory, T2> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SMBFileShareFactory, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2>(this CombinedResult<T1, T2, SMBFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SMBFileShareFactory, T1, T2, T3, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3>(this CombinedResult<SMBFileShareFactory, T1, T2, T3> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SMBFileShareFactory, T2, T3, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3>(this CombinedResult<T1, SMBFileShareFactory, T2, T3> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SMBFileShareFactory, T3, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3>(this CombinedResult<T1, T2, SMBFileShareFactory, T3> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SMBFileShareFactory, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, SMBFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SMBFileShareFactory, T1, T2, T3, T4, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3, T4>(this CombinedResult<SMBFileShareFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SMBFileShareFactory, T2, T3, T4, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3, T4>(this CombinedResult<T1, SMBFileShareFactory, T2, T3, T4> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SMBFileShareFactory, T3, T4, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, SMBFileShareFactory, T3, T4> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SMBFileShareFactory, T4, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SMBFileShareFactory, T4> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SMBFileShareFactory, InnerSMBFileShareCacheAttributesFactory> WithCacheAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SMBFileShareFactory> combinedResult, Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheAttributes(combinedResult.T5, subFactoryAction).T2);
}
