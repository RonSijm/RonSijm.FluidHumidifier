using Humidifier.EC2;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.EC2;

public class SecurityGroupDescriptionDecorator : BaseTypeDecorator<SecurityGroup>, IWantEnvironmentName
{
    // Rank matter because you could decorate target.GivenName first if you want, to affect the description
    public override int Rank { get; set; } = 50;

    public override void Decorate(SecurityGroup target)
    {
        target.GroupDescription = $"Default {EnvironmentName} Security Group for {target.GivenName}";
    }
    public string EnvironmentName { get; set; }
}