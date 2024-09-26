using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.IAM;

public class IAMPolicyNameDecorator : BaseTypeDecorator<Humidifier.IAM.UserTypes.Policy>, IWantResourceName
{
    // Rank matter because you could decorate target.GivenName first if you want, to affect the name.
    // Post-fixing with -Policy is a common pattern. But with lower priority, to rename it in other decorators first.
    public override int Rank { get; set; } = 200;

    public override void Decorate(Humidifier.IAM.UserTypes.Policy target)
    {
        target.PolicyName = $"{ResourceName}-{target.PolicyName}-Policy";
    }

    public string ResourceName { get; set; }
}