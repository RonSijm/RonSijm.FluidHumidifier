// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerNodegroupLaunchTemplateSpecificationFactory(Action<Humidifier.EKS.NodegroupTypes.LaunchTemplateSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EKS.NodegroupTypes.LaunchTemplateSpecification>
{

    protected override Humidifier.EKS.NodegroupTypes.LaunchTemplateSpecification Create()
    {
        var launchTemplateSpecificationResult = CreateLaunchTemplateSpecification();
        factoryAction?.Invoke(launchTemplateSpecificationResult);

        return launchTemplateSpecificationResult;
    }

    private Humidifier.EKS.NodegroupTypes.LaunchTemplateSpecification CreateLaunchTemplateSpecification()
    {
        var launchTemplateSpecificationResult = new Humidifier.EKS.NodegroupTypes.LaunchTemplateSpecification();

        return launchTemplateSpecificationResult;
    }

} // End Of Class

public static class InnerNodegroupLaunchTemplateSpecificationFactoryExtensions
{
}
