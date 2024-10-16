// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithElasticLoadBalancingV2TargetGroupExtension
{
    public static CombinedResult<VPCFactory, ElasticLoadBalancingV2.TargetGroupFactory> WithTargetGroup(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.ElasticLoadBalancingV2.TargetGroup> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new ElasticLoadBalancingV2.TargetGroupFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, ElasticLoadBalancingV2.TargetGroupFactory>(factory, childResourceFactory);
    }
}
