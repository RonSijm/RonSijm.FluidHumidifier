// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class ReservedCacheNodeFactory(string resourceName = null, Action<Humidifier.ElastiCache.ReservedCacheNode> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.ReservedCacheNode>(resourceName)
{

    protected override Humidifier.ElastiCache.ReservedCacheNode Create()
    {
        var reservedCacheNodeResult = CreateReservedCacheNode();
        factoryAction?.Invoke(reservedCacheNodeResult);

        return reservedCacheNodeResult;
    }

    private Humidifier.ElastiCache.ReservedCacheNode CreateReservedCacheNode()
    {
        var reservedCacheNodeResult = new Humidifier.ElastiCache.ReservedCacheNode
        {
            GivenName = InputResourceName,
        };

        return reservedCacheNodeResult;
    }

} // End Of Class

public static class ReservedCacheNodeFactoryExtensions
{
}
