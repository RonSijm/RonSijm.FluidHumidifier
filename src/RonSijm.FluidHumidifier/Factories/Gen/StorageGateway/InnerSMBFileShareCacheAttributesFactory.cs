// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class InnerSMBFileShareCacheAttributesFactory(Action<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes> factoryAction = null) : SubResourceFactory<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes>
{

    protected override Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes Create()
    {
        var cacheAttributesResult = CreateCacheAttributes();
        factoryAction?.Invoke(cacheAttributesResult);

        return cacheAttributesResult;
    }

    private Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes CreateCacheAttributes()
    {
        var cacheAttributesResult = new Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes();

        return cacheAttributesResult;
    }

} // End Of Class

public static class InnerSMBFileShareCacheAttributesFactoryExtensions
{
}
