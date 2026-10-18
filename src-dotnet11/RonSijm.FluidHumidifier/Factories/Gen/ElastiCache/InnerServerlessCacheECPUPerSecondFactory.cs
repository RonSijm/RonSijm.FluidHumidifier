// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerServerlessCacheECPUPerSecondFactory(Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond>
{

    protected override Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond Create()
    {
        var eCPUPerSecondResult = CreateECPUPerSecond();
        factoryAction?.Invoke(eCPUPerSecondResult);

        return eCPUPerSecondResult;
    }

    private Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond CreateECPUPerSecond()
    {
        var eCPUPerSecondResult = new Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond();

        return eCPUPerSecondResult;
    }

} // End Of Class

public static class InnerServerlessCacheECPUPerSecondFactoryExtensions
{
}
