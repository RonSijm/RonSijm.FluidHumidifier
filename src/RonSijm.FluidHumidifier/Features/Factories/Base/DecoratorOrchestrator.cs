using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Factories.Base
{
    public class DecoratorOrchestrator(IEnumerable<IDecorator> decorators)
    {
        public List<IDecorator> Decorators { get; } = decorators.OrderBy(x => x.Rank).ToList();
        public Dictionary<string, object> Variables { get; set; } = new();
    }
}