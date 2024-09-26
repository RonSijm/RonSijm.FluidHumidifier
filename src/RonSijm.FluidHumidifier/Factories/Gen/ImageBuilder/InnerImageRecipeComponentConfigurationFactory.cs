// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageRecipeComponentConfigurationFactory(Action<Humidifier.ImageBuilder.ImageRecipeTypes.ComponentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageRecipeTypes.ComponentConfiguration>
{

    protected override Humidifier.ImageBuilder.ImageRecipeTypes.ComponentConfiguration Create()
    {
        var componentConfigurationResult = CreateComponentConfiguration();
        factoryAction?.Invoke(componentConfigurationResult);

        return componentConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImageRecipeTypes.ComponentConfiguration CreateComponentConfiguration()
    {
        var componentConfigurationResult = new Humidifier.ImageBuilder.ImageRecipeTypes.ComponentConfiguration();

        return componentConfigurationResult;
    }

} // End Of Class

public static class InnerImageRecipeComponentConfigurationFactoryExtensions
{
}
