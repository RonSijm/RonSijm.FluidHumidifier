// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDistributionCacheBehaviorFactory(Action<Humidifier.Lightsail.DistributionTypes.CacheBehavior> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DistributionTypes.CacheBehavior>
{

    protected override Humidifier.Lightsail.DistributionTypes.CacheBehavior Create()
    {
        var cacheBehaviorResult = CreateCacheBehavior();
        factoryAction?.Invoke(cacheBehaviorResult);

        return cacheBehaviorResult;
    }

    private Humidifier.Lightsail.DistributionTypes.CacheBehavior CreateCacheBehavior()
    {
        var cacheBehaviorResult = new Humidifier.Lightsail.DistributionTypes.CacheBehavior();

        return cacheBehaviorResult;
    }

} // End Of Class

public static class InnerDistributionCacheBehaviorFactoryExtensions
{
}
