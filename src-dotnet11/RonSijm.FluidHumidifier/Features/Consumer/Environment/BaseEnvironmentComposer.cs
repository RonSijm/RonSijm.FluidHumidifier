using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Decorating.ReflectionHelpers;
using RonSijm.FluidHumidifier.Features.Output;

namespace RonSijm.FluidHumidifier.Features.Consumer.Environment;

public abstract class BaseEnvironmentComposer<T>(DecoratorOrchestrator decoratorOrchestrator) : IEnvironmentComposer, IHaveEnvironmentConfig, IHaveDecorators where T : IHaveEnvironmentConfig
{
    public EnvironmentOutputResult CreateResource(T config)
    {
        Environment = config.Environment;

        this.DoForAllFields<IHaveEnvironmentConfig>(x =>
        {
            x.Environment = Environment;
        }, false);

        this.DoForAllFields<IHaveDecorators>(x =>
        {
            x.Decorator = Decorator;
        }, false);


        return Create(config);
    }

    protected abstract EnvironmentOutputResult Create(T config);

    public EnvironmentConfig Environment { get; set; }

    public DecoratorOrchestrator Decorator { get; set; } = decoratorOrchestrator;
}