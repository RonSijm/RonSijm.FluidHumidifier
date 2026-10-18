namespace RonSijm.FluidHumidifier.Features.Consumer
{
    public interface IStackComposer<in T> : IStackComposer
    {
        StackCreateResult IStackComposer.Create(object config)
        {
            var typed = (T)config;
            return Create(typed);
        }

        StackCreateResult Create(T config);
    }
}
