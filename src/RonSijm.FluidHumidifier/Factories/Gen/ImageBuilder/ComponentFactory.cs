// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class ComponentFactory(string resourceName = null, Action<Humidifier.ImageBuilder.Component> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.Component>(resourceName)
{

    protected override Humidifier.ImageBuilder.Component Create()
    {
        var componentResult = CreateComponent();
        factoryAction?.Invoke(componentResult);

        return componentResult;
    }

    private Humidifier.ImageBuilder.Component CreateComponent()
    {
        var componentResult = new Humidifier.ImageBuilder.Component
        {
            GivenName = InputResourceName,
        };

        return componentResult;
    }

} // End Of Class

public static class ComponentFactoryExtensions
{
}
