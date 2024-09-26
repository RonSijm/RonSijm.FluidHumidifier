using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Decorating.ReflectionHelpers;
using RonSijm.FluidHumidifier.Features.Factories.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Factories.Base;

public abstract class BaseFactory : IHaveDecorators
{
    public DecoratorOrchestrator Decorator { get; set; }
    
    protected void WireChildDecorators()
    {
        this.DoForAllProperties<IHaveDecorators>(x => x.Decorator = Decorator);
    }

    protected void WireChildStack(Stack stack)
    {
        this.DoForAllProperties<IHaveStack>(x => x.Stack = stack);
    }

    internal List<IStackFactory> ExtendedResourceFactories { get; set; } = [];
    internal List<IHaveDecorators> ExtendedSubFactories { get; set; } = [];
}