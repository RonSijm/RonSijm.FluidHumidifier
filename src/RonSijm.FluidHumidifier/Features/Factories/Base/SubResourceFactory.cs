using RonSijm.FluidHumidifier.Features.Decorating.Extensions;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Factories.Base;

public abstract class SubResourceFactory<T> : BaseFactory<T>
{
    public override T Build(bool createChildren = true)
    {
        var result = base.Build(false);

        foreach (var customAction in ExtendedActions)
        {
            customAction.Invoke(result);
        }

        this.Decorate(result, DecoratorType.BeforeChildren);
        CreateChildren(result);
        this.Decorate(result, DecoratorType.AfterChildren);

        return result;
    }
}