using Humidifier.EC2;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.EC2;

public class SecurityGroupNameDecorator : BaseTypeDecorator<SecurityGroup>, IWantEnvironmentName
{
    // Rank matter because you could decorate target.GivenName first if you want, to affect the name.
    // Post-fixing with -SecurityGroup is a common pattern. But with lower priority, to rename it in other decorators first.
    public override int Rank { get; set; } = 200;

    public override void Decorate(SecurityGroup target)
    {
        target.GivenName = $"{target.GivenName}-SecurityGroup";
    }

    public string EnvironmentName { get; set; }
}