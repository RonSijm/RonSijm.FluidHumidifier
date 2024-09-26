// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerDistributionConfigurationTargetContainerRepositoryFactory(Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository>
{

    protected override Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository Create()
    {
        var targetContainerRepositoryResult = CreateTargetContainerRepository();
        factoryAction?.Invoke(targetContainerRepositoryResult);

        return targetContainerRepositoryResult;
    }

    private Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository CreateTargetContainerRepository()
    {
        var targetContainerRepositoryResult = new Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository();

        return targetContainerRepositoryResult;
    }

} // End Of Class

public static class InnerDistributionConfigurationTargetContainerRepositoryFactoryExtensions
{
}
