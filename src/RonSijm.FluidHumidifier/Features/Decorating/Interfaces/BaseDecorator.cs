namespace RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

public abstract class BaseDecorator(DecoratorType decoratorType = DecoratorType.BeforeChildren) : IDecorator
{
    public bool Disabled { get; set; }
    public abstract int Rank { get; set; }
    public DecoratorType DecoratorType { get; set; } = decoratorType;
    public abstract bool CanHandle(object target);
    public abstract void Decorate(object target);
}