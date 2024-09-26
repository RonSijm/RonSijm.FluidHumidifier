using RonSijm.FluidHumidifier.Factories.Base;
using RonSijm.FluidHumidifier.Features.Consumer.Environment;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Consumer
{
    public abstract class BaseStackComposer : IHaveDecorators, IHaveEnvironmentConfig
    {
        public EnvironmentConfig Environment { get; set; }
        public DecoratorOrchestrator Decorator { get; set; }

        public EnvironmentFactory CreateEnvironmentFactory()
        {
            var factory = new EnvironmentFactory(Environment)
            {
                Decorator = Decorator
            };

            return factory;
        }
    }
}