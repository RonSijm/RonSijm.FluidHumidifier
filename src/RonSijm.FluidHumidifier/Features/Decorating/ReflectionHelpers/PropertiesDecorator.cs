using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.ReflectionHelpers;

public static class PropertiesDecorator
{
    public static void FillInProperties(IHaveDecorators target)
    {
        var properties = target.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var decorator in target.Decorator.Decorators)
        {
            var decoratorType = decorator.GetType();
            var interfaces = decoratorType.GetInterfaces()
                .Where(i => typeof(IWantProperty).IsAssignableFrom(i) && i != typeof(IWantProperty));

            foreach (var interfaceDeclaration in interfaces)
            {
                var interfaceProperties = interfaceDeclaration.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var interfaceProperty in interfaceProperties)
                {
                    var property = properties.FirstOrDefault(p => p.Name == interfaceProperty.Name);

                    if (property != null)
                    {
                        var value = property.GetValue(target);
                        interfaceProperty.SetValue(decorator, value);
                    }
                    else
                    {
                        var variables = target.Decorator.Variables.TryGetValue(interfaceProperty.Name, out var value);

                        if (variables)
                        {
                            interfaceProperty.SetValue(decorator, value);
                        }
                    }
                }
            }
        }
    }
}