using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.Core;

public class StackNameDecorator : BaseTypeDecorator<Stack>, IWantEnvironmentName, IWantStackName
{
    // Rank doesn't matter since it doesn't use variables that could be changed by other Decorators
    public override int Rank { get; set; } = 1;

    public override void Decorate(Stack target)
    {
        target.Name = StackName.Replace(" ", string.Empty);
    }

    public string EnvironmentName { get; set; }
    public string StackName { get; set; }
}