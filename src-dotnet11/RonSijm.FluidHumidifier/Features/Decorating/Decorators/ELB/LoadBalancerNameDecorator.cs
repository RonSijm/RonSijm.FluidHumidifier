using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.ELB;

public class LoadBalancerNameDecorator : BaseTypeDecorator<Humidifier.ElasticLoadBalancingV2.LoadBalancer>, IWantEnvironmentName, IWantStackName
{
    // Rank matter because you could change the resource name to affect the policy name
    public override int Rank { get; set; } = 50;

    public override void Decorate(Humidifier.ElasticLoadBalancingV2.LoadBalancer target)
    {
        target.GivenName = $"{target.GivenName}-{StackName}-{EnvironmentName}-LB";
    }

    public string EnvironmentName { get; set; }
    public string StackName { get; set; }
}

public class TargetGroupNameDecorator : BaseTypeDecorator<Humidifier.ElasticLoadBalancingV2.TargetGroup>, IWantElasticLoadBalancingV2LoadBalancer
{
    // Rank matter because you could change the resource name to affect the policy name
    public override int Rank { get; set; } = 50;

    public override void Decorate(Humidifier.ElasticLoadBalancingV2.TargetGroup target)
    {
        target.GivenName = $"{ElasticLoadBalancingV2_LoadBalancer}-TG";
    }
    public string ElasticLoadBalancingV2_LoadBalancer { get; set; }
}

public class ListenerNameDecorator : BaseTypeDecorator<Humidifier.ElasticLoadBalancingV2.Listener>, IWantElasticLoadBalancingV2LoadBalancer
{
    // Rank matter because you could change the resource name to affect the policy name
    public override int Rank { get; set; } = 50;

    public override void Decorate(Humidifier.ElasticLoadBalancingV2.Listener target)
    {
        target.GivenName = $"{ElasticLoadBalancingV2_LoadBalancer}-Listener";
    }
    public string ElasticLoadBalancingV2_LoadBalancer { get; set; }
}