using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.Core;

public class StackDescriptionDecorator : BaseTypeDecorator<Stack>, IWantEnvironmentName, IWantStackName
{
    // Rank doesn't matter since it doesn't use variables that could be changed by other Decorators
    public override int Rank { get; set; } = 1;

    public override void Decorate(Stack target)
    {
        target.Description = $"CloudFormation Stack For {StackName} For {EnvironmentName} Environment";
    }

    public string EnvironmentName { get; set; }
    public string StackName { get; set; }
}