namespace RonSijm.FluidHumidifier.Features.Consumer
{
    public abstract class BaseStackComposer<T> : BaseStackComposer, IStackComposer<T>
    {
        public abstract StackCreateResult Create(T config);
    }
}
