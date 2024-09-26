// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentLaunchTemplateSpecificationFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification Create()
    {
        var launchTemplateSpecificationResult = CreateLaunchTemplateSpecification();
        factoryAction?.Invoke(launchTemplateSpecificationResult);

        return launchTemplateSpecificationResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification CreateLaunchTemplateSpecification()
    {
        var launchTemplateSpecificationResult = new Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification();

        return launchTemplateSpecificationResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentLaunchTemplateSpecificationFactoryExtensions
{
}
