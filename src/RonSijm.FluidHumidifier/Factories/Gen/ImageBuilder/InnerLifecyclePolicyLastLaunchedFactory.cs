// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerLifecyclePolicyLastLaunchedFactory(Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched>
{

    protected override Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched Create()
    {
        var lastLaunchedResult = CreateLastLaunched();
        factoryAction?.Invoke(lastLaunchedResult);

        return lastLaunchedResult;
    }

    private Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched CreateLastLaunched()
    {
        var lastLaunchedResult = new Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched();

        return lastLaunchedResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyLastLaunchedFactoryExtensions
{
}
