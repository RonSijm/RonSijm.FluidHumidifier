using Humidifier.ElastiCache;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.ElastiCache;

public class ReplicationGroupNameDecorator : BaseTypeDecorator<ReplicationGroup>, IWantEnvironmentName, IWantStackName
{
    // Rank matter because you could decorate target.GivenName first if you want, to affect the description
    public override int Rank { get; set; } = 100;

    public override void Decorate(ReplicationGroup target)
    {
        target.ResourceName = $"{target.GivenName}-ReplicationGroup";
    }

    public string EnvironmentName { get; set; }
    public string StackName { get; set; }
}