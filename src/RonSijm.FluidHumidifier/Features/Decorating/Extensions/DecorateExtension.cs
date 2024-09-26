using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Decorating.Extensions;

public static class DecorateExtension
{
    public static void Decorate(this IHaveDecorators decorators, object target, DecoratorType type)
    {
        var usableDecorator = decorators.Decorator.Decorators.Where(decorator => decorator.DecoratorType == type && decorator.CanHandle(target)).ToList();

        foreach (var decorator in usableDecorator)
        {
            decorator.Decorate(target);
        }
    }
}