using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Factories.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Factories.Extensions;

public static class FactoryCreator
{
    public static TOut CreateSubFactory<TOut>(this IHaveDecorators create, Func<TOut> factory, bool addAsSubFactory = true) where TOut : IHaveDecorators
    {
        var instance = factory();
        instance.Decorator = create.Decorator;

        if (create is IHaveStack hasStack)
        {
            if (instance is IHaveStack hasStackInstance)
            {
                hasStackInstance.Stack = hasStack.Stack;
            }
        }

        if (addAsSubFactory && create is BaseFactory baseFactory)
        {
            baseFactory.ExtendedSubFactories.Add(instance);
        }

        return instance;
    }
}