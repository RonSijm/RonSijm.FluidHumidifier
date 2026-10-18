using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.Core;
public class PolicyDocumentVersionDecorator : BaseTypeDecorator<PolicyDocument>
{
    // Rank doesn't matter since this is just a stack value that needs to be this value
    public override int Rank { get; set; } = 0;

    public override void Decorate(PolicyDocument target)
    {
        target.Version = "2012-10-17";
    }
}