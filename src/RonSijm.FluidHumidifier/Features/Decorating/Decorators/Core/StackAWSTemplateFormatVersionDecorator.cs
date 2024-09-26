using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.Core;

public class StackAWSTemplateFormatVersionDecorator : BaseTypeDecorator<Stack>
{
    // Rank doesn't matter since this is just a stack value that needs to be this value
    public override int Rank { get; set; } = 0;

    public override void Decorate(Stack target)
    {
        target.AWSTemplateFormatVersion = "2010-09-09";
    }
}