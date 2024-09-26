namespace RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

public abstract class BaseTypeDecorator<T> : BaseDecorator, ITypeDecorator<T> where T : class
{
    public override bool CanHandle(object target)
    {
        return !Disabled && target is T;
    }

    public override void Decorate(object target)
    {
        Decorate(target as T);
    }

    public abstract void Decorate(T target);
}