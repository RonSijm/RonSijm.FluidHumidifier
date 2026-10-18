namespace RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

[UsedImplicitly(ImplicitUseTargetFlags.WithInheritors)]
public interface IDecorator
{
    public int Rank { get; set; }

    public DecoratorType DecoratorType { get; set; }


    public bool CanHandle(object target);

    void Decorate(object target);
}