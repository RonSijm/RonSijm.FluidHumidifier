// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerServerlessCacheDataStorageFactory(Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage>
{

    protected override Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage Create()
    {
        var dataStorageResult = CreateDataStorage();
        factoryAction?.Invoke(dataStorageResult);

        return dataStorageResult;
    }

    private Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage CreateDataStorage()
    {
        var dataStorageResult = new Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage();

        return dataStorageResult;
    }

} // End Of Class

public static class InnerServerlessCacheDataStorageFactoryExtensions
{
}
