namespace RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

public abstract class BaseMultiTypeDecorator : BaseDecorator, IDecorator
{
    private readonly Type[] _supportedTypes;

    protected BaseMultiTypeDecorator(params Type[] supportedTypes)
    {
        if (supportedTypes == null || supportedTypes.Length == 0)
        {
            throw new ArgumentException("If you don't support any times, this class doesn't do anything.", nameof(supportedTypes));
        }

        _supportedTypes = supportedTypes;
    }

    public override bool CanHandle(object target)
    {
        return !Disabled && target!= null && _supportedTypes.Contains(target.GetType());
    }
}