// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTTwinMaker;

public class ComponentTypeFactory(string resourceName = null, Action<Humidifier.IoTTwinMaker.ComponentType> factoryAction = null) : ResourceFactory<Humidifier.IoTTwinMaker.ComponentType>(resourceName)
{

    protected override Humidifier.IoTTwinMaker.ComponentType Create()
    {
        var componentTypeResult = CreateComponentType();
        factoryAction?.Invoke(componentTypeResult);

        return componentTypeResult;
    }

    private Humidifier.IoTTwinMaker.ComponentType CreateComponentType()
    {
        var componentTypeResult = new Humidifier.IoTTwinMaker.ComponentType
        {
            GivenName = InputResourceName,
        };

        return componentTypeResult;
    }

} // End Of Class

public static class ComponentTypeFactoryExtensions
{
}
