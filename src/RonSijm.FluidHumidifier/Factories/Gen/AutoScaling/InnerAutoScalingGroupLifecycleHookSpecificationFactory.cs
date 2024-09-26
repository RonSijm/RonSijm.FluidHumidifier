// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupLifecycleHookSpecificationFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LifecycleHookSpecification> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.LifecycleHookSpecification>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.LifecycleHookSpecification Create()
    {
        var lifecycleHookSpecificationResult = CreateLifecycleHookSpecification();
        factoryAction?.Invoke(lifecycleHookSpecificationResult);

        return lifecycleHookSpecificationResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.LifecycleHookSpecification CreateLifecycleHookSpecification()
    {
        var lifecycleHookSpecificationResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.LifecycleHookSpecification();

        return lifecycleHookSpecificationResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupLifecycleHookSpecificationFactoryExtensions
{
}
