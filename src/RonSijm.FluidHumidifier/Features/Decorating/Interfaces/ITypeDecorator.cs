namespace RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

public interface ITypeDecorator<in T> : IDecorator where T : class
{
    bool IDecorator.CanHandle(object target)
    {
        return target is T;
    }

    void IDecorator.Decorate(object target)
    {
        Decorate(target as T);
    }

    void Decorate(T target);
}