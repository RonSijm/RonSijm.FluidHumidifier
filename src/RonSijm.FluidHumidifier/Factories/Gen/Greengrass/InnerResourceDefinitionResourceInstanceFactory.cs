// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionResourceInstanceFactory(Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance>
{

    protected override Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance Create()
    {
        var resourceInstanceResult = CreateResourceInstance();
        factoryAction?.Invoke(resourceInstanceResult);

        return resourceInstanceResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance CreateResourceInstance()
    {
        var resourceInstanceResult = new Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance();

        return resourceInstanceResult;
    }

} // End Of Class

public static class InnerResourceDefinitionResourceInstanceFactoryExtensions
{
}
