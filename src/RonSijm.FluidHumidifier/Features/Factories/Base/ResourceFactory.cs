using Humidifier.Base;
using Humidifier.Interfaces;
using RonSijm.FluidHumidifier.Features.Decorating.Extensions;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Factories.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Factories.Base;

public abstract class ResourceFactory<T>(string inputResourceName, bool isInnerFactory = false) : BaseFactory<T>, IResultFactory<T>, IStackFactory where T : BaseResource
{
    public Stack Stack { get; set; }

    public string InputResourceName { get; set; } = inputResourceName;

    public override T Build(bool createChildren = true)
    {
        var result = base.Build(false);

        while (ExtendedActions.Count > 0)
        {
            var customAction = ExtendedActions.Dequeue();
            customAction.Invoke(result);
        }

        this.Decorate(result, DecoratorType.BeforeChildren);
        CreateChildren(result);
        this.Decorate(result, DecoratorType.AfterChildren);

        if (!isInnerFactory)
        {
            if (result is BaseResource resource)
            {
                Stack.Add(resource);
            }
        }

        return result;
    }

    public override void CreateChildren(T result)
    {
        var name = result.AWSTypeName.Replace("AWS::", string.Empty).Replace("::", "_");

        Decorator.Variables[name] = result.GivenName;
        Decorator.Variables["ResourceName"] = result.GivenName;
        base.CreateChildren(result);
    }
}