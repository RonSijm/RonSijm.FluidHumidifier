using Humidifier.ECR;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.ECR;

public class ECRRepositoryNameDecorator : BaseTypeDecorator<Repository>, IWantEnvironmentName
{
    // Rank matter because you could decorate target.GivenName first if you want, to affect the name.
    // Post-fixing with -SecurityGroup is a common pattern. But with lower priority, to rename it in other decorators first.
    public override int Rank { get; set; } = 200;

    public override void Decorate(Repository target)
    {
        target.RepositoryName = $"{target.GivenName}-{EnvironmentName}-ecr-registry";
    }

    public string EnvironmentName { get; set; }
}