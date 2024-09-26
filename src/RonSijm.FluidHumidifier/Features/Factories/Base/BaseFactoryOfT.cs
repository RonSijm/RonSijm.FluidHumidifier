using Humidifier.Base;
using RonSijm.FluidHumidifier.Features.Decorating.Extensions;
using RonSijm.FluidHumidifier.Features.Decorating.ReflectionHelpers;
using RonSijm.FluidHumidifier.Features.Factories.Interfaces;
using System.Diagnostics;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Factories.Base;

[DebuggerDisplay("{DebuggerDisplay}")]
public abstract class BaseFactory<T> : BaseFactory, IInvokeBuild
{
    private string DebuggerDisplay
    {
        get
        {
            if (Result == null)
            {
                return $"{typeof(T).Name}-Factory of [Unprocessed {typeof(T).FullName}]";
            }

            if(Result is IHaveGivenName givenName)
            {
                return $"{typeof(T).Name}-Resource-Factory of '{givenName.GivenName}'";
            }

            return $"{typeof(T).Name}-Sub-Factory of '{typeof(T).FullName}'";
        }
    }

    protected abstract T Create();

    public Queue<Action<T>> ExtendedActions { get; set; } = [];

    public void InvokeBuild()
    {
        Build();
    }

    public virtual T Build(bool createChildren = true)
    {
        var result = Create();

        PropertiesDecorator.FillInProperties(this);

        if (createChildren)
        {
            this.Decorate(result, DecoratorType.BeforeChildren);
            CreateChildren(result);
            this.Decorate(result, DecoratorType.AfterChildren);
        }

        Result = result;
        return result;
    }

    public T Result { get; set; }

    public virtual void CreateChildren(T result)
    {
        this.DoForPublicProperties<IStackFactory>(childFactory =>
        {
            childFactory.InvokeBuild();
        });
    }
}