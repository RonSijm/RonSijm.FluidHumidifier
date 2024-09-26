namespace RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

public abstract class BaseTwoTypeDecorator<T1, T2> : BaseDecorator, IDecorator
{
    public override bool CanHandle(object target)
    {
        return !Disabled && target is T1 or T2;
    }

    public override void Decorate(object target)
    {
        if (target is T1 t1)
        {
            Decorate(t1);
        }
        else if (target is T2 t2)
        {
            Decorate(t2);
        }
    }

    public abstract void Decorate(T1 target);
    public abstract void Decorate(T2 target);
}