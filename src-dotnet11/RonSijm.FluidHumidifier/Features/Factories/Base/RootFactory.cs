namespace RonSijm.FluidHumidifier.Features.Factories.Base;

public abstract class RootFactory<T> : BaseFactory<T>
{
    public override T Build(bool createChildren = true)
    {
        WireChildDecorators();

        return base.Build(createChildren);
    }
}