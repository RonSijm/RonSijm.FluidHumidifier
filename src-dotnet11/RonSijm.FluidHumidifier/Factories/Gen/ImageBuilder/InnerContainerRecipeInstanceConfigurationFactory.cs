// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerContainerRecipeInstanceConfigurationFactory(Action<Humidifier.ImageBuilder.ContainerRecipeTypes.InstanceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ContainerRecipeTypes.InstanceConfiguration>
{

    protected override Humidifier.ImageBuilder.ContainerRecipeTypes.InstanceConfiguration Create()
    {
        var instanceConfigurationResult = CreateInstanceConfiguration();
        factoryAction?.Invoke(instanceConfigurationResult);

        return instanceConfigurationResult;
    }

    private Humidifier.ImageBuilder.ContainerRecipeTypes.InstanceConfiguration CreateInstanceConfiguration()
    {
        var instanceConfigurationResult = new Humidifier.ImageBuilder.ContainerRecipeTypes.InstanceConfiguration();

        return instanceConfigurationResult;
    }

} // End Of Class

public static class InnerContainerRecipeInstanceConfigurationFactoryExtensions
{
}
