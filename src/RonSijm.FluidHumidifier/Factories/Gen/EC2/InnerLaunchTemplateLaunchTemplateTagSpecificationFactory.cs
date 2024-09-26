// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateLaunchTemplateTagSpecificationFactory(Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification Create()
    {
        var launchTemplateTagSpecificationResult = CreateLaunchTemplateTagSpecification();
        factoryAction?.Invoke(launchTemplateTagSpecificationResult);

        return launchTemplateTagSpecificationResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification CreateLaunchTemplateTagSpecification()
    {
        var launchTemplateTagSpecificationResult = new Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification();

        return launchTemplateTagSpecificationResult;
    }

} // End Of Class

public static class InnerLaunchTemplateLaunchTemplateTagSpecificationFactoryExtensions
{
}
