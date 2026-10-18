// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDistributionCacheBehaviorPerPathFactory(Action<Humidifier.Lightsail.DistributionTypes.CacheBehaviorPerPath> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DistributionTypes.CacheBehaviorPerPath>
{

    protected override Humidifier.Lightsail.DistributionTypes.CacheBehaviorPerPath Create()
    {
        var cacheBehaviorPerPathResult = CreateCacheBehaviorPerPath();
        factoryAction?.Invoke(cacheBehaviorPerPathResult);

        return cacheBehaviorPerPathResult;
    }

    private Humidifier.Lightsail.DistributionTypes.CacheBehaviorPerPath CreateCacheBehaviorPerPath()
    {
        var cacheBehaviorPerPathResult = new Humidifier.Lightsail.DistributionTypes.CacheBehaviorPerPath();

        return cacheBehaviorPerPathResult;
    }

} // End Of Class

public static class InnerDistributionCacheBehaviorPerPathFactoryExtensions
{
}
