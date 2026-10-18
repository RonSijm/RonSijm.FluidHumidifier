// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupLaunchTemplateSpecificationFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification Create()
    {
        var launchTemplateSpecificationResult = CreateLaunchTemplateSpecification();
        factoryAction?.Invoke(launchTemplateSpecificationResult);

        return launchTemplateSpecificationResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification CreateLaunchTemplateSpecification()
    {
        var launchTemplateSpecificationResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification();

        return launchTemplateSpecificationResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupLaunchTemplateSpecificationFactoryExtensions
{
}
