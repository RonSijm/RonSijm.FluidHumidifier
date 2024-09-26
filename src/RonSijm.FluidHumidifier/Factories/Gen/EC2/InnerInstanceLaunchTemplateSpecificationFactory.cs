// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceLaunchTemplateSpecificationFactory(Action<Humidifier.EC2.InstanceTypes.LaunchTemplateSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.LaunchTemplateSpecification>
{

    protected override Humidifier.EC2.InstanceTypes.LaunchTemplateSpecification Create()
    {
        var launchTemplateSpecificationResult = CreateLaunchTemplateSpecification();
        factoryAction?.Invoke(launchTemplateSpecificationResult);

        return launchTemplateSpecificationResult;
    }

    private Humidifier.EC2.InstanceTypes.LaunchTemplateSpecification CreateLaunchTemplateSpecification()
    {
        var launchTemplateSpecificationResult = new Humidifier.EC2.InstanceTypes.LaunchTemplateSpecification();

        return launchTemplateSpecificationResult;
    }

} // End Of Class

public static class InnerInstanceLaunchTemplateSpecificationFactoryExtensions
{
}
