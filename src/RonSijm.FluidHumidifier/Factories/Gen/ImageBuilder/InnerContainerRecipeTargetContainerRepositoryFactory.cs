// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerContainerRecipeTargetContainerRepositoryFactory(Action<Humidifier.ImageBuilder.ContainerRecipeTypes.TargetContainerRepository> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ContainerRecipeTypes.TargetContainerRepository>
{

    protected override Humidifier.ImageBuilder.ContainerRecipeTypes.TargetContainerRepository Create()
    {
        var targetContainerRepositoryResult = CreateTargetContainerRepository();
        factoryAction?.Invoke(targetContainerRepositoryResult);

        return targetContainerRepositoryResult;
    }

    private Humidifier.ImageBuilder.ContainerRecipeTypes.TargetContainerRepository CreateTargetContainerRepository()
    {
        var targetContainerRepositoryResult = new Humidifier.ImageBuilder.ContainerRecipeTypes.TargetContainerRepository();

        return targetContainerRepositoryResult;
    }

} // End Of Class

public static class InnerContainerRecipeTargetContainerRepositoryFactoryExtensions
{
}
