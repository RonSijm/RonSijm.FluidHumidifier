// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerContainerRecipeComponentConfigurationFactory(Action<Humidifier.ImageBuilder.ContainerRecipeTypes.ComponentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ContainerRecipeTypes.ComponentConfiguration>
{

    protected override Humidifier.ImageBuilder.ContainerRecipeTypes.ComponentConfiguration Create()
    {
        var componentConfigurationResult = CreateComponentConfiguration();
        factoryAction?.Invoke(componentConfigurationResult);

        return componentConfigurationResult;
    }

    private Humidifier.ImageBuilder.ContainerRecipeTypes.ComponentConfiguration CreateComponentConfiguration()
    {
        var componentConfigurationResult = new Humidifier.ImageBuilder.ContainerRecipeTypes.ComponentConfiguration();

        return componentConfigurationResult;
    }

} // End Of Class

public static class InnerContainerRecipeComponentConfigurationFactoryExtensions
{
}
