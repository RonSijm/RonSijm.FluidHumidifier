// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class InnerNFSFileShareCacheAttributesFactory(Action<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes> factoryAction = null) : SubResourceFactory<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes>
{

    protected override Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes Create()
    {
        var cacheAttributesResult = CreateCacheAttributes();
        factoryAction?.Invoke(cacheAttributesResult);

        return cacheAttributesResult;
    }

    private Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes CreateCacheAttributes()
    {
        var cacheAttributesResult = new Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes();

        return cacheAttributesResult;
    }

} // End Of Class

public static class InnerNFSFileShareCacheAttributesFactoryExtensions
{
}
